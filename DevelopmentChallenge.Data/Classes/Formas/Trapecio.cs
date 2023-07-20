using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private decimal BaseMenor { get; set; }
        private decimal LadoIzquierdo { get; set; }
        private decimal LadoDerecho { get; set; }
        private decimal Altura { get; set; }
   
        public Trapecio(decimal ancho, decimal baseMenor, decimal ladoIzquierdo, decimal ladoDerecho, decimal altura) : base(ancho)
        {
            BaseMenor = baseMenor;
            LadoDerecho = ladoDerecho;
            LadoIzquierdo = ladoIzquierdo;
            Altura = altura;
        }

        public override decimal CalcularArea()
        {
            return (_lado + BaseMenor) * Altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado + BaseMenor + LadoIzquierdo + LadoDerecho;
        }

        public override string ObtenerNombreClaveForma()
        {
            return "TRAPECIO";
        }

        public override string ObtenerNombreClaveFormaPlural()
        {
            return "TRAPECIOS";
        }
    }
}
