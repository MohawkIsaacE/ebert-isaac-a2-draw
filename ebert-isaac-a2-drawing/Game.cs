﻿// Include code libraries you need below (use the namespace).
using System;
using System.Linq;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        bool isRandomColours = false;
        Color[] randomColours = new Color[8];
        Color borderColour = Color.DarkGray;
        Color backgroundColour = new Color(212, 138, 114);
        Color outlineColour = Color.Black;
        Color fillColour = new Color(90, 207, 251);
        Color pupilColour = new Color(210, 70, 97);
        Color irisColour = Color.White;
        Color beakColour = new Color(157, 196, 225);
        Color detailColour = new Color(11, 85, 208);
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Articuno Sprite");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Variables
            Color[] articunoColours = 
                [
                borderColour, 
                backgroundColour, 
                outlineColour, 
                fillColour, 
                pupilColour, 
                irisColour, 
                beakColour, 
                detailColour,
                ];

            Window.ClearBackground(Color.OffWhite);

            // Change which sprite to draw based on user input
            if (Input.IsMouseButtonPressed(MouseInput.Right))
            {
                isRandomColours = false;
            }
            else if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                for (int i = 0; i < randomColours.Length; i++)
                {
                    randomColours[i] = Random.Color();
                }
                isRandomColours = true;
            }

            // Determine which sprite to draw
            if (isRandomColours)
            {
                DrawArticuno(55, 60, randomColours);
            }
            else
            {
                DrawArticuno(55, 60, articunoColours);
            }
        }

        /// <summary>
        ///     Draws the Articuno sprite at a given location
        /// </summary>
        public void DrawArticuno(int x, int y, Color[] colours)
        {
            DrawBackground(colours[0], colours[1]);
            DrawOutline(x, y, colours[2]);
            DrawInside(x, y, colours[3]);
            DrawText(x - 20, y + 220, colours[3], colours[1]);
            DrawDetails(x, y, colours[4], colours[5], colours[6], colours[7]);
        }

        /// <summary>
        ///     Draws the border and background
        /// </summary>
        public void DrawBackground(Color line, Color fill)
        {
            Draw.LineSize = 10;
            Draw.LineColor = line;
            Draw.FillColor = fill;
            Draw.Square(0, 0, 400);
        }

        /// <summary>
        ///     Draws the outline left to right, top to bottom
        /// </summary>
        public void DrawOutline(int x, int y, Color outlineColour)
        {
            Draw.LineSize = 0;
            Draw.FillColor = outlineColour;
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

        /// <summary>
        ///     Draws the inside colour of the sprite
        /// </summary>
        public void DrawInside(int x, int y, Color fill)
        {
            Draw.LineSize = 0;
            Draw.FillColor = fill;
            // Column 1 (none)
            // Column 2
            Draw.Rectangle(x + 20, y + 30, 10, 40);
            // Column 3
            Draw.Rectangle(x + 30, y + 30, 10, 10);
            Draw.Rectangle(x + 30, y + 50, 10, 40);
            // Column 4
            Draw.Rectangle(x + 40, y + 40, 10, 60);
            // Column 5
            Draw.Rectangle(x + 50, y + 40, 10, 10);
            Draw.Rectangle(x + 50, y + 60, 10, 20);
            // Column 6
            Draw.Rectangle(x + 60, y + 50, 10, 30);
            Draw.Rectangle(x + 60, y + 90, 10, 20);
            // Column 7
            Draw.Rectangle(x + 70, y + 60, 10, 30);
            Draw.Rectangle(x + 70, y + 110, 10, 20);
            // Column 8
            Draw.Rectangle(x + 80, y + 60, 10, 20);
            Draw.Rectangle(x + 80, y + 90, 10, 30);
            Draw.Rectangle(x + 80, y + 130, 10, 10);
            Draw.Rectangle(x + 80, y + 150, 10, 20);
            // Column 9
            Draw.Rectangle(x + 90, y + 60, 10, 10);
            Draw.Rectangle(x + 90, y + 80, 10, 30);
            Draw.Rectangle(x + 90, y + 120, 10, 20);
            Draw.Rectangle(x + 90, y + 160, 10, 10);
            // Column 10
            Draw.Rectangle(x + 100, y + 110, 10, 20);
            Draw.Rectangle(x + 100, y + 160, 10, 10);
            // Column 11
            Draw.Rectangle(x + 110, y + 80, 10, 20);
            Draw.Rectangle(x + 110, y + 110, 10, 10);
            Draw.Rectangle(x + 110, y + 130, 10, 40);
            // Column 12
            Draw.Rectangle(x + 120, y + 90, 10, 10);
            Draw.Rectangle(x + 120, y + 120, 10, 40);
            // Column 13
            Draw.Rectangle(x + 130, y + 90, 10, 50);
            // Column 14
            Draw.Rectangle(x + 140, y + 90, 10, 60);
            // Column 15
            Draw.Rectangle(x + 150, y + 90, 10, 70);
            // Column 16
            Draw.Rectangle(x + 160, y + 80, 10, 10);
            Draw.Rectangle(x + 160, y + 100, 10, 20);
            Draw.Rectangle(x + 160, y + 130, 10, 40);
            // Column 17
            Draw.Rectangle(x + 170, y + 60, 10, 30);
            Draw.Rectangle(x + 170, y + 100, 10, 10);
            Draw.Rectangle(x + 170, y + 120, 10, 50);
            // Column 18
            Draw.Rectangle(x + 180, y + 60, 10, 20);
            Draw.Rectangle(x + 180, y + 120, 10, 10);
            Draw.Rectangle(x + 180, y + 140, 10, 40);
            // Column 19
            Draw.Rectangle(x + 190, y + 50, 10, 30);
            Draw.Rectangle(x + 190, y + 140, 10, 40);
            // Column 20
            Draw.Rectangle(x + 200, y + 50, 10, 30);
            Draw.Rectangle(x + 200, y + 130, 10, 20);
            Draw.Rectangle(x + 200, y + 160, 10, 20);
            // Column 21
            Draw.Rectangle(x + 210, y + 50, 10, 30);
            Draw.Rectangle(x + 210, y + 140, 10, 10);
            Draw.Rectangle(x + 210, y + 160, 10, 30);
            // Column 22
            Draw.Rectangle(x + 220, y + 40, 10, 40);
            Draw.Rectangle(x + 220, y + 150, 10, 20);
            Draw.Rectangle(x + 220, y + 180, 10, 10);
            // Column 23
            Draw.Rectangle(x + 230, y + 20, 10, 50);
            Draw.Rectangle(x + 230, y + 150, 10, 20);
            Draw.Rectangle(x + 230, y + 180, 10, 10);
            // Column 24
            Draw.Rectangle(x + 240, y + 10, 10, 60);
            Draw.Rectangle(x + 240, y + 180, 10, 10);
            // Column 25
            Draw.Rectangle(x + 250, y + 10, 10, 30);
            Draw.Rectangle(x + 250, y + 180, 10, 10);
            // Column 26
            Draw.Rectangle(x + 260, y + 10, 10, 10);
            Draw.Rectangle(x + 260, y + 180, 10, 10);
            // Column 27 (none)
        }

        /// <summary>
        ///     Draws the details of the sprite (eye, beak, dark blue spots)
        /// </summary>
        public void DrawDetails(int x, int y, Color pupil, Color iris, Color beak, Color darkSpots)
        {
            // eye
            Draw.FillColor = pupil;
            Draw.Square(x + 90, y + 150, 10);

            Draw.FillColor = iris;
            Draw.Rectangle(x + 100, y + 140, 10, 20);

            // beak
            Draw.Square(x + 60, y + 170, 10);
            Draw.FillColor = beak;
            Draw.Square(x + 60, y + 150, 20);

            // dark spots
            Draw.FillColor = darkSpots;
            // Column 3
            Draw.Square(x + 30, y + 80, 10);
            // Column 4
            Draw.Square(x + 40, y + 60, 10);
            Draw.Square(x + 40, y + 90, 10);
            // Column 7
            Draw.Square(x + 70, y + 80, 10);
            Draw.Rectangle(x + 70, y + 110, 10, 20);
            // Column 8
            Draw.Square(x + 80, y + 130, 10);
            Draw.Rectangle(x + 80, y + 150, 10, 20);
            // Column 9
            Draw.Square(x + 90, y + 130, 10);
            Draw.Square(x + 90, y + 160, 10);
            // Column 10
            Draw.Square(x + 100, y + 160, 10);
            // Column 11
            Draw.Square(x + 110, y + 80, 10);
            Draw.Square(x + 110, y + 160, 10);
            // Column 15
            Draw.Square(x + 150, y + 120, 10);
            // Column 16
            Draw.Square(x + 160, y + 80, 10);
            Draw.Square(x + 160, y + 160, 10);
            // Column 17
            Draw.Square(x + 170, y + 60, 10);
            Draw.Square(x + 170, y + 80, 10);
            // Column 18
            Draw.Square(x + 180, y + 70, 10);
            Draw.Square(x + 180, y + 170, 10);
            // Column 19
            Draw.Square(x + 190, y + 50, 10);
            Draw.Square(x + 190, y + 70, 10);
            // Column 20
            Draw.Rectangle(x + 200, y + 50, 10, 20);
            // Column 22
            Draw.Square(x + 220, y + 60, 10);
            // Column 23
            Draw.Square(x + 230, y + 20, 10);
            Draw.Square(x + 230, y + 50, 10);
            // Column 24
            Draw.Square(x + 240, y + 20, 10);
            Draw.Square(x + 240, y + 40, 10);
            Draw.Square(x + 240, y + 60, 10);
            // Column 25
            Draw.Square(x + 250, y + 10, 10);
        }

        /// <summary>
        ///     Draws the text "CLICK" in big letters at a given location
        /// </summary>
        public void DrawText(int x, int y, Color positiveColour, Color negativeColour)
        {
            // C - Big ellipse, negative small circle, negative big rectangle
            Draw.FillColor = positiveColour;
            Draw.Circle(x + 40, y + 40, 40);
            Draw.FillColor = negativeColour;
            Draw.Circle(x + 40, y + 40, 20);
            Draw.Rectangle(x + 40, y, 40, 80);

            // L - Two big rectangles
            Draw.FillColor = positiveColour;
            Draw.Rectangle(x + 60, y, 20, 80);
            Draw.Square(x + 80, y + 60, 20);

            // I - Three big rectangles
            Draw.FillColor = positiveColour;
            int offset = 0;
            for (int i = 0; i < 2; i++)
            {
                Draw.Rectangle(x + 120, y + offset, 60, 20);
                offset += 60;
            }
            Draw.Rectangle(x + 140, y, 20, 80);

            // C - Big ellipse, negative small circle, negative big rectangle
            Draw.FillColor = positiveColour;
            Draw.Circle(x + 240, y + 40, 40);
            Draw.FillColor = negativeColour;
            Draw.Circle(x + 240, y + 40, 20);
            Draw.Rectangle(x + 240, y, 40, 80);

            // K - Big rectangle, three negative triangles
            Draw.FillColor = positiveColour;
            Draw.Rectangle(x + 260, y, 60, 80);
            Draw.FillColor = negativeColour;
            Draw.Triangle(x + 280, y, x + 280, y + 30, x + 320, y);
            Draw.Triangle(x + 280, y + 50, x + 280, y + 80, x + 320, y + 80);
            Draw.Triangle(x + 300, y + 40, x + 320, y + 20, x + 320, y + 60);

        }
    }
}
