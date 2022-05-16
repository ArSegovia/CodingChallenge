using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Esp
    {
        private const string _listaVacia = "Lista vacía de formas!";
        private const string _listaCabecera = "Reporte de Formas";
        private const string _listaTotal = "TOTAL:";

        private const string _area = "Área";
        private const string _perimetro = "Perímetro";

        private const string _formaSingular = "forma";
        private const string _formaPlural = "formas";
        private const string _circuloSingular = "Círculo";
        private const string _circuloPlural = "Círculos";
        private const string _cuadradoSingular = "Cuadrado";
        private const string _cuadradoPlural = "Cuadrados";
        private const string _rectanguloSingular = "Rectángulo";
        private const string _rectanguloPlural = "Rectángulos";
        private const string _trapecioSingular = "Trapecio";
        private const string _trapecioPlural = "Trapecios";
        private const string _trianguloEquilateroSingular = "Triángulo";
        private const string _trianguloEquilateroPlural = "Triángulos";

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
