using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Criando um objeto Iphone
            Iphone iphone = new Iphone("987654321", "Iphone 13", "987654321098765", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
