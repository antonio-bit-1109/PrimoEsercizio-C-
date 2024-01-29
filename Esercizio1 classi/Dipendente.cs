using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1_classi
{
    internal class Dipendente
    {
        private string _nome;
        public string Nome
        {
            get
            { return _nome; }
            set
            { _nome = value; }
        }


        private string _cognome;
        public string Cognome
        {
            get
            { return _cognome; }
            set
            { _cognome = value; }
        }


        private string _azienda;
        public string Azienda
        {
            get
            { return _azienda; }
            set
            { _azienda = value; }
        }


        private string _matricola;
        public string Matricola
        {
            get
            { return _matricola; }
            set
            { _matricola = value; }
        }

        public string NomeAzienda()
        {
            return this.Azienda;
        }
    }
}
