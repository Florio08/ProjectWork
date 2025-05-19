using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ProjectWork1._0.ViewModels
{
    public class FormuleViewModel : BaseViewModel
    {
        public ObservableCollection<FormulaItemViewModel> Formule { get; set; }
        public ICommand ToggleDescriptionCommand { get; }

        public FormuleViewModel()
        {
            Formule = new ObservableCollection<FormulaItemViewModel>
            {
                new FormulaItemViewModel { Titolo = "Formula 1", Descrizione = "Descrizione della formula 1" },
                new FormulaItemViewModel { Titolo = "Formula 2", Descrizione = "Descrizione della formula 2" }
            };

            ToggleDescriptionCommand = new Command<FormulaItemViewModel>(ToggleDescription);
        }

        private void ToggleDescription(FormulaItemViewModel formula)
        {
            if (formula != null)
                formula.IsDescriptionVisible = !formula.IsDescriptionVisible;
        }
    }
}

