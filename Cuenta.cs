using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjATM
{
    public class Cuenta
    {
        public String? Nombre { get; set; }
        public int NumCuenta { get; set; }
        public double Balance { get; set; }
        public int PIN { get; set; }

        public bool Retirar(double monto)
        {
            if (monto <= this.Balance)
            {
                this.Balance -= monto;
                return true;
            }
            return false;
        }

        public bool Depositar(double monto)
        {
            if (monto > 0)
            {
                this.Balance += monto;
                return true;
            }
            return false;
        }

        public bool Validar(int NumCuenta, int PIN, String nombre)
        {
            if (NumCuenta == this.NumCuenta && PIN == this.PIN && nombre == this.Nombre)
            {
                return true;
            }
            return false;
        }

        
    }
}
