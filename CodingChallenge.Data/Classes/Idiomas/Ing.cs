using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ing
    {
        private const string _listaVacia = "Empty list of shapes!";
        private const string _listaCabecera = "Shapes report";
        private const string _listaTotal = "TOTAL:";

        private const string _area = "Area";
        private const string _perimetro = "Perimeter";

        private const string _formaSingular = "shape";
        private const string _formaPlural = "shapes";
        private const string _circuloSingular = "Circle";
        private const string _circuloPlural = "Circles";
        private const string _cuadradoSingular = "Square";
        private const string _cuadradoPlural = "Squares";
        private const string _rectanguloSingular = "Rectangle";
        private const string _rectanguloPlural = "Rectangles";
        private const string _trapecioSingular = "Trapezium";
        private const string _trapecioPlural = "Trapezia";
        private const string _trianguloEquilateroSingular = "Triangle";
        private const string _trianguloEquilateroPlural = "Triangles";

        public string ListaVacia { get { return _listaVacia; } }
        public string ListaCabecera { get { return _listaCabecera; } }
        public string ListaTotal { get { return _listaTotal; } }

        public string Area { get { return _area; } }
        public string Perimetro { get { return _perimetro; } }

        public string FormaSingular { get { return _formaSingular; } }
        public string FormaPlural { get { return _formaPlural; } }
        public string CirculoSingular { get { return _circuloSingular; } }
        public string CirculoPlural { get { return _circuloPlural; } }
        public string CuadradoSingular { get { return _cuadradoSingular; } }
        public string CuadradoPlural { get { return _cuadradoPlural; } }
        public string RectanguloSingular { get { return _rectanguloSingular; } }
        public string RectanguloPlural { get { return _rectanguloPlural; } }
        public string TrapecioSingular { get { return _trapecioSingular; } }
        public string TrapecioPlural { get { return _trapecioPlural; } }
        public string TrianguloEquilateroSingular { get { return _trianguloEquilateroSingular; } }
        public string TrianguloEquilateroPlural { get { return _trianguloEquilateroPlural; } }
    }
}
