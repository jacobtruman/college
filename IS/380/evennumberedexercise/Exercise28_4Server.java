// Exercise28_4Server.java: Web visit count server
import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise28_4Server extends JFrame implements ActionListener {
  protected JTextArea jta = new JTextArea();
  protected JButton jbtStop = new JButton("Stop");

  protected RandomAccessFile raf;
  protected String countFile = "webcount.dat"; // File to store count
  protected static int count;

  private ServerSocket serverSocket;

  public Exercise28_4Server() {
    // Create a scroll pane to hold text area
    JScrollPane jsp = new JScrollPane(jta);

    // Add panel and scroll panel to the frame
    Container container = getContentPane();
    container.add(jsp, BorderLayout.CENTER);
    container.add(jbtStop, BorderLayout.SOUTH);

    // Register listener
    jbtStop.addActionListener(this);

    setTitle("Exercise28_4Server: Web Visit Count Server");
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setSize(300, 300);
    setVisible(true);

    startup();
  }

  private void startup() {
    try {
      serverSocket = new ServerSocket(8000);
      jta.append("Server started " + "\n\n");

      // Determine whether webcount.dat already exists
      if (new File(countFile).exists()) {
        raf = new RandomAccessFile(countFile, "rw");
        count = raf.readInt(); // Obtain count
      }
      else {
        raf = new RandomAccessFile(countFile, "rw");
        count = 0;
      }

      int i = 0;
      while (true) {
        Socket connectToClient = serverSocket.accept();
        jta.append("Starting thread " + i + "\n");
          jta.append("Client IP " +
          connectToClient.getInetAddress() + "\n");
        WebVisitHandler thread =
          new WebVisitHandler(connectToClient);
        thread.start();
        i++;
      }
    }
    catch(IOException ex) {
      jta.append(ex + "\n");
    }
  }

  public void actionPerformed(ActionEvent e) {
    if (e.getSource() == jbtStop) {
      try {
        if (raf != null) {
          // Store the count
          raf.seek(0);
          raf.writeInt(count);
          raf.close();
        }
      }
      catch (IOException ex) {
        jta.append(ex + "\n");
      }
    }

    System.exit(0);
  }

  public static void main(String args[]) {
    Exercise28_4Server frame = new Exercise28_4Server();
  }

  public static synchronized int increaseCount() {
    return ++count;
  }

  class WebVisitHandler extends Thread {
    private Socket connectToClient;

    public WebVisitHandler(Socket c) {
      connectToClient = c;
    }

    public void run() {
      try {
        PrintWriter osToClient =
          new PrintWriter(connectToClient.getOutputStream(), true);

        int newCount = increaseCount();

        // Send count to the client
        osToClient.println(newCount);
      }
      catch (IOException ex) {
        jta.append(ex + "\n");
      }
    }
  }
}