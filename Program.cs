using System.Drawing;

namespace GDIAlphaBlendRepro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bg = new Bitmap(Image.FromFile("background.png"));

            var g = Graphics.FromImage(bg);
            g.DrawImage(new Bitmap(Image.FromFile("layer.png")), 304, 312);

            bg.Save("result.png");
        }
    }
}
