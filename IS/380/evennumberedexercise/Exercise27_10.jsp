<!-- Exercise27_10.jsp -->
<HTML>
<HEAD>
<TITLE>
Exercise27_10.jsp
</TITLE>
</HEAD>
<BODY>
<%@ page import = "Acme.JPM.Encoders.GifEncoder, java.io.*, java.awt.*, javax.swing.*" %>
<%
    response.setContentType("image/gif");
    OutputStream outImage = response.getOutputStream();

    // Obtain an image icon
    ImageIcon imageIcon = new ImageIcon("c:\\book\\image\\" +
      request.getParameter("country") + ".gif");

    // Obtain image from image icon
    Image image = imageIcon.getImage(); // Get the image

    // Encode the image and send to the output stream
    new GifEncoder(image, outImage, true).encode();
%>
</BODY>
</HTML>
