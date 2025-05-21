using CommunityToolkit.Mvvm.ComponentModel;
using ProjectWork1._0.Infrastructure;
using ProjectWork1._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectWork1._0.View_Models
{
    public class FormuleViewModel
    {

        public ObservableCollection<Formula> FormuleRaggruppate { get; set; }

        public FormuleViewModel()
        {
            FormuleRaggruppate = new ObservableCollection<Formula>();
        }

        public void Carica(GradoScolastico grado, Materia materia)
        {
            var formule = FormulaService.CaricaFormule(grado, materia);

            FormuleRaggruppate.Clear();

            foreach (var gruppo in formule)
            {
                FormuleRaggruppate.Add(gruppo);
            }
        }
    }
}
/*
        [ObservableProperty]
        private ObservableCollection<FormulaGroup> formuleRaggruppate;

        private readonly FormuleService _formuleService;

        public FormuleViewModel(FormuleService formuleService)
        {
            _formuleService = formuleService;
            formuleRaggruppate = new ObservableCollection<FormulaGroup>();
        }

        public void Carica(GradoScolastico grado, Materia materia)
        {
            var formule = _formuleService.CaricaFormule(grado, materia);

            var gruppi = formule
                .GroupBy(f => f.Titolo)
                .Select(g => new FormulaGroup(g.Key, g));

            FormuleRaggruppate.Clear();
            foreach (var gruppo in gruppi)
                FormuleRaggruppate.Add(gruppo);
        }
        */
