using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1_classi
{
    internal class Animale
    {
        private string _nome;
        public string Nome
        {
            get
            { return _nome; }
            set
            { _nome = value; }
        }

        private string _sex;
        public string Sex
        {
            get
            { return _sex; }
            set
            { _sex = value; }
        }

        private double _peso;
        public double Peso
        {
            get
            { return _peso; }
            set
            { _peso = value; }
        }

        public bool IsMale()
        {
            if (this.Sex.ToLower() == "male")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
