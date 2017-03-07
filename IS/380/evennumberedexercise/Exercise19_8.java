// Exercise19_8.java: Define threads using the Thread class
import java.util.*;

public class Exercise19_8 {
  /** Main method */
  public static void main(String[] args) {
    new Exercise19_8();
  }

  public Exercise19_8() {
    // Start threads
    new Producer().start();
    new Consumer().start();
  }

  private Stack stack = new Stack();
  private int i = 0;
  class Producer extends Thread {
    public void run() {
      while (true) {
          System.out.println("Producer: put " + i);
          stack.push(new Integer(i++));
          synchronized (stack) {
            stack.notifyAll();
          }
      }
    }
  }

  class Consumer extends Thread {
    public void run() {
      while (true) {
        synchronized (stack) {
          try {
            while (stack.isEmpty())
              stack.wait();
            System.out.println("Consumer: get " + stack.pop());
          }
          catch (InterruptedException ex) {
            ex.printStackTrace();
          }
        }
      }
    }
  }
}
