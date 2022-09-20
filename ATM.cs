using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjATM
{
    public class ATM
    {
        public double Balance { get; set; }
        public Cuenta Cuenta { get; set; }

        public String Retirar()
        {
            if (this.Cuenta.Retirar())
            {
                this.Balance -= this.Cuenta.Monto;
                return "Retiro exitoso!";
            }
            return "";
        }
        public String Depositar()
        {
            if (this.Cuenta.Depositar())
            {
                this.Balance += this.Cuenta.Monto;
                return "Deposito con exito";
            }
            return "";
        }
    }
}
