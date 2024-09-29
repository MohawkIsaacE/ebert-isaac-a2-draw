// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        bool isShinyArticuno = false;
        bool isShinyZapdos = false;
        bool isShinyMoltres = false;
        Color outline = Color.Black;
        Color[] articuno = [];
        Color[] shinyArticuno = [];


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Pokemon: Articuno");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            DrawBackground();
            DrawArticuno(55, 60);
        }

        /// <summary>
        ///     Draws the Articuno sprite at a given location
        /// </summary>
        public void DrawArticuno(int x, int y)
        {
            DrawOutline(x, y);

            // Draws the inside
        }

        /// <summary>
        ///     Draws the border and background
        /// </summary>
        public void DrawBackground()
        {
            Draw.LineSize = 10;
            Draw.LineColor = Color.DarkGray;
            Draw.FillColor = Color.LightGray;
            Draw.Square(0, 0, 400);
        }

        /// <summary>
        ///     Draws the outline left to right, top to bottom
        /// </summary>
        public void DrawOutline(int x, int y)
        {
            Draw.LineSize = 0;
            Draw.FillColor = outline;
            // Column 1
            Draw.Rectangle(x + 10, y + 30, 10, 40);
            // Column 2
            Draw.Rectangle(x + 20, y + 20, 10, 70);
            // Column 3
            Draw.Rectangle(x + 30, y + 20, 10, 80);
            // Column 4
            Draw.Rectangle(x + 40, y + 30, 10, 80);
            // Column 5
            Draw.Rectangle(x + 50, y + 30, 10, 100);
            Draw.Rectangle(x + 50, y + 150, 10, 30);
            // Column 6
            Draw.Rectangle(x + 60, y + 40, 10, 150);
            // Column 7
            Draw.Rectangle(x + 70, y + 50, 10, 130);
            // Column 8
            Draw.Rectangle(x + 80, y + 50, 10, 130);
            // Column 9
            Draw.Rectangle(x + 90, y + 50, 10, 130);
            // Column 10
            Draw.Rectangle(x + 100, y + 60, 10, 120);
            // Column 11
            Draw.Rectangle(x + 110, y + 70, 10, 110);
            // Column 12
            Draw.Rectangle(x + 120, y + 80, 10, 90);
            // Column 13 & 14
            Draw.Rectangle(x + 130, y + 80, 20, 80);
            // Column 15
            Draw.Rectangle(x + 150, y + 80, 10, 90);
            // Column 16
            Draw.Rectangle(x + 160, y + 60, 10, 120);
            // Column 17
            Draw.Rectangle(x + 170, y + 50, 10, 130);
            // Column 18
            Draw.Rectangle(x + 180, y + 50, 10, 40);
            Draw.Rectangle(x + 180, y + 100, 10, 90);
            // Column 19
            Draw.Rectangle(x + 190, y + 40, 10, 50);
            Draw.Rectangle(x + 190, y + 120, 10, 70);
            // Column 20
            Draw.Rectangle(x + 200, y + 40, 10, 50);
            Draw.Rectangle(x + 200, y + 120, 10, 70);
            // Column 21
            Draw.Rectangle(x + 210, y + 40, 10, 50);
            Draw.Rectangle(x + 210, y + 130, 10, 70);
            // Column 22
            Draw.Rectangle(x + 220, y + 20, 10, 70);
            Draw.Rectangle(x + 220, y + 130, 10, 70);
            // Column 23
            Draw.Rectangle(x + 230, y + 10, 10, 70);
            Draw.Rectangle(x + 230, y + 140, 10, 60);
            // Column 24
            Draw.Rectangle(x + 240, y, 10, 80);
            Draw.Rectangle(x + 240, y + 150, 10, 50);
            // Column 25
            Draw.Rectangle(x + 250, y, 10, 70);
            Draw.Rectangle(x + 250, y + 170, 10, 30);
            // Column 26
            Draw.Rectangle(x + 260, y, 10, 40);
            Draw.Rectangle(x + 260, y + 170, 10, 30);
            // Column 27
            Draw.Rectangle(x + 270, y + 10, 10, 10);
            Draw.Rectangle(x + 270, y + 180, 10, 10);
        }
    }
}
