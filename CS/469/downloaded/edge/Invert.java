//
// Invert Filter class for Ambience 1.0
// Copyright (c) 2000 Glenn Fiedler (gaffer@gaffer.org)
// This source code is licensed under the GNU Lesser GPL
// See http://www.gnu.org/copyleft/lesser.html for details
//

// filter package name
package component.filter;

// import classes
import ptc.Surface;


public class Invert extends component.Filter
{
    public Invert()
    {
        // register inputs
        invert = RegisterInput("Invert");
        
        // set input defaults
        invert.SetBoolean(true);
    }
    
    public Surface Update(Surface input,Surface output)
    {
        try
        {
            // get invert boolean from input data
            boolean invert = this.invert.GetBoolean();
        
            // check invert
            if (!invert)
            {
                // pass through
                return input;
            }

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
                // invert current pixel
                pixel[index] = ~pixel[index];
                
                // next
                index++;
            }

            // unlock surface
            input.unlock();
        }
        catch (ptc.Error error)
        {
            Error("ptc error in invert filter update: " + error.message());
        }

        // finished
        return input;
    }
    
    // input data
    ambience.Data invert;
}
