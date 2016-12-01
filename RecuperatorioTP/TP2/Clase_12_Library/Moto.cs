using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Clase_12_Library_2
{
   public class Moto:Vehiculo
    {


        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente, color)
        {
 
        }
        
        
        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
       public override short CantidadRuedas
        {
            get
            {
                return 2;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("RUEDAS  " + this.CantidadRuedas);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
