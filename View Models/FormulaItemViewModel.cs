using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork1._0.ViewModels
{
    public class FormulaItemViewModel : BaseViewModel
    {
        private bool _isDescriptionVisible;

        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public bool IsDescriptionVisible
        {
            get => _isDescriptionVisible;
            set => SetProperty(ref _isDescriptionVisible, value);
        }
    }
}

