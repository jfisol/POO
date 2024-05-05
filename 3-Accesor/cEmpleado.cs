using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Accesor
{
    internal class cEmpleado
    {
        private double sueldo;
        private double impuesto;
        


        public void Muestra()
        {
            Console.WriteLine($"Sueldo = {sueldo} impuesto = {impuesto} ");
        }

        //Accesor get y set

        public void set_sueldo( double sueldo )
        {
            this.sueldo = sueldo;
        }
        public double get_sueldo()
        {
            return this.sueldo;
        }

        public void set_impuesto( double impuesto ) 
        {
           this.impuesto = impuesto;
        }

        public double get_impuesto()
        {
            return this.impuesto;
        }

        public void calcularImpuesto()
        {
            impuesto = this.sueldo * 0.16;
        }

    }
}
