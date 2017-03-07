
import javax.swing.*;
import java.awt.*;
public class MyMessagePanel extends JFrame {

private JButton jbtOk = new JButton("OK");
private JButton jbtCancel = new JButton("Cancel");
	public MyMessagePanel() {
		getContentPane().setLayout(new BorderLayout());
		getContentPane().add(new MessagePanel("test"));
		getContentPane().add(jbtOk);
		getContentPane().add(jbtCancel);
	}


	public static void main(String[] args) {

		MyMessagePanel frame = new MyMessagePanel();
		frame.setLayout(new FlowLayout());
		frame.setTitle("MyMessagePanel");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(300, 300);
		frame.setVisible(true);
	}
}