using Raylib_CsLo;
using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace HelloWorld;
public class MainWindow
{
    // Get Day
    public static string GetDay()
    {
        return DateTime.Now.ToString("dd");
    }
    // Get Month
    public static string GetMonth()
    {
        return DateTime.Now.ToString("MMMM");
    }
    // Get Current Day of week
    public static string GetCurrentDayofweek()
    {
        return DateTime.Now.ToString("ddd");
    }
    
    // Get Current Time
    public static string GetCurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
    }
    // Get Current Date
    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }
    public static void ToggleMode(ref bool darkMode)
    {
        darkMode = !darkMode;
    }

    public static int Main()
    {
        const int screenW = 800;
        const int screenH = 450;

        Raylib.InitWindow(screenW, screenH, "RL1");
        Raylib.SetTargetFPS(60);


        bool darkMode = false;
        Rectangle button2 = new Rectangle(400, 380, 200, 50);
        Rectangle button1 = new Rectangle(10, 380, 200, 50);
        while (!Raylib.WindowShouldClose())
        {
            if (RayGui.GuiButton(button1, "Switch Style"))
            {
                ToggleMode(ref darkMode);
            }
            Raylib.BeginDrawing();
            if (darkMode)
            {
                Raylib.ClearBackground(Raylib.BLACK);
            }
            else
            {
                Raylib.ClearBackground(Raylib.WHITE);
            }
            // Time
            string currentTime = GetCurrentTime();
            Raylib.DrawText(currentTime, 190, 100, 100, Raylib.MAGENTA);
            // Date
            string currentDate = GetCurrentDate();
            Raylib.DrawText(currentDate, 190, 300, 50, Raylib.MAGENTA);

            // Day OF WEEK
            string currentDayofweek = GetCurrentDayofweek();
            Raylib.DrawText(currentDayofweek, 190, 200, 50, Raylib.GREEN);
            // Month
            string currentMonth = GetMonth();
            Raylib.DrawText(currentMonth, 190, 250, 50, Raylib.BLUE);

            // Day
            string currentDay = GetDay();
            Raylib.DrawText(currentDay, 300, 210, 100, Raylib.BLUE);
            // Button Bar Frame
            Raylib.DrawRectangleLines(25, 375, 750, 60, Raylib.RED);
            // Color Mode Button
            RayGui.GuiButton(button1, "Switch Style");
            RayGui.GuiButton(button2, "settings");
            Raylib.EndDrawing();

        }
        Raylib.CloseWindow();
        return 0;
    }
}