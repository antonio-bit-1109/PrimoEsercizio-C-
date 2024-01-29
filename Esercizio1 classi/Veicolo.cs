using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1_classi
{
    // metodo più rapido per scrivere le proprietà di una classe 
    internal class Veicolo
    {
        public string targa;
        public string veicolo;
        public string cilindrata; 

        public Veicolo(string targa, string veicolo, string cilindrata)
        {
            this.targa = targa;
            this.veicolo = veicolo;
            this.cilindrata = cilindrata;
        }
    }
}
