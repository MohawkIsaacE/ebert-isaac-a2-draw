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
            DrawArticuno(outline);
        }

        /// <summary>
        ///     Draws the Articuno sprite at a given location
        /// </summary>
        public void DrawArticuno(Color outlineColour)
        {
            // Draws the outline left to right, top to bottom
            Draw.LineSize = 0;
            Draw.FillColor = outlineColour;
            Draw.Square(10, 10, 10);

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
    }
}
