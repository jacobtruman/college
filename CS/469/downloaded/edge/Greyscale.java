//
// Greyscale Filter class for Ambience 1.0
// Copyright (c) 2000 Glenn Fiedler (gaffer@gaffer.org)
// This source code is licensed under the GNU Lesser GPL
// See http://www.gnu.org/copyleft/lesser.html for details
//

// filter package name
package component.filter;

// import classes
import ptc.Surface;


public class Greyscale extends component.Filter
{
    public Greyscale()
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

            // calculate size
            int size = width*height;

            // pixel index
            int index = 0;
        
            // lock input surface
            int[] pixel = (int[]) input.lock();

            // pixel loop
            while (size-->0)
            {
                // read pixel color
                int color = pixel[index];

                // convert to greyscale
                int r = (color & 0x00FF0000) >> (16+1);
                int g = (color & 0x0000FF00) >> (8+2);
                int b = (color & 0x000000FF) >> (2);

                // sum colors to grey
                int sum = r + g + b;

                // pack and store
                pixel[index] = (sum<<16) | (sum<<8) | sum;

                // next
                index++;
            }

            // unlock surface
            input.unlock();
        }
        catch (ptc.Error error)
        {
            Error("ptc error in greyscale filter update: " + error.message());
        }
            
        // finished
        return input;
    }
}
