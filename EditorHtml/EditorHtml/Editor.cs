﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    internal class Editor
    {
        public static void Show() 
        {
            Console.Clear();
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITOR DE TEXTO");
            Console.WriteLine("----------------");
            Console.ReadLine();
            Start();
            
            
        }
        public static void Start() 
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            Console.WriteLine("-------------------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
            
        }
    }
}
