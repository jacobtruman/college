//
// Roberts Filter class for Ambience 1.0
// Copyright (c) 2000 Glenn Fiedler (gaffer@gaffer.org)
// This source code is licensed under the GNU Lesser GPL
// See http://www.gnu.org/copyleft/lesser.html for details
//

// filter package name
package component.filter;

// import classes
import ptc.Surface;


public class Roberts extends component.Filter
{
    public Roberts()
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
            int size = width*(height-1) - 1;

            // pixel index
            int index = 0;
            
            // pixel loop
            while (size-->0)
            {
                // a 0
                // 0 b
                    
                // read in pixels
                int a = pixel[index];
                int b = pixel[index+width+1];

                // extract r,g,b values
                int a_r = (a & 0x00FF0000) >> 16;
                int a_g = (a & 0x0000FF00) >> 8;
                int a_b = (a & 0x000000FF);
                int b_r = (b & 0x00FF0000) >> 16;
                int b_g = (b & 0x0000FF00) >> 8;
                int b_b = (b & 0x000000FF);
                    
                // 1  0
                // 0 -1

                // sum r,g,b values
                int sum_r = a_r - b_r;
                int sum_g = a_g - b_g;
                int sum_b = a_b - b_b;

                // clamp summed values
                if (sum_r<0) sum_r = 0;
                if (sum_g<0) sum_g = 0;
                if (sum_b<0) sum_b = 0;

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
            Error("ptc error in roberts filter update: " + error.message());
        }
        
        // finished
        return input;
    }
}
