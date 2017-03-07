//
// Sobel Filter class for Ambience 1.0
// Copyright (c) 2000 Glenn Fiedler (gaffer@gaffer.org)
// This source code is licensed under the GNU Lesser GPL
// See http://www.gnu.org/copyleft/lesser.html for details
//

// filter package name
package component.filter;

// import classes
import ptc.Surface;


public class Sobel extends component.Filter
{
    public Sobel()
    {
        // defaults
    }
    
    public Surface Update(Surface input,Surface output)
    {
        try
        {
            // get surface information
            int width  = input.width();
            int height = input.height();

            // lock input surface
            int[] pixel = (int[]) input.lock();

            // calculate size
            int size = width*(height-2) - 2;

            // pixel index
            int index = 0;
            
            // pixel loop
            while (size-->0)
            {
                // a b c
                // d e f
                // g h i

                // read in pixels
                int a = pixel[index];
                int b = pixel[index+1];
                int c = pixel[index+2];
                int g = pixel[index+width*2];
                int h = pixel[index+width*2+1];
                int i = pixel[index+width*2+2];

                // extract r,g,b values
                int a_r = (a & 0x00FF0000) >> 16;
                int a_g = (a & 0x0000FF00) >> 8;
                int a_b = (a & 0x000000FF);
                int b_r = (b & 0x00FF0000) >> 15;
                int b_g = (b & 0x0000FF00) >> 7;
                int b_b = (b & 0x000000FF) << 1;
                int c_r = (c & 0x00FF0000) >> 16;
                int c_g = (c & 0x0000FF00) >> 8;
                int c_b = (c & 0x000000FF);
                int g_r = (g & 0x00FF0000) >> 16;
                int g_g = (g & 0x0000FF00) >> 8;
                int g_b = (g & 0x000000FF);
                int h_r = (h & 0x00FF0000) >> 15;
                int h_g = (h & 0x0000FF00) >> 7;
                int h_b = (h & 0x000000FF) << 1;
                int i_r = (i & 0x00FF0000) >> 16;
                int i_g = (i & 0x0000FF00) >> 8;
                int i_b = (i & 0x000000FF);

                // -1 -1 -1
                //  0  0  0
                //  1  1  1

                // sum r,g,b values
                int sum_r = - a_r - b_r - c_r + g_r + h_r + i_r;
                int sum_g = - a_g - b_g - c_g + g_g + h_g + i_g;
                int sum_b = - a_b - b_b - c_b + g_b + h_b + i_b;

                // clamp to zero
                if (sum_r<0) sum_r = 0;
                if (sum_g<0) sum_g = 0;
                if (sum_b<0) sum_b = 0;

                // clamp to 255
                if (sum_r>255) sum_r = 255;
                if (sum_g>255) sum_g = 255;
                if (sum_b>255) sum_b = 255;

                // repack and store
                pixel[index] = (sum_r<<16) + (sum_g<<8) + sum_b;

                // next
                index++;
            }
            
            // unlock surface
            input.unlock();
        }
        catch (ptc.Error error)
        {
            Error("ptc error in sobel filter update: " + error.message());
        }
        
        // finished
        return input;
    }
}
