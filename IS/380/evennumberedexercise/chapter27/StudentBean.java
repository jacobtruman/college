package chapter27;

import java.sql.*;

public class StudentBean {
  // Use a prepared statement to store a student into the database
  private PreparedStatement pstmt;

  private String lastName = "";
  private String firstName = "";
  private String mi = "";
  private String telephone = "";
  private String email = "";
  private String street = "";
  private String city = "";
  private String state = "";
  private String zip = "";

  public StudentBean() {
    initializeJdbc();
  }
//
//  public StudentBean(String lastName, String firstName,
//                     String mi, String telephone, String email, String street,
//                     String city, String state, String zip) {
//    this.lastName = lastName;
//    this.firstName = firstName;
//    this.mi = mi;
//    this.telephone = telephone;
//    this.email = email;
//    this.street = street;
//    this.city = city;
//    this.state = state;
//    this.zip = zip;
//  }

  public String getLastName() {
    return lastName;
  }

  public void setLastName(String lastName) {
    this.lastName = lastName;
  }

  public String getFirstName() {
    return firstName;
  }

  public void setFirstName(String firstName) {
    this.firstName = firstName;
  }

  public String getMi() {
    return mi;
  }

  public void setMi(String mi) {
    this.mi = mi;
  }

  public String getTelephone() {
    return telephone;
  }

  public void setTelephone(String telephone) {
    this.telephone = telephone;
  }

  public String getEmail() {
    return email;
  }

  public void setEmail(String email) {
    this.email = email;
  }

  public String getStreet() {
    return street;
  }

  public void setStreet(String street) {
    this.street = street;
  }

  public String getCity() {
    return city;
  }

  public void setCity(String city) {
    this.city = city;
  }

  public String getState() {
    return state;
  }

  public void setState(String state) {
    this.state = state;
  }

  public String getZip() {
    return zip;
  }

  public void setZip(String zip) {
    this.zip = zip;
  }

  /** Initialize database connection */
  private void initializeJdbc() {
    try {
      // Declare driver and connection string
      String driver = "sun.jdbc.odbc.JdbcOdbcDriver";
      String connectionString = "jdbc:odbc:exampleMDBDataSource";

      // Load the Oracle JDBC Thin driver
      Class.forName(driver);
      System.out.println("Driver " + driver + " loaded");

      // Connect to the sample database
      Connection conn = DriverManager.getConnection
          (connectionString);
      System.out.println("Database " + connectionString +
                         " connected");

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
  public void storeStudent() throws SQLException {
    pstmt.setString(1, lastName);
    pstmt.setString(2, firstName);
    pstmt.setString(3, mi);
    pstmt.setString(4, telephone);
    pstmt.setString(5, email);
    pstmt.setString(6, street);
    pstmt.setString(7, city);
    pstmt.setString(8, state);
    pstmt.setString(9, zip);
    pstmt.executeUpdate();
  }
}

