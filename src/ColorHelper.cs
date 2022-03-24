using static System.Console;

namespace Helper
{
    class ColorHelper
    {

        public static string currentColor = "null";

        public static void ColorChange()
        {
            ConsoleColor getCurrentForegroundColor = ForegroundColor;
            ConsoleColor getCurrentBackgroundColor = BackgroundColor;

            if (getCurrentBackgroundColor == ConsoleColor.Black && getCurrentForegroundColor == ConsoleColor.Magenta)
            {
                currentColor = "Magenta";
            }
        }

        public static void ColorSet()
        {
            if (currentColor == "null")
            {
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
            }

            else if (currentColor == "Magenta")
            {
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Magenta;
            }
        }

        public static void ColorReset()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
        }
    }
}
