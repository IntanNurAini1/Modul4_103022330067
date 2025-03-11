// See https://aka.ms/new-console-template for more information
using System;
//using System.Collections.Generic;   

//public class KodeProduk
//{
//    private static Dictionary<string, string> produk = new Dictionary<string, string>
//    {
//        {"Laptop", "E100"},
//        {"Smartphone", "E101"},
//        {"Tablet", "E102"},
//        {"Headset", "E103"},
//        {"Keyboard", "E104"},
//        {"Mouse", "E105"},
//        {"Printer", "E106"},
//        {"Monitor", "E107"},
//        {"Smartwatch", "E108"},
//        {"Kamera", "E109"}
//    };

//    public static string GetKodeProduk(string namaProduk)
//    {
//        if (produk.ContainsKey(namaProduk))
//        {
//            return produk[namaProduk];
//        }
//        else
//        {
//            return "Produk tidak ditemukan";

//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Masukkan nama produk: ");
//        string namaProduk = Console.ReadLine();
//        string kodeProduk = KodeProduk.GetKodeProduk(namaProduk);
//        Console.WriteLine($"Kode untuk {namaProduk} adalah {kodeProduk}");
//    }
//}

public class FanLaptop
{
    public enum Stage { Quiet, Balanced, Performance, Turbo };
    private Stage current;
    public FanLaptop()
    {
        current = Stage.Quiet;
        Console.WriteLine("Fan laptop is in Quiet stage");
    }
    public void handle(string command)
    {
        switch (current)
        {
            case Stage.Quiet:
                if (command == "Balanced")
                {
                    current = Stage.Balanced;
                    Console.WriteLine("Fan laptop is in Balanced stage");
                }
                else if (command == "Turbo")
                {
                    current = Stage.Turbo;
                    Console.WriteLine("Fan laptop is in Turbo stage");
                }
                break;
            case Stage.Balanced:
                if (command == "Quiet")
                {
                    current = Stage.Quiet;
                    Console.WriteLine("Fan laptop is in Quiet stage");
                }
                else if (command == "Performance")
                {
                    current = Stage.Performance;
                    Console.WriteLine("Fan laptop is in Performance stage");
                }
                break;
            case Stage.Performance:
                if (command == "Balanced")
                {
                    current = Stage.Balanced;
                    Console.WriteLine("Fan laptop is in Balanced stage");
                }
                else if (command == "Turbo")
                {
                    current = Stage.Turbo;
                    Console.WriteLine("Fan laptop is in Turbo stage");
                }
                break;
            case Stage.Turbo:
                if (command == "Performance")
                {
                    current = Stage.Performance;
                    Console.WriteLine("Fan laptop is in Performance stage");
                }
                else if (command == "Quiet")
                {
                    current = Stage.Quiet;
                    Console.WriteLine("Fan laptop is in Quiet stage");
                }
                break;
        }
    }
}

public class Program
{
    public static void Main()
    {
        FanLaptop fan = new FanLaptop();
        while (true)
        {
            Console.WriteLine("Command yang tersedia: Quiet, Balanced, Performance, Turbo, exit");
            Console.Write("Masukkan command: ");
            string command = Console.ReadLine();
            if (command == "exit")
            {
                break;
            }
            fan.handle(command);
        }
    }
}