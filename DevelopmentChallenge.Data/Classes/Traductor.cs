using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Traductor
    {
        private Dictionary<string, Dictionary<int, string>> _traducciones = new Dictionary<string, Dictionary<int, string>>();

        public Traductor()
        {
        }

        public void AgregarTraduccion(string clave, int idioma, string traduccion)
        {
            if (!_traducciones.ContainsKey(clave))
            {
                _traducciones[clave] = new Dictionary<int, string>();
            }

            _traducciones[clave][idioma] = traduccion;
        }

        public string Traducir(string clave, int idioma)
        {
            if (_traducciones.ContainsKey(clave) && _traducciones[clave].ContainsKey(idioma))
            {
                return _traducciones[clave][idioma];
            }

            return "Traducción no disponible";
        }
    }

    public enum Idioma
    {
        Castellano = 1,
        Ingles = 2,
        Italiano = 3
    }
}
