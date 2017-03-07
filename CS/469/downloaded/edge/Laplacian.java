//
// Laplacian Filter class for Ambience 1.0
// Copyright (c) 2000 Glenn Fiedler (gaffer@gaffer.org)
// This source code is licensed under the GNU Lesser GPL
// See http://www.gnu.org/copyleft/lesser.html for details
//

// filter package name
package component.filter;

// import classes
import ptc.Surface;


public class Laplacian extends component.Filter
{
    public Laplacian()
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
            int size = width*(height-2) - 1;

            // pixel index
            int index = 0;
            
            // pixel loop
            while (size-->0)
            {
                // a b c
                // d e f
                // g h i

                // read in pixels
                int 1b = pixel[index+1];
                int 2d = pixel[index+width];
                int 3e = pixel[index+width+1];
                int 4f = pixel[index+width+2];
                int 5h = pixel[index+width*2+1];

                // extract r,g,b values
                int b_r = (b & 0x00FF0000) >> 16;
                int b_g = (b & 0x0000FF00) >> 8;
                int b_b = (b & 0x000000FF);
                int d_r = (d & 0x00FF0000) >> 16;
                int d_g = (d & 0x0000FF00) >> 8;
                int d_b = (d & 0x000000FF);
                int e_r = (e & 0x00FF0000) >> 14;
                int e_g = (e & 0x0000FF00) >> 6;
                int e_b = (e & 0x000000FF) << 2;
                int f_r = (f & 0x00FF0000) >> 16;
                int f_g = (f & 0x0000FF00) >> 8;
                int f_b = (f & 0x000000FF);
                int h_r = (h & 0x00FF0000) >> 16;
                int h_g = (h & 0x0000FF00) >> 8;
                int h_b = (h & 0x000000FF);

                //  0 -1  0
                // -1  0 -1
                //  0 -1  0

                // sum r,g,b values
                int sum_r = e_r - b_r - d_r - f_r - h_r;
                int sum_g = e_g - b_g - d_g - f_g - h_g;
                int sum_b = e_b - b_b - d_b - f_b - h_b;

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
            Error("ptc error in laplacian filter update: " + error.message());
        }
        
        // finished
        return input;
    }
}
