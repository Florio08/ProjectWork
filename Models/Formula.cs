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
    public class Formula
    {
        public GradoScolastico Grado { get; set; }
        public Materia Materia { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }

        public override string ToString()
        {
            return Titolo;
        }
    }
}
