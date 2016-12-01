using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numero
    {
        #region Variables
        private double _numero;
        #endregion

        #region Constructores
        public Numero()
        {
            this._numero = 0;
        }

        public Numero(double numero)
            : this()
        {
            this._numero = numero;
        }

        public Numero(string numero)
        {
            setNumero(numero);
        }
        #endregion

        #region Métodos
        public double getNumero()
        {
            return this._numero;
        }

        

        private static double validarNumero(string a)
        {
            double num;

            if (double.TryParse(a, out num))
                return num;
            else
                return 0;
        }

        private void setNumero(string numero)
        {
            this._numero = Numero.validarNumero(numero);
        }
        #endregion
    }
}
