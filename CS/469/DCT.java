import java.awt.*;
import java.applet.*;
import java.awt.image.*;

public class DCT extends Applet{
    Image img;
    Image Dimg;
    int w,h;
    
    public void init(){
	img = getImage(getDocumentBase(),"lena2.jpg");
	MediaTracker mt = new MediaTracker(this); 
	mt.addImage(img,0);

	try{
            mt.waitForAll();
	}catch(Exception e){;}
	 
        Dimg = DctImage(img);
    }
    
    public Image DctImage(Image im){
	w = im.getWidth(this);
	h = im.getHeight(this);
        int[] pixels = new int[w * h];
           
	PixelGrabber pg = new PixelGrabber(im,0,0,w,h,pixels,0,w);

	try{
            pg.grabPixels();
	}catch(InterruptedException e){;}

	int[] R = new int[w*h];
	for(int i = 0;i<w*h;i++){
            try{
                R[i] = pixels[i] & 0x00ff0000;
            }catch(Exception ex){;}
        }
		
	double[][] Th = new double[h][h];
	for(int i = 0;i<h;i++) Th[0][i] = Math.sqrt(1.0/((double)h));
	for(int i = 1;i<h;i++){
            for(int j = 0;j<h;j++)
		Th[i][j] = Math.sqrt(2.0/((double)h))*Math.cos( ((double)i)*((double)(j+0.5)) /((double)h)*Math.PI);
	}
		
	double [][] Tw = new double[w][w];
	for(int i = 0;i<w;i++) Tw[0][i] = Math.sqrt(1.0/((double)w));		
        for(int i = 1;i<w;i++){
            for(int j = 0;j<w;j++)
		Tw[i][j] = Math.sqrt(2.0/((double)w))*Math.cos((double)((i)*(j+0.5)/w)*Math.PI);
	}
		
	double [] WR1 = new double [w*h];
	double [] WR2 = new double [w*h];
	for(int i = 0;i<w*h;i++){
            WR1[i] = 0.0;
            WR2[i] = 0.0;
	}
		
        for(int i = 0;i<h;i++){
            for(int j = 0;j<w;j++){
                for(int k = 0;k<h;k++)
                    WR1[i*w + j] = WR1[i*w + j] + Th[i][k]*R[k*w + j];
            }
        }

	for(int i = 0;i<h;i++){
            for(int j = 0;j<w;j++){
                for(int k =0;k<w;k++)
                    WR2[i*w + j] = WR2[i*w + j] + WR1[i*w + k]*Tw[j][k];
            }
        }
		
        for(int i = 0;i<w*h;i++) WR1[i] = 0.0;

	for(int i = 0;i<h;i++){
            for(int j = 0;j<w;j++){
                for(int k = 0;k<h;k++)
                    WR1[i*w + j] = WR1[i*w+j] + (int)(Th[k][i]*WR2[k*w + j]);
            }
	}
        
        for(int i = 0;i<w*h;i++){
            R[i] = 0;
	}
		
	for(int i = 0;i<h;i++){
            for(int j = 0;j<w;j++){
                for(int k =0;k<w;k++)
                    R[i*w + j] = R[i*w + j] + (int)(WR1[i*w + k] * Tw[k][j]);
            }
	}
		
	for(int i= 0;i<w*h;i++) pixels[i] = 0x00ff0000 & R[i] | 0xff000000;
        
	MemoryImageSource mis = new MemoryImageSource(w,h,pixels,0,w);
	Toolkit tk = Toolkit.getDefaultToolkit();

	return tk.createImage(mis);
    }
    
    public void paint(Graphics g){
        g.drawImage(img,0,0,this);
	g.drawImage(Dimg,w+10,0,this);
    }
}