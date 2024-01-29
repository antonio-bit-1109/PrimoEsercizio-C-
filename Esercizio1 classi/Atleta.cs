using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1_classi
{
    public class Atleta
    {
        private string _nome; 
        public string Nome { 
            get
            { return _nome; } 
            set
            { _nome = value; } }


        private string _cognome;
        public string Cognome
        {
            get
            { return _cognome; }
            set
            { _cognome = value; }
        }


        private int _età;
        public int Età
        {
            get
            { return _età; }
            set
            { _età = value; }
        }

        private int _altezza; 
        public int Altezza 
        {
            get
            { return _altezza; }
            set
            { _età = value; }
        }


        public bool WorldChampion(string nome, string cognome)
        {
            if ((nome == "Usain" || nome == "usain") && (cognome == "Bolt" || cognome == "bolt"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
