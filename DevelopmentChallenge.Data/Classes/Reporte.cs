using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Reporte
    {
        public Traductor _traductor;
        public Reporte(Traductor traductor)
        {
            _traductor = traductor;

        }

        public string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{_traductor.Traducir("LISTA_VACIA", idioma)}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{_traductor.Traducir("TITULO", idioma)}</h1>");

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecios = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecio = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i] is Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i] is Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i] is TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }

                    if (formas[i] is Trapecio)
                    {
                        numeroTrapecios++;
                        areaTrapecios += formas[i].CalcularArea();
                        perimetroTrapecio += formas[i].CalcularPerimetro();
                    }
                }

                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, new Cuadrado(0), idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, new Circulo(0), idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, new TrianguloEquilatero(0), idioma));
                //sb.Append(ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecio, new Trapecio(0,0,0,0,0), idioma));

                // FOOTER
                sb.Append($"{_traductor.Traducir("TOTAL", idioma)}:<br/>");

                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + _traductor.Traducir("FORMAS", idioma) + " ");
                sb.Append(_traductor.Traducir("PERIMETRO", idioma) + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append(_traductor.Traducir("AREA", idioma) + " " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

        private string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica forma, int idioma)
        {
            if (cantidad > 0)
            {
                return string.Format(_traductor.Traducir("OBTENER_LINEA", idioma), cantidad, TraducirForma(forma, cantidad, idioma), area.ToString("#.##"), perimetro.ToString("#.##"));
            }
            
            return string.Empty;
        }

        private string TraducirForma(FormaGeometrica forma, int cantidad, int idioma)
        {

            return cantidad == 1 ? _traductor.Traducir(forma.ObtenerNombreClaveForma(), idioma) : _traductor.Traducir(forma.ObtenerNombreClaveFormaPlural(), idioma);
        }
    }
}
