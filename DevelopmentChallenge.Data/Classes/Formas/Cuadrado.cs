using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal ancho) : base(ancho)
        {
        }

        public override decimal CalcularArea()
        {
            return this._lado * this._lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override string ObtenerNombreClaveForma()
        {
            return "CUADRADO";
        }

        public override string ObtenerNombreClaveFormaPlural()
        {
            return "CUADRADOS";
        }
    }
}
