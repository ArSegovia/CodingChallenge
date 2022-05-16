using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _lado1;
        private readonly decimal _lado2;
        private readonly decimal _base1;
        private readonly decimal _base2;
        private readonly decimal _altura;
        private static int _numero = 0;        
        private static decimal _area = 0;
        private static decimal _perimetro = 0;      

        public int Numero { get { return _numero; } }
        public decimal Area { get { return _area; } }
        public decimal Perimetro { get { return _perimetro; } }       

        public Trapecio()
        {
        }

        public Trapecio(decimal lado1, decimal lado2, decimal base1, decimal base2, decimal altura)
        {
            _numero++;
            _lado1 = lado1;
            _lado2 = lado2;
            _base1 = base1;
            _base2 = base2;
            _altura = altura;
        }
        public override decimal CalcularArea()
        {
            decimal area = ((_base1 + _base2) * _altura) / 2;
            _area += area;
            return area;
        }

        public override decimal CalcularPerimetro()
        {
            decimal perimetro = _lado1 + _lado2 + _base1 + _base2;            
            _perimetro += perimetro;
            return perimetro;
        }
    }
}
