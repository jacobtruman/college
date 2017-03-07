/****************************************************************/
			// calculate size
			int size = width()*height();
			
			// pixel index
            int i = 0;
            
            // pixel loop
            while (size-->0)
            {
				
                // a b c
                // d e f
                // g h i

                // read in pixels
                int p1 = pixel[i+1];
                int p2 = pixel[i+width()];
                int p3 = pixel[i+width()+1];
                int p4 = pixel[i+width()+2];
                int p5 = pixel[i+width()*2+1];

					// extract r,g,b values
					Color pix1 = new Color(bPic.getRGB(x+i+1, i));
					int p1r = pix1.getRed();
					int p1g = pix1.getGreen();
					int p1b = pix1.getBlue();
					Color pix2 = new Color(bPic.getRGB(x+i, i+1));
					int p2r = pix2.getRed();
					int p2g = pix2.getGreen();
					int p2b = pix2.getBlue();
					Color pix3 = new Color(bPic.getRGB(x+i+1, i+1));
					int p3r = pix3.getRed();
					int p3g = pix3.getGreen();
					int p3b = pix3.getBlue();
					Color pix4 = new Color(bPic.getRGB(x+i+2, i+1));
					int p4r = pix4.getRed();
					int p4g = pix4.getGreen();
					int p4b = pix4.getBlue();
					Color pix5 = new Color(bPic.getRGB(x+i+1, i+2));
					int p5r = pix5.getRed();
					int p5g = pix5.getGreen();
					int p5b = pix5.getBlue();


                //  0 -1  0
                // -1  0 -1
                //  0 -1  0

                // sum r,g,b values
                int sumR = p3r - p1r - p2r - p4r - p5r;
                int sumG = p3g - p1g - p2g - p4g - p5g;
                int sumB = p3b - p1b - p2b - p4b - p5b;

                // clamp to zero
                if (sumR < 0) sumR = 0;
                if (sumG < 0) sumG = 0;
                if (sumB < 0) sumB = 0;

                // clamp to 255
                if (sumR > 255) sumR = 255;
                if (sumG > 255) sumG = 255;
                if (sumB > 255) sumB = 255;

                // repack and store
                pixel[i] = (sumR << 16) + (sumG << 8) + sumB;
					 image.setRGB(x, y, grayscale.getRGB());

                // next
                i++;
            }



/*****************************************