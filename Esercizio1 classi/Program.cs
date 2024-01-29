using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1_classi
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // punto d'ingresso 
            Atleta Atleta1 = new Atleta();
            Atleta1.Altezza = 210;
            Atleta1.Nome = "Usain";
            Atleta1.Cognome = "Bolt";
            Atleta1.Età = 39;

            Atleta1.WorldChampion("usain", "Bolt");


            Console.WriteLine("Nome:" + Atleta1.Nome);
            Console.WriteLine("cognome:" + Atleta1.Cognome);
            Console.WriteLine("età:" + Atleta1.Età);
            Console.WriteLine("altezza:" + Atleta1.Altezza);
            Console.WriteLine("È campione del mondo?:" + Atleta1.WorldChampion("usain" , "bolt"));


            Dipendente Worker1 = new Dipendente();
            Worker1.Nome = "GianFilippo";
            Worker1.Cognome = "Pincopallo";
            Worker1.Matricola = "0287773";
            Worker1.Azienda = "Amazon";
            Worker1.GetType(); // ritorna il tipo di worker1 
            Worker1.NomeAzienda();

            Console.WriteLine("\n"); 
            Console.WriteLine("Nome:" + Worker1.Nome);
            Console.WriteLine("Cognome:" + Worker1.Cognome);
            Console.WriteLine( "Lavora Per:" + Worker1.NomeAzienda());

            Animale Friz = new Animale();
            Friz.Nome = "Friz";
            Friz.Peso = 7.2;
            Friz.Sex = "male";
            Friz.IsMale();

            Console.WriteLine("\n");
            Console.WriteLine("Nome:" + Friz.Nome);
            Console.WriteLine("Peso:" + Friz.Peso);
            Console.WriteLine("Maschio?:" + Friz.IsMale());

            Console.WriteLine("\n");


            Veicolo Automobile4ruote = new Veicolo("23vre32" , "Mazda" , "6cilindri");
            Console.WriteLine("targa Auto: " + Automobile4ruote.targa); 




            Console.ReadLine(); 
        }
    }
}
