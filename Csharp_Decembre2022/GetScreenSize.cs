using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Decembre2022
{
    public class GetScreenSize
    {
        public struct ScreenSize
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }
        public static ScreenSize GetWidthAndHeight()
        {
            ScreenSize screenSize = new ScreenSize();
            screenSize.Width = Console.WindowWidth;
            screenSize.Height = Console.WindowHeight;
            return screenSize;
        }
    }
}
