using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), "Esp"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), "Ing"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), "Ita"));
        }

        //[TestCase]
        //public void TestResumenListaConUnCuadrado()
        //{
        //    var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

        //    var resumen = Reporte.Imprimir(cuadrados, "Esp");

        //    Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 forma Perímetro 20 Área 25", resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConUnCuadradoEnIngles()
        //{
        //    var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

        //    var resumen = Reporte.Imprimir(cuadrados, "Ing");

        //    Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shape Perimeter 20 Area 25", resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConUnCuadradoEnItaliano()
        //{
        //    var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

        //    var resumen = Reporte.Imprimir(cuadrados, "Ita");

        //    Assert.AreEqual("<h1>Racconto di forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forma Perimetro 20 Area 25", resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConMasCuadrados()
        //{
        //    var cuadrados = new List<FormaGeometrica>
        //    {
        //        new Cuadrado(5),
        //        new Cuadrado(1),
        //        new Cuadrado(3)
        //    };

        //    var resumen = Reporte.Imprimir(cuadrados, "Ing");

        //    Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConMasCuadradosEnItaliano()
        //{
        //    var cuadrados = new List<FormaGeometrica>
        //    {
        //        new Cuadrado(5),
        //        new Cuadrado(1),
        //        new Cuadrado(3)
        //    };

        //    var resumen = Reporte.Imprimir(cuadrados, "Ita");

        //    Assert.AreEqual("<h1>Racconto di forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 Area 35", resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConMasTipos()
        //{
        //    var formas = new List<FormaGeometrica>
        //    {
        //        new Cuadrado(5),
        //        new Circulo(3),
        //        new TrianguloEquilatero(4),
        //        new Cuadrado(2),
        //        new TrianguloEquilatero(9),
        //        new Circulo(2.75m),
        //        new TrianguloEquilatero(4.2m)
        //    };

        //    var resumen = Reporte.Imprimir(formas, "Ing");

        //    Assert.AreEqual(
        //        "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
        //        resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConMasTiposEnCastellano()
        //{
        //    var formas = new List<FormaGeometrica>
        //    {
        //        new Cuadrado(5),
        //        new Circulo(3),
        //        new TrianguloEquilatero(4),
        //        new Cuadrado(2),
        //        new TrianguloEquilatero(9),
        //        new Circulo(2.75m),
        //        new TrianguloEquilatero(4.2m)
        //    };

        //    var resumen = Reporte.Imprimir(formas, "Esp");

        //    Assert.AreEqual(
        //        "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
        //        resumen);
        //}

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
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

            var resumen = Reporte.Imprimir(formas, "Ita");

            Assert.AreEqual(
                "<h1>Racconto di forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        //[TestCase]
        //public void TestResumenListaConUnTrapecio()
        //{
        //    List<FormaGeometrica> formas = new List<FormaGeometrica>()
        //    {
        //        new Trapecio(5, 5, 4, 10, 4)

        //    };

        //    string resumen = Reporte.Imprimir(formas, "Esp");

        //    Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Área 28 | Perímetro 24 <br/>TOTAL:<br/>1 forma Perímetro 24 Área 28", resumen);
        //}

        //[TestCase]
        //public void TestResumenListaConUnRectangulo()
        //{
        //{
        //    List<FormaGeometrica> formas = new List<FormaGeometrica>()
        //    {
        //        new Rectangulo(6, 10)

        //    };

        //    string resumen = Reporte.Imprimir(formas, "Esp");

        //    Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Área 60 | Perímetro 32 <br/>TOTAL:<br/>1 forma Perímetro 32 Área 60", resumen);
        //}
    }
}
