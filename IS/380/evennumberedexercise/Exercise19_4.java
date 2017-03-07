public class Exercise19_4 {
  private Account account = new Account();
  private Thread[] thread = new Thread[100];

  public static void main(String[] args) {
    Exercise19_4 test = new Exercise19_4();
    System.out.println("What is balance ? " +
      test.account.getBalance());
  }

  public Exercise19_4() {
    ThreadGroup g = new ThreadGroup("group");
    boolean done = false;

    // Create and launch 100 threads
    for (int i = 0; i < 100; i++) {
      thread[i] = new Thread(g, new AddAPennyThread(), "t");
      thread[i].start();
    }

    // Check if all the threads are finished
    while(!done)
      if (g.activeCount() == 0)
        done = true;
  }


  // A thread for adding a penny to the piggy account
  class AddAPennyThread extends Thread {
    public void run() {
      synchronized (account) {
        account.deposit(1);
      }
    }
  }
}
