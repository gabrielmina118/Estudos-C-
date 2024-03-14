using System;
using System.Threading;

namespace fundamentos;

class Program {
    static void Main(string [] args){
        Menu();
    }

    static void Menu(){
        Console.WriteLine("S = segundos");
        Console.WriteLine("0 - sair");        
        Console.WriteLine("Quanto tempo deseja contar?");        

        string dado = Console.ReadLine().ToLower();
        char typeData = char.Parse(dado.Substring(dado.Length - 1, 1));
        int time = int.Parse(dado.Substring(0 ,dado.Length - 1));

        if(time == 0)
            System.Environment.Exit(0);

        PreStart(time);
    }

    static void PreStart(int time){
        Console.Clear();
        Console.WriteLine("Preprarando....");
        Thread.Sleep(1000);
        Console.WriteLine("Começar!");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time){        
        int currentTime = 0;

        while(currentTime != time){
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Programa finalizado!!");
        
        Thread.Sleep(2500);
    }
}