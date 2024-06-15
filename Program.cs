// Main C# Src Code
// Enjoy, I guess!

using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Roblox Multi-Instance!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Activating ROBLOX_singletonMutex...");
            new Mutex(true, "ROBLOX_singletonMutex"); // THIS DOES THE STUFF, THIS MAKES ANTIVIRUS VERY ANGRY 😭
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("If you are seeing this then this script worked!");
            Console.Write("OG Script by MiningTcup, edited by Chuppa2\n \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Roblox Multi-Instance is now activated!\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please do not close this window while using more than two instances.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(-1);
        }
    }
}
