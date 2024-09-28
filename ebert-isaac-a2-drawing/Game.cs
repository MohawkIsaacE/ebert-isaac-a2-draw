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
        Color[] background = [Color.Blue, Color.Yellow, Color.Red, Color.Green];
        Color outline = Color.Black;
        Color[] articuno = [];
        Color[] shinyArticuno = [];
        Color[] zapdos = [];
        Color[] shinyZapdos = [];
        Color[] moltres = [];
        Color[] shinyMoltres = [];


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Pokemon Sprites");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            DrawArticuno(0, 0);
            DrawZapdos(200, 0);
            DrawMoltres(0, 200);
            drawText(200, 200);
        }

        /// <summary>
        ///     Draws the Articuno sprite at a given location
        /// </summary>
        public void DrawArticuno(int x, int y)
        {
            DrawQuadrant(x, y, background[0]);

        }

        /// <summary>
        ///     Draws the Zapdos sprite at a given location
        /// </summary>
        public void DrawZapdos(int x, int y)
        {
            DrawQuadrant(x, y, background[1]);
        }

        /// <summary>
        ///     Draws the Moltres sprite at a given location
        /// </summary>
        public void DrawMoltres(int x, int y)
        {
            DrawQuadrant(x, y, background[2]);
        }

        /// <summary>
        ///     Draws text at a given location
        ///     The text says "Click"
        /// </summary>
        public void drawText(int x, int y)
        {
            DrawQuadrant(x, y, background[3]);
        }

        /// <summary>
        ///     Draws the borders and background for the quadrant with a given colour
        /// </summary>
        public void DrawQuadrant(int x, int y, Color backgroundColor)
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.DarkGray;
            Draw.FillColor = backgroundColor;
            Draw.Square(x, y, 200);
        }
    }
}
