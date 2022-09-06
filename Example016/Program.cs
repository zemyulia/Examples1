using System;

namespace Example016
{
    class Program
    {
        static void Main(string[] args)
        {
            string caption = "Intensive C# Demotext";
            int screenWidthPosition = (Console.WindowWidth-caption.Length)/2;
            int screenHeightPosition = Console.WindowHeight/2;

            void DrawText(string text, int left, int top)
            {
                Console.Clear();
                Console.SetCursorPosition(left, top);
                Console.WriteLine(text);
            }

            DrawText(
                text: caption,
                left: screenWidthPosition,
                top: screenHeightPosition
            );
        }
    }
}
