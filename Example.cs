using HUtils.Imaging;
using System;
using System.IO;
namespace HUtils.Example
{
    class Testing{
    static void Test(){
                        BMP bmp = new BMP();
                    byte[] data = bmp.GetPixels("0:\\test.bmp", false);
                    int width = bmp.width;
                    int height = bmp.height;
                    for (int x = 0; x < bmp.width; x++)
                    {
                        for (int y = 0; y < bmp.height; y++)
                        {
                            int R = data[x * width + y];
                            int G = data[x * width + y + 1];
                            int B = data[x * width + y + 2];
                            int RGB = int.Parse(R.ToString() + G.ToString() + B.ToString());
                            //You now have a RGB pixel here! You can set this in Cosmos in VGA or VBE by passing it to the c argument in SetPixel.
                        }
                    }
                    }
    }
}
