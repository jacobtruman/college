public class Exercise17_2 {
  public static void main(String[] args) {
    MyLinkedList list1 = new MyLinkedList(new String[] {
      "Tom", "George", "Peter", "Tom", "Jean", "Jane", "Tom"});
    MyLinkedList list2 = new MyLinkedList(new String[] {
      "Tom", "George", "Michael", "Michelle", "Daniel"});

    list1.addAll(list2);
    System.out.println("Union is : " + list1);

    list1 = new MyLinkedList(new String[] {"Tom", "George",
      "Peter", "Jean", "Jane"});
    list1.removeAll(list2);
    System.out.println("Difference is : " + list1);

    list1 = new MyLinkedList(new String[] {"Tom", "George",
      "Peter", "Michael", "Jean", "Jane"});
    list1.retainAll(list2);
    System.out.println("Intersection is : " + list1);
  }
}

// MyLinkedList.java: List implementation using a linked list
class MyLinkedList extends MyAbstractList {
  private Node first, last;

  /** Create a default list */
  public MyLinkedList() {
  }

  /** Create a list from an array of objects */
  public MyLinkedList(Object[] objects) {
    super(objects);
  }

  /** Return the first element in the list */
  public Object getFirst() {
    if (size == 0) return null;
    else return first.element;
  }

  /** Return the last element in the list */
  public Object getLast() {
    if (size == 0) return null;
    else return last.element;
  }

  /** Add an element to the beginning of the list */
  public void addFirst(Object element) {
    Node newNode = new Node(element);
    newNode.next = first;
    first = newNode;
    size++;

    if (last == null)
      last = first;
  }

  /** Add an element to the end of the list */
  public void addLast(Object element) {
    if (last == null) {
      first = last = new Node(element);
    }
    else {
      last.next = new Node(element);
      last = last.next;
    }

    size++;
  }

  /** Adds a new element o at the specified index in this list
   * The index of the first element is 0 */
  public void add(int index, Object o) {
    if (index == 0) addFirst(o);
    else if (index >= size) addLast(o);
    else {
      Node current = first;
      for (int i = 1; i < index; i++)
        current = current.next;
      Node temp = current.next;
      current.next = new Node(o);
      (current.next).next = temp;
      size++;
    }
  }

  /** Remove the first node and
   *  return the object that is contained in the removed node. */
  public Object removeFirst() {
    if (size == 0) return null;
    else {
      Node temp = first;
      first = first.next;
      size--;
      return temp.element;
    }
  }

  /** Remove the last node and
   * return the object that is contained in the removed node. */
  public Object removeLast() {
    if (size == 0) return null;
    else if (size == 1) {
      Node temp = first;
      first = last = null;
      size = 0;
      return temp;
    }
    else {
      Node current = first;

      for (int i = 0; i < size - 2; i++) {
        current = current.next;
      }

      Node temp = last;
      last = current;
      last.next = null;
      size--;
      return temp.element;
    }
  }

  /** Removes the element at the specified position in this list
   *  Shifts any subsequent elements to the left.
   *  Returns the element that was removed from the list. */
  public Object remove(int index) {
    if ((index < 0) || (index >= size)) return null;
    else if (index == 0) return removeFirst();
    else if (index == size - 1) return removeLast();
    else {
      Node current = first;

      for (int i = 1; i < index; i++) {
        current = current.next;
      }

      Node temp = current.next;
      current.next = current.next.next;
      size--;
      return temp.element;
    }
  }

  /** Override toString() to return elements in the list */
  public String toString() {
    StringBuffer result = new StringBuffer("[");

    Node current = first;
    for (int i = 0; i < size; i++) {
      result.append(current.element);
      current = current.next;
      if (current != null)
        result.append(", "); // Seperate two elements with a comma
      else
        result.append("]"); // Insert the closing ] in the string
    }

    return result.toString();
  }

  /** Clear the list */
  public void clear() {
    first = last = null;
  }

  /** Return true if this list contains the element o */
  public boolean contains(Object o) {
    // Implement it in this exercise
    Node current = first;
    for (int i = 0; i < size; i++) {
      if (current.element.equals(o))
        return true;
      current = current.next;
    }

    return false;
  }

  /** Return the element from this list at the specified index */
  public Object get(int index) {
    // Implement it in this exercise
    if (index < 0 || index > size - 1)
      return null;

    Node current = first;
    for (int i = 0; i < index; i++)
      current = current.next;

    return current.element;
  }

  /** Returns the index of the first matching element in this list.
   *  Returns -1 if no match. */
  public int indexOf(Object o) {
    // Implement it in this exercise
    Node current = first;
    for (int i = 0; i < size; i++) {
      if (current.element.equals(o))
        return i;
      current = current.next;
    }

    return -1;
  }

  /** Returns the index of the last matching element in this list
   *  Returns -1 if no match. */
  public int lastIndexOf(Object o) {
    // Implement it in this exercise
    int lastIndex = -1;
    Node current = first;
    for (int i = 0; i < size; i++) {
      if (current.element.equals(o))
        lastIndex = i;
      current = current.next;
    }

    return lastIndex;
  }

  /** Remove the first node that contains the specified element
    * Return true if the element is removed
    * Return false if no element is removed
    */
  public boolean remove(Object o) {
    Node previous = first;
    Node current;

    if (first != null) {
      if (o.equals(first.element)) {
        first = first.next;
        size--;
        return true;
      }
      else {
        current = first.next;
      }
    }
    else
      return false;

    for (int i = 0; i < size - 1; i++) {
      if (o.equals(current.element)) {
        previous.next = current.next; // Remove the current element
        size--;
        return true;
      }
      else {
        previous = current;
        current = current.next;
      }
    }

    return false;
  }

  /** Replace the element at the specified position in this list
   *  with the specified element. */
  public Object set(int index, Object o) {
    // Implementation left as an exercise
    return null;
  }

  private static class Node {
    Object element;
    Node next;

    public Node(Object o) {
      element = o;
    }
  }
}
