using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        protected readonly decimal _lado;

        public FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        public abstract string ObtenerNombreClaveForma();
        public abstract string ObtenerNombreClaveFormaPlural();
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

    }
}
