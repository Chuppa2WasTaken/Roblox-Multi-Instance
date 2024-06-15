using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;


namespace MultipleRoblox
{
    internal class Program
    {

        static void Main()
        {
            Console.CursorVisible = false;
            Console.Title = ("RMI / Booting");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Roblox MultiInstance! v1.0.1\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Initializing ROBLOX_singletonMutex...");
            Thread.Sleep(1000);
            new Mutex(true, "ROBLOX_singletonMutex"); // Main Func
            Console.WriteLine("Mutex active, console clearing in 2 seconds....");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Roblox Multi-Instance is now activated!\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please do not close this window while using more than two instances. \n \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Credits | Inspired by MiningTcup, remade by Chuppa2\n \n");
            Thread.Sleep(5);
            Console.Title = ("RMI / Active");
            Thread.Sleep(-1);
        }
    }
}
