//
// Horizontal Flip Filter class for Ambience 1.0
// Copyright (c) 2000 Glenn Fiedler (gaffer@gaffer.org)
// This source code is licensed under the GNU Lesser GPL
// See http://www.gnu.org/copyleft/lesser.html for details
//

// filter package name
package component.filter;

// import classes
import ptc.Surface;


public class HorizontalFlip extends component.Filter
{
    public HorizontalFlip()
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

            // lock surfaces
            int[] src = (int[]) input.lock();
            int[] dst = (int[]) output.lock();

            // pixel index
            int index = 0;

            // vertical loop
            for (int y=0; y<height; y++)
            {
                // copy horizontal line in reverse order
                for (int x=0; x<width; x++) dst[index+width-x-1] = src[index+x];
                
                // next line
                index += width;
            }

            // unlock surfaces
            input.unlock();
            output.unlock();
        }
        catch (ptc.Error error)
        {
            Error("ptc error in horizontal flip filter update: " + error.message());
        }

        // finished
        return output;
    }
}
