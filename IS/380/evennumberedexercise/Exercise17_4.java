public class Exercise17_4 {
  public static void main(String[] args) {
    MyStack stack = new MyStack();
    stack.add("Tom");
    stack.add("George");
    stack.add("Peter");
  }
}

// MyStack.java: Implementing a stack using inheritance
class MyStack extends MyArrayList {
  public boolean isEmpty() {
    return isEmpty();
  }

  public int getSize() {
    return size();
  }

  public Object peek() {
    return get(getSize() - 1);
  }

  public Object pop() {
    Object o = get(getSize() - 1);
    remove(getSize() - 1);
    return o;
  }

  public Object push(Object o) {
    add(o);
    return o;
  }

  public int search(Object o) {
    return indexOf(o);
  }

  public String toString() {
    return "stack: " + toString();
  }
}
