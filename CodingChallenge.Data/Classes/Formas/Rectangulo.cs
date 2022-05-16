using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _lado1;
        private readonly decimal _lado2;
        private static int _numero = 0;        
        private static decimal _area = 0;
        private static decimal _perimetro = 0;       

        public int Numero { get { return _numero; } }
        public decimal Area { get { return _area; } }
        public decimal Perimetro { get { return _perimetro; } }     

        public Rectangulo()
        {
        }

        public Rectangulo(decimal lado1, decimal lado2)
        {
            _numero++;
            _lado1 = lado1;
            _lado2 = lado2;
        }
        public override decimal CalcularArea()
        {
            decimal area = _lado1 * _lado2;
            _area += area;
            return area;
        }

        public override decimal CalcularPerimetro()
        {
            decimal perimetro = 2 * (_lado1 + _lado2);            
            _perimetro += perimetro;
            return perimetro;
        }
    }
}
