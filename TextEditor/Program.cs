﻿using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("1 - abrir um arquivo?");
            Console.WriteLine("2 - criar um arquivo?");
            Console.WriteLine("0 - Sair");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para abrir");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (Esc para sair:)");
            Console.WriteLine("----------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);

        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");

            var path = Console.ReadLine();

            // Abre e fecha o objeto. Criar arquivo e escrever nele
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"O arquivo {path} foi salvo com sucesso!");

            Menu();
        }
    }
}