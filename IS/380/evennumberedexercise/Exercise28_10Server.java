// Exercise28_10Server.java
import java.io.*;
import java.net.*;
import java.util.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.*;

public class Exercise28_10Server extends JFrame {
  // Text area for entering server text
  private JTextArea jtaServer = new JTextArea();
  
  // Text area for displaying client text
  private JTextArea jtaClient = new JTextArea();
  
  private PrintWriter output;
  
  public static void main(String[] args) {
    new Exercise28_10Server();
  }
  
  public Exercise28_10Server() {
    // Place text area on the frame
    getContentPane().setLayout(new GridLayout(2, 1));
    JScrollPane jScrollPane1 = new JScrollPane(jtaServer);
    JScrollPane jScrollPane2 = new JScrollPane(jtaClient);
    jScrollPane1.setBorder(new TitledBorder("Server"));
    jScrollPane2.setBorder(new TitledBorder("Client"));
    getContentPane().add(jScrollPane1, BorderLayout.CENTER);
    getContentPane().add(jScrollPane2, BorderLayout.CENTER);
    
    jtaServer.setWrapStyleWord(true);
    jtaServer.setLineWrap(true);
    jtaClient.setWrapStyleWord(true);
    jtaClient.setLineWrap(true);
//    jtaClient.setEditable(false);
    
    setTitle("Exercise28_10Server");
    setSize(500, 300);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setVisible(true); // It is necessary to show the frame here!
    
    try {
      // Create a server socket
      ServerSocket serverSocket = new ServerSocket(8000);
      
      // Listen for a new connection request
      Socket connectToClient = serverSocket.accept();
      output = new
        PrintWriter(connectToClient.getOutputStream());
      new SendThread(connectToClient).start();
      new ReceiveThread(connectToClient).start();
    }
    catch(IOException ex) {
      System.err.println(ex);
    }
    
    jtaServer.addKeyListener(new KeyAdapter() {
      public void keyPressed(KeyEvent e) {
        if (e.getKeyCode() == e.VK_ENTER) {
          output.print(jtaServer.getText());
        }
      }
    });
  }
  
  class SendThread extends Thread {
    SendThread(Socket socket) {
      // Keep sending to the client
      
    }
  }
  
  class ReceiveThread extends Thread {
    ReceiveThread(Socket socket) {
      // Keep receiving from the client
      
    }
  }
}