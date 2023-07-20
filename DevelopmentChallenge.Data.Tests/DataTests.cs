using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        readonly Traductor _traductor;
        readonly Reporte _reporte;

        public DataTests()
        {

            _traductor = new Traductor();
            _traductor.AgregarTraduccion("LISTA_VACIA", (int)Idioma.Castellano, "Lista vacía de formas!");
            _traductor.AgregarTraduccion("LISTA_VACIA", (int)Idioma.Ingles, "Empty list of shapes!");
            _traductor.AgregarTraduccion("LISTA_VACIA", (int)Idioma.Italiano, "Elenco vuoto di forme!");
            _traductor.AgregarTraduccion("TITULO", (int)Idioma.Castellano, "Reporte de Formas");
            _traductor.AgregarTraduccion("TITULO", (int)Idioma.Ingles, "Shapes report");
            _traductor.AgregarTraduccion("TITULO", (int)Idioma.Italiano, "Relazione sulle forme");
            _traductor.AgregarTraduccion("TOTAL", (int)Idioma.Castellano, "TOTAL");
            _traductor.AgregarTraduccion("TOTAL", (int)Idioma.Ingles, "TOTAL");
            _traductor.AgregarTraduccion("TOTAL", (int)Idioma.Italiano, "TOTAL");
            _traductor.AgregarTraduccion("FORMAS", (int)Idioma.Castellano, "formas");
            _traductor.AgregarTraduccion("FORMAS", (int)Idioma.Ingles, "shapes");
            _traductor.AgregarTraduccion("FORMAS", (int)Idioma.Italiano, "forme");
            _traductor.AgregarTraduccion("PERIMETRO", (int)Idioma.Castellano, "Perimetro");
            _traductor.AgregarTraduccion("PERIMETRO", (int)Idioma.Ingles, "Perimeter");
            _traductor.AgregarTraduccion("PERIMETRO", (int)Idioma.Italiano, "Perimetro");
            _traductor.AgregarTraduccion("AREA", (int)Idioma.Castellano, "Area");
            _traductor.AgregarTraduccion("AREA", (int)Idioma.Ingles, "Area");
            _traductor.AgregarTraduccion("AREA", (int)Idioma.Italiano, "La zona");
            _traductor.AgregarTraduccion("OBTENER_LINEA", (int)Idioma.Castellano, "{0} {1} | Area {2} | Perimetro {3} <br/>");
            _traductor.AgregarTraduccion("OBTENER_LINEA", (int)Idioma.Ingles, "{0} {1} | Area {2} | Perimeter {3} <br/>");
            _traductor.AgregarTraduccion("OBTENER_LINEA", (int)Idioma.Italiano, "{0} {1} | Area {2} | Perimetro {3} <br/>");
            _traductor.AgregarTraduccion("CUADRADO", (int)Idioma.Castellano, "Cuadrado");
            _traductor.AgregarTraduccion("CUADRADO", (int)Idioma.Ingles, "Square");
            _traductor.AgregarTraduccion("CUADRADO", (int)Idioma.Italiano, "Piazza");
            _traductor.AgregarTraduccion("CUADRADOS", (int)Idioma.Castellano, "Cuadrados");
            _traductor.AgregarTraduccion("CUADRADOS", (int)Idioma.Ingles, "Squares");
            _traductor.AgregarTraduccion("CUADRADOS", (int)Idioma.Italiano, "Piazzas");
            _traductor.AgregarTraduccion("CIRCULO", (int)Idioma.Castellano, "Círculo");
            _traductor.AgregarTraduccion("CIRCULO", (int)Idioma.Ingles, "Circle");
            _traductor.AgregarTraduccion("CIRCULO", (int)Idioma.Italiano, "Cerchio");
            _traductor.AgregarTraduccion("CIRCULOS", (int)Idioma.Castellano, "Círculos");
            _traductor.AgregarTraduccion("CIRCULOS", (int)Idioma.Ingles, "Circles");
            _traductor.AgregarTraduccion("CIRCULOS", (int)Idioma.Italiano, "Cerchi");
            _traductor.AgregarTraduccion("TRIANGULO", (int)Idioma.Castellano, "Triángulo");
            _traductor.AgregarTraduccion("TRIANGULO", (int)Idioma.Ingles, "Triangle");
            _traductor.AgregarTraduccion("TRIANGULO", (int)Idioma.Italiano, "triangolo");
            _traductor.AgregarTraduccion("TRIANGULOS", (int)Idioma.Castellano, "Triángulos");
            _traductor.AgregarTraduccion("TRIANGULOS", (int)Idioma.Ingles, "Triangles");
            _traductor.AgregarTraduccion("TRIANGULOS", (int)Idioma.Italiano, "triangoli");
            _traductor.AgregarTraduccion("TRAPECIO", (int)Idioma.Castellano, "Trapecio");
            _traductor.AgregarTraduccion("TRAPECIO", (int)Idioma.Ingles, "Trapeze");
            _traductor.AgregarTraduccion("TRAPECIO", (int)Idioma.Italiano, "triangolo");
            _traductor.AgregarTraduccion("TRAPECIOS", (int)Idioma.Castellano, "Trapezio");
            _traductor.AgregarTraduccion("TRAPECIOS", (int)Idioma.Ingles, "trapezoids");
            _traductor.AgregarTraduccion("TRAPECIOS", (int)Idioma.Italiano, "trapezi");

            _reporte = new Reporte(_traductor);

        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                _reporte.Imprimir(new List<FormaGeometrica>(), (int)Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                _reporte.Imprimir(new List<FormaGeometrica>(), (int)Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                _reporte.Imprimir(new List<FormaGeometrica>(), (int)Idioma.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = _reporte.Imprimir(cuadrados, (int)Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = _reporte.Imprimir(cuadrados, (int)Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = _reporte.Imprimir(formas, (int)Idioma.Ingles);
            
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {

            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = _reporte.Imprimir(formas, (int)Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
