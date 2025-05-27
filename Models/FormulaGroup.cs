using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork1._0.Models
{
    // Rappresenta un gruppo di formule con lo stesso titolo
    // Utilizzato per raggruppare le formule nella CollectionView
    public class FormulaGroup : List<Formula>
    {
        // Titolo comune del gruppo (es. "Perimetro del rettangolo")
        public string Titolo { get; set; }

        public FormulaGroup(string titolo, IEnumerable<Formula> formule) : base(formule)
        {
            Titolo = titolo;
        }
    }
}
