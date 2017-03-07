// Exercise28_6Server.java:
// modified 5/1/2000, 5/22/99, 10/7/98
import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;

public class Exercise28_6Server {
  // Declare a random access file
  RandomAccessFile raf = null;

  public static void main(String args[]) {
    new Exercise28_6Server();
  }

  public Exercise28_6Server() {
    // Open the local file on the server side
    try {
      // Open the file if the file exists, create a new file if the file does not exist
      raf = new RandomAccessFile("student.dat", "rw");
    }
    catch(IOException e) {
      System.out.print("Error: " + e);
      System.exit(0);
    }

    // Establish server socket
    try {
      // Create a server socket
      ServerSocket ss = new ServerSocket(8000);
      int count = 1;

      ThreadGroup tg = new ThreadGroup("serving clients");

      while (true) {
        if (tg.activeCount() < 2) {
          // Connect to a client
          Socket s = ss.accept();

          // Start a new thread to register a client
          Thread t = new Thread(tg, new RegistrationThread(s, count++));
          t.start();

          System.out.println(tg.activeCount() + " active threads");
        }
        else {
          try {Thread.sleep(200); }
          catch (InterruptedException ex) { }
        }
      }
    }
    catch (IOException e) {
      System.err.println(e);
    }
  }

// Define a thread to process the client registration
class RegistrationThread extends Thread {
  private Socket sock;  // The socket to serve a client

  private int num; //the socket label

  // The file to store the records
  // Buffer reader to get input from the client
  private BufferedReader in;
  private PrintWriter out;

  public RegistrationThread(Socket sock, int num) {
    this.sock = sock;
    this.num = num;

    System.out.println("Thread " + num + " running");

    // Create an input stream to receive data from a client
    try {
      in = new BufferedReader
        (new InputStreamReader(sock.getInputStream()));
      out = new PrintWriter(sock.getOutputStream(), true);
    }
    catch(IOException ex) {
      System.out.println("Error " + ex);
    }
  }

  public void run() {
    String name;
    String street;
    String city;
    String state;
    String zip;

    try {
      // Get command
      String command = in.readLine();

      if (command.equals("Register")) {
        // Receive data from the client
        name = new String(in.readLine());
        street = new String(in.readLine());
        city = new String(in.readLine());
        state = new String(in.readLine());
        zip = new String(in.readLine());

        // Display data received
        System.out.println("The following data received from the client");
        System.out.println("name: " + name);
        System.out.println("street: " + street);
        System.out.println("city: " + city);
        System.out.println("state: " + state);
        System.out.println("zip: " + zip);

        // Create a student instance
        Student s = new Student(name, street, city, state, zip);

        // Append it to "student.dat"
        raf.seek(raf.length());
        s.writeStudent(raf);
      }
      else if (command.equals("View")) {
        name = new String(in.readLine());
        Student s = search(name);

        if (s == null) {
          out.println("not found");
        }
        else {
          out.println("found");
          out.println(s.getStreet());
          out.println(s.getCity());
          out.println(s.getState());
          out.println(s.getZip());
        }
      }
    }
    catch (IOException e) {
      System.err.println(e);}
    }

    public Student search(String name) {
      Student s = new Student();
      try {
        raf.seek(0);
        long length = raf.length();
        while (raf.getFilePointer() < length) {
          s.readStudent(raf);
          if (name.trim().equals(s.getName().trim())) return s;
          System.out.println("Find anything?" + name + "  " + s.getName());
        }
      }
      catch(IOException ex) {
        System.out.print("Error: " + ex);
      }

      return null;
  }
}

class Student {
  private String name;
  private String street;
  private String city;
  private String state;
  private String zip;

  // The size of five string fields in the record
  final int NAME_SIZE = 32;

  final int STREET_SIZE = 32;
  final int CITY_SIZE = 20;
  final int STATE_SIZE = 2;
  final int ZIP_SIZE = 5;

  // The total size of the record in bytes, a Unicode
  // character is 2 bytes size.*/
  final int RECORD_SIZE =
    (NAME_SIZE + STREET_SIZE + CITY_SIZE + STATE_SIZE + ZIP_SIZE);

  Student() {
  }

  Student(String name, String street, String city,
          String state, String zip  ) {
    this.name = name;
    this.street = street;
    this.city = city;
    this.state = state;
    this.zip = zip;
  }

  public String getName() {
    return name;
  }

  public String getStreet() {
    return street;
  }

  public String getCity() {
    return city;
  }

  public String getState() {
    return state;
  }

  public String getZip() {
    return zip;
  }

  public void writeStudent(DataOutput out) throws IOException {
    FixedLengthStringIO.writeFixedLengthString(
      name, NAME_SIZE, out);
    FixedLengthStringIO.writeFixedLengthString(
      street, STREET_SIZE, out);
    FixedLengthStringIO.writeFixedLengthString(
      city, CITY_SIZE, out);
    FixedLengthStringIO.writeFixedLengthString(
      state, STATE_SIZE, out);
    FixedLengthStringIO.writeFixedLengthString(
      zip, ZIP_SIZE, out);
  }

  public void readStudent(DataInput in) throws IOException {
    name = FixedLengthStringIO.readFixedLengthString(
      NAME_SIZE, in);
    street = FixedLengthStringIO.readFixedLengthString(
      STREET_SIZE, in);
    city = FixedLengthStringIO.readFixedLengthString(
      CITY_SIZE, in);
    state = FixedLengthStringIO.readFixedLengthString(
      STATE_SIZE, in);
    zip = FixedLengthStringIO.readFixedLengthString(
      ZIP_SIZE, in);
  }
}
}