// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;   

public class KodeProduk
{
    private static Dictionary<string, string> produk = new Dictionary<string, string>
    {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor", "E107"},
        {"Smartwatch", "E108"},
        {"Kamera", "E109"}
    };

    public static string GetKodeProduk(string namaProduk)
    {
        if (produk.ContainsKey(namaProduk))
        {
            return produk[namaProduk];
        }
        else
        {
            return "Produk tidak ditemukan";

        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Masukkan nama produk: ");
        string namaProduk = Console.ReadLine();
        string kodeProduk = KodeProduk.GetKodeProduk(namaProduk);
        Console.WriteLine($"Kode untuk {namaProduk} adalah {kodeProduk}");
    }
}
