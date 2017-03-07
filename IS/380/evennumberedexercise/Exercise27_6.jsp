<!-- Exercise27_6.jsp -->
<%@ page import = "java.sql.*" %>
<HTML>
<HEAD>
<TITLE>
Exercise27_6.jsp
</TITLE>
</HEAD>
<BODY>

<%! // Declaration
  // Use a prepared statement to store a student into the database
  private PreparedStatement pstmt;

  /** Initialize database connection */
  private void initializeJdbc() {
    try {
      // Declare driver and connection string
      String driver = "sun.jdbc.odbc.JdbcOdbcDriver";
      String connectionString = "jdbc:odbc:exampleMDBDataSource";
      // For Oracle
      // String driver = "oracle.jdbc.driver.OracleDriver";
      // String connectionString = "jdbc:oracle:" +
      //   "thin:scott/tiger@liang.armstrong.edu:1521:ora9i";

      // Load the driver
      Class.forName(driver);

      // Connect to the sample database
      Connection conn = DriverManager.getConnection
        (connectionString);

      // Create a Statement
      pstmt = conn.prepareStatement("insert into Address " +
        "(lastName, firstName, mi, telephone, email, street, city, "
         + "state, zip) values (?, ?, ?, ?, ?, ?, ?, ?, ?)");
    }
    catch (Exception ex) {
      System.out.println(ex);
    }
  }

  /** Store a student record to the database */
  private void storeStudent(String lastName, String firstName,
    String mi, String phone, String email, String address,
    String city, String state, String zip) throws SQLException {
    pstmt.setString(1, lastName);
    pstmt.setString(2, firstName);
    pstmt.setString(3, mi);
    pstmt.setString(4, phone);
    pstmt.setString(5, email);
    pstmt.setString(6, address);
    pstmt.setString(7, city);
    pstmt.setString(8, state);
    pstmt.setString(9, zip);
    pstmt.executeUpdate();
  }
%>

<%
  initializeJdbc();

  // Obtain parameters from the client
  String lastName = request.getParameter("lastName");
  String firstName = request.getParameter("firstName");
  String mi = request.getParameter("mi");
  String phone = request.getParameter("telephone");
  String email = request.getParameter("email");
  String address = request.getParameter("street");
  String city = request.getParameter("city");
  String state = request.getParameter("state");
  String zip = request.getParameter("zip");

  try {
    if (lastName.length() == 0 || firstName.length() == 0) {
      out.println("Last Name and First Name are required");
      return; // End the method
    }

    storeStudent(lastName, firstName, mi, phone, email, address,
      city, state, zip);

    out.println(firstName + " " + lastName +
      " is now registered in the database");
  }
  catch(Exception ex) {
    out.println("Error: " + ex.getMessage());
  }
%>
</BODY>
</HTML>
