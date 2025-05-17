using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork1._0.Models
{
    public class FormulaGroup : List<Formula>
    {
        public string Titolo { get; set; }

        public FormulaGroup(string titolo, IEnumerable<Formula> formule) : base(formule)
        {
            Titolo = titolo;
        }
    }
}
