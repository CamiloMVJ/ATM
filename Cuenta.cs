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
        public double Monto { get; set; }
        public int PIN { get; set; }

        public bool Retirar()
        {
            if(this.Monto <= this.Balance)
            {
                this.Balance -= this.Monto;
                return true;
            }
            return false;
        }

        public bool Depositar()
        {
            if(this.Monto > 0)
            {
                this.Balance += this.Monto;
                return true;
            }
            return false;
        }

        public bool Validar(int NumCuenta, int PIN)
        {
            if (NumCuenta == this.NumCuenta && PIN == this.PIN)
            {
                return true;
            }
            return false;
        }
    }
}
