using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork1._0.Models
{
    public enum GradoScolastico
    {
        ELEMENTARE,
        MEDIE,
        SUPERIORI
    }
    public enum Materia
    {
        ALGEBRA,
        GEOMETRIA,
        GONIOMETRIA
    }
    // Rappresenta una formula
    public class Formula
    {
        public string Grado { get; set; }
        public string Materia { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }

        // Restituisce il titolo della formula come rappresentazione testuale dell'oggetto
        public override string ToString()
        {
            return Titolo;
        }
    }
}
