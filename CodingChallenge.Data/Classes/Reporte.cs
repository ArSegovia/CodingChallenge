/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {
        public static string Imprimir(List<FormaGeometrica> formas, string idioma)
        {
            StringBuilder sb = new StringBuilder();

            Type idiomaType = Type.GetType("CodingChallenge.Data.Classes." + idioma);          
            object tipoIdioma = Activator.CreateInstance(idiomaType);

            if (!formas.Any())
            {
                object listaVacia = tipoIdioma.GetType().GetProperty("ListaVacia").GetValue(tipoIdioma, null);
                sb.Append($"<h1>{listaVacia}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER             
                object listaCabecera = tipoIdioma.GetType().GetProperty("ListaCabecera").GetValue(tipoIdioma, null);
                sb.Append($"<h1>{listaCabecera}</h1>");

                int totalFormas = 0;
                decimal totalArea = 0;  
                decimal totalPerimetro = 0;
                List<Type> tipoFormas = new List<Type>();                

                foreach (FormaGeometrica f in formas)
                {
                    if (!tipoFormas.Contains(f.GetType()))
                        tipoFormas.Add(f.GetType());                    

                    decimal area = f.CalcularArea();
                    decimal perimetro = f.CalcularPerimetro();

                    totalFormas++;
                    totalArea += area;
                    totalPerimetro += perimetro;
                }

                object labelArea, labelPerimetro, labelForma;
                foreach (Type t in tipoFormas)
                {
                    object tipoForma = Activator.CreateInstance(t);
                    object numero = tipoForma.GetType().GetProperty("Numero").GetValue(tipoForma, null);
                    string forma = (int)numero > 1 ? "Plural" : "Singular";
                    object tipo = tipoIdioma.GetType().GetProperty(t.Name + forma).GetValue(tipoIdioma, null);
                    object area = tipoForma.GetType().GetProperty("Area").GetValue(tipoForma, null);
                    object perimetro = tipoForma.GetType().GetProperty("Perimetro").GetValue(tipoForma, null);
                    labelArea = tipoIdioma.GetType().GetProperty("Area").GetValue(tipoIdioma, null);
                    labelPerimetro = tipoIdioma.GetType().GetProperty("Perimetro").GetValue(tipoIdioma, null);
                    sb.Append(ObtenerLinea((int)numero, (decimal)area, (decimal)perimetro, (string)tipo, (string)labelArea, (string)labelPerimetro));
                }

                // FOOTER
                object listaTotal = tipoIdioma.GetType().GetProperty("ListaTotal").GetValue(tipoIdioma, null);
                sb.Append($"{listaTotal}<br/>");
                if (totalFormas > 1)
                    { labelForma = tipoIdioma.GetType().GetProperty("FormaPlural").GetValue(tipoIdioma, null); }
                else
                    { labelForma = tipoIdioma.GetType().GetProperty("FormaSingular").GetValue(tipoIdioma, null); }
                sb.Append($"{totalFormas} {labelForma} ");
                labelPerimetro = tipoIdioma.GetType().GetProperty("Perimetro").GetValue(tipoIdioma, null);
                sb.Append($"{labelPerimetro} {totalPerimetro.ToString("#.##")} ");
                labelArea = tipoIdioma.GetType().GetProperty("Area").GetValue(tipoIdioma, null);
                sb.Append($"{labelArea} {totalArea.ToString("#.##")}");
            }
            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, string lblArea, string lblPerimetro)
        {  
            return $"{cantidad} {tipo} | {lblArea} {area:#.##} | {lblPerimetro} {perimetro:#.##} <br/>";       
        }

    }
}
