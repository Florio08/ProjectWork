using ProjectWork1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ProjectWork1._0.Infrastructure
{
    // Classe statica che gestisce il caricamento e il filtraggio delle formule dal file JSON
    public static class FormulaService
    {
        // Legge il file JSON contenente tutte le formule e lo deserializza in una lista di oggetti Formula
        public static List<Formula> CreaListaFormule()
        {
            try
            {
                // Utilizza FileSystem per aprire il file formule.json all'interno del pacchetto dell'app
                using var stream = FileSystem.OpenAppPackageFileAsync("formule.json").Result;
                using var reader = new StreamReader(stream);

                // Legge tutto il contenuto del file JSON
                string jsonAllFormule = reader.ReadToEnd();

                // Deserializza il JSON in una lista di oggetti Formula
                var formule = JsonSerializer.Deserialize<List<Formula>>(jsonAllFormule);

                // Se la deserializzazione ha successo, restituisce la lista; altrimenti una lista vuota
                return formule ?? new List<Formula>();
            }
            catch (Exception ex)
            {
                return new List<Formula>();
            }
        }
        // Metodo per caricare le formule filtrate in base al grado scolastico e alla materia
        public static List<Formula> CaricaFormule(GradoScolastico grado, Materia materia)
        {
            // Recupera tutte le formule dal file JSON
            var formule = CreaListaFormule();

            // Filtra le formule in base al grado scolastico e alla materia specificati
            return formule
                    .Where(formula => formula.Materia ==Enum.GetName(materia) && formula.Grado == Enum.GetName(grado))
                    .ToList();
        }
    }
}
