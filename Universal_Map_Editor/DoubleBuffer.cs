using System.Drawing;
using System.IO;

namespace Universal_Map_Editor
{
    public class DoubleBuffer
    {
        private Graphics bufferedGraphics;
        private Bitmap bitmapBuffer;
        private int width;
        private int height;

        public DoubleBuffer()
		{
			width	= 0;
			height	= 0;
		}

		public void CreateBuffer(Graphics g, int width, int height)
		{
            this.width = width;
            this.height = height;
            
            bitmapBuffer = new Bitmap(width, height);
            bufferedGraphics = Graphics.FromImage(bitmapBuffer);
		}

		public void RenderToGraphics(Graphics g)
		{
            g.DrawImage(bitmapBuffer, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel);
		}

		public Graphics g
		{
			get 
			{ 
				return bufferedGraphics; 
			}
		}	
    }
}
