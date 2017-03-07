// Simple Applet Example.

import	java.awt.*;
import	java.applet.*;
import	java.awt.event.*;
import	javax.swing.*;
import	java.text.*;

public class SimpleApplet extends Applet
{
      JLabel myLabel = new JLabel("Hello World!");
      JTextField expTField_TF = new JTextField (20);

   public void init()
   {
      setLayout(new GridLayout(0, 2, 5, 5));

      add(myLabel);
      add(expTField_TF);

   }

}
