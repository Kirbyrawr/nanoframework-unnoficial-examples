using System.Drawing;
using nanoFramework.UI;

public class DrawImage()
{
    // This class is just a placeholder for the gif data.
    // If you want to know how to generate the byte array from a gif, 
    // please check the GifToByteArray.cs file in the examples folder.
    public class GifImage
    {
        public static byte[] Data { get; }
    }

    public void Demo()
    {
        //Get the screen bitmap
        var screenBitmap = DisplayControl.FullScreen;

        //Create a new bitmap from gif data. 
        var bitmap = new Bitmap(GifImage.Data, Bitmap.BitmapImageType.Gif);

        //Draw the bitmap we created using the screen dimensions.
        screenBitmap.DrawImage(0, 0, bitmap, 0, 0, screenBitmap.Width, screenBitmap.Height);

        //Flush the bitmap to the screen.
        screenBitmap.Flush();

        //Dispose the bitmap so we don't leak memory.
        bitmap.Dispose();
    }
}

