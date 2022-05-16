using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ita
    {
        private const string _listaVacia = "Elenco vuoto di forme!";
        private const string _listaCabecera = "Racconto di forme";
        private const string _listaTotal = "TOTALE:";

        private const string _area = "Area";
        private const string _perimetro = "Perimetro";

        private const string _formaSingular = "forma";
        private const string _formaPlural = "forme";
        private const string _circuloSingular = "Cerchio";
        private const string _circuloPlural = "Cerchi";
        private const string _cuadradoSingular = "Quadrato";
        private const string _cuadradoPlural = "Quadrati";
        private const string _rectanguloSingular = "Rettangolo";
        private const string _rectanguloPlural = "Rettangoli";
        private const string _trapecioSingular = "Trapezio";
        private const string _trapecioPlural = "Trapezi";
        private const string _trianguloEquilateroSingular = "Triangolo";
        private const string _trianguloEquilateroPlural = "Triangoli";

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
