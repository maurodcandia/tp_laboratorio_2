﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12_Library_2;

namespace Clase_12_Library
{
    public class Camion:Vehiculo
    {
        public Camion(EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente, color)
        {
        }
        /// <summary>
        /// Los camiones tienen 8 ruedas
        /// </summary>
       public override short CantidadRuedas
        {
            get
            {
                return 8;
            }
        }

       public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("RUEDAS  " +  this.CantidadRuedas);          
            sb.AppendLine("---------------------");

            return sb.ToString();
;
        }
    }
}
