// Exercise19_2.java: 100 threads, each adds 1 to a variable sum
public class Exercise19_2 {
  private Integer sum = new Integer(0);
  private Thread[] thread = new Thread[1000];

  public static void main(String[] args) {
    Exercise19_2 test = new Exercise19_2();
    System.out.println("What is sum ? " + test.sum);
  }

  public Exercise19_2() {
    ThreadGroup g1 = new ThreadGroup("group");
    boolean done = false;

    for (int i = 0; i < 1000; i++) {
      thread[i] = new Thread(g1, new SumThread(), "t");
      thread[i].start();
    }

    while(!done)
      if (g1.activeCount() == 0)
        done = true;
  }

  class SumThread extends Thread {
    public void run() {
      int value = sum.intValue() + 1;
      sum = new Integer(value);
    }
  }
}

