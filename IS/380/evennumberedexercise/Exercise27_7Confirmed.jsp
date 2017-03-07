<!-- Exercise27_7Confirmed.jsp -->
<%@ page import = "java.sql.*" %>
<HTML>
<HEAD>
<TITLE>
Exercise28_7.jsp
</TITLE>
</HEAD>
<BODY>
<%@ page import = "chapter27.StudentBean" %>
<jsp:useBean id="student" class="chapter27.StudentBean"
  scope="application"></jsp:useBean>
<%
  student.storeStudent();
  out.println(student.getFirstName() + " " + student.getLastName() +
    " is now registered in the database");
%>
</BODY>
</HTML>
