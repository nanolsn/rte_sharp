﻿using System;
using RTE.Engine;

namespace RTE
{
    static class Program
    {
        private const int WIDTH = 800;
        private const int HEIGHT = 600;

        private static void Main(string[] args)
        {
            Game game = new Game(WIDTH, HEIGHT, "RTE", 2);

            string[] attributes = new string[]
            {
                "coord",
                "texCoord"
            };

            string[] uniforms = new string[]
            {
                "color",
                "pixelSize",
                "tex",
                "projection",
                "view",
                "model"
            };

            Console.WriteLine(game.VideoVersion);
            Console.WriteLine(game.GetMeshRenderer().GetDebugInfo(attributes, uniforms));
            
            game.Run(60);
        }
    }
}
