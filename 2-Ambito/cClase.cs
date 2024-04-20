using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ambito
{
    internal class cClase
    {

        //Ambito de objeto

        private int numero1 = 10;
        private string resultado;

        public string ValorNumero1()
        {

            //Declaramos variable con ambito local 
            int numero2 = 5;
           resultado =  $"El valor de número 1 es:  {this.numero1} \ny valor del número 2: {numero2}"; //this.numero1 ambito del objeto
            return resultado;
        }

     /*
        public string valorNumero2()
        {

            //Declaramos variable con ambito local 
            resultado = $"El valor de número 1 es:  {numero1} \n y valor del número 2: {numero2}"; //no se puede utilizar la variable numero dos porque no existe.
            return resultado;
        }

        */
    }
}
