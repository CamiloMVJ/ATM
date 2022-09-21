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
        public double Monto { get; set; }

        public String Retirar()
        {
            ValidarNum();
            if (Cuenta.Retirar(this.Monto))
            {
                this.Balance -= Monto;
                return "Retiro exitoso!";
            }
            return "";
        }
        public String Depositar()
        {
            if (this.Cuenta.Depositar(this.Monto))
            {
                this.Balance += Monto;
                return "Deposito con exito";
            }
            return "";
        }

        public void ValidarNum()
        {
            if (this.Monto < 0)
                this.Monto = this.Monto * -1;
        }
    }
}
