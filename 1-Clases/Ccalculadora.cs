using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Clases
{
    internal class Ccalculadora
    {
        //Declarar variables
        private int numero1;
        private int numero2;
        private int resultado;

        //Constructor

        public Ccalculadora(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int suma()
        {
            resultado = this.numero1 + this.numero2;
            return resultado;
        }

    }
}
