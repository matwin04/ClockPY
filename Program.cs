using Raylib_CsLo;
using System;
using System.Numerics;
using System.Globalization;


namespace HelloWorld;
public class MainWindow
{
    // Get Current Time
    public static string GetCurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss",CultureInfo.InvariantCulture);
    }
    // Get Current Date
    public static string GetCurrentDate() 
    {
        return DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);    
    }
    public static int Main()
    {
        const int screenW = 800;
        const int screenH = 450;

        Raylib.InitWindow(screenW, screenH, "RL1");
        Raylib.SetTargetFPS(60);

        bool darkMode = false;
        Rectangle button1 = new Rectangle(190,350,200,50);
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib.WHITE);
            // Time
            string currentTime = GetCurrentTime();
            Raylib.DrawText(currentTime, 190, 100, 100, Raylib.MAGENTA);
            // Date
            string currentDate = GetCurrentDate();
            Raylib.DrawText(currentDate, 190, 300, 50, Raylib.BLACK);
            // Color Mode Button
            RayGui.GuiButton(button1, "Switch Style");
            
            Raylib.EndDrawing();

        }
        Raylib.CloseWindow();
        return 0;
    }
}