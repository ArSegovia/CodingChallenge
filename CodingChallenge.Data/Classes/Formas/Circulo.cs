using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _lado;
        private static int _numero = 0;        
        private static decimal _area = 0;
        private static decimal _perimetro = 0;      
        public int Numero { get { return _numero; } }
        public decimal Area { get { return _area; } }
        public decimal Perimetro { get { return _perimetro; } }      

        public Circulo()
        {

        }

        public Circulo(decimal lado)
        {
            _numero++;
            _lado = lado;
        }
        public override decimal CalcularArea()
        {
            decimal area = (decimal)Math.PI * (_lado / 2) * (_lado / 2);            
            _area += area;
            return area;
        }

        public override decimal CalcularPerimetro()
        {
            decimal perimetro = (decimal)Math.PI * _lado;
            _perimetro += perimetro;
            return perimetro;
        }
    }
}
