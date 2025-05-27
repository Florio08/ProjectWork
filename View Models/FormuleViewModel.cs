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
    // ViewModel responsabile della gestione e del caricamento delle formule da visualizzare nell'interfaccia utente
    public class FormuleViewModel
    {
        // Collezione osservabile di formule da mostrare nella view
        // Viene aggiornata quando si cambiano materia o grado scolastico
        public ObservableCollection<Formula> FormuleRaggruppate { get; set; }

        public FormuleViewModel()
        {
            FormuleRaggruppate = new ObservableCollection<Formula>();
        }

        // Metodo per caricare le formule in base al grado scolastico e alla materia selezionati
        // Richiama il metodo .CaricaFormule di FormulaService per ottenere le formule già filtrate
        public void Carica(GradoScolastico grado, Materia materia)
        {
            var formule = FormulaService.CaricaFormule(grado, materia);

            FormuleRaggruppate.Clear(); // Pulisce la lista prima di riempirla

            foreach (var gruppo in formule)
            {
                FormuleRaggruppate.Add(gruppo); // Aggiunge ogni formula alla collezione
            }
        }
    }
}
