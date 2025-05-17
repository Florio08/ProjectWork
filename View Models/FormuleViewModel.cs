using CommunityToolkit.Mvvm.ComponentModel;
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
        
        private readonly FormuleService service;

        public ObservableCollection<FormulaGroup> FormuleRaggruppate { get; set; }

        public FormuleViewModel(FormuleService service)
        {
            this.service = service;
            FormuleRaggruppate = new ObservableCollection<FormulaGroup>();
        }

        public void Carica(GradoScolastico grado, Materia materia)
        {
            var formule = service.CaricaFormule(grado, materia);

            Console.WriteLine($"🔎 Caricate {formule.Count} formule per {grado} - {materia}");

            var gruppi = formule
                .GroupBy(f => f.Titolo)
                .Select(g => new FormulaGroup(g.Key, g));

            FormuleRaggruppate.Clear();

            foreach (var gruppo in gruppi)
            {
                Console.WriteLine($"📂 Gruppo: {gruppo.Titolo} con {gruppo.Count} formule");
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
