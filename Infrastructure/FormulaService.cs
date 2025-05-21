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
    public static class FormulaService
    {
        public static List<Formula> CreaListaFormule()
        {
            try
            {
                using var stream = FileSystem.OpenAppPackageFileAsync("formule.json").Result;
                using var reader = new StreamReader(stream);
                string jsonAllFormule = reader.ReadToEnd();                

                var formule = JsonSerializer.Deserialize<List<Formula>>(jsonAllFormule);

                return formule ?? new List<Formula>();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Errore durante la lettura del file JSON: {ex.Message}");
                return new List<Formula>();
            }
        }

        //Funzioni principali:
        //-Mostra le formule/dimostrazioni filtrandole per il grado e la materia selezionati.
        public static List<Formula> CaricaFormule(GradoScolastico grado, Materia materia)
        {
            
            //JsonSerializer.Deserialize<List<Formula>>(json) ?? new List<Formula>();
            var formule = CreaListaFormule();
                return formule
                    .Where(formula => formula.Materia ==Enum.GetName(materia) && formula.Grado == Enum.GetName(grado))
                    .ToList();


            /*
            //controllo se esiste prima di leggere il file, in caso esco col return 
            if (!File.Exists(fileName)) return ListaDiFormuleVuota();
            //leggo il file Json 
            string fileJson = File.ReadAllText(fileName);
            List<Formula>? formule = JsonSerializer.Deserialize<List<Formula>>(fileJson);
            if (formule == null) return ListaDiFormuleVuota();
            
            return formule!
                .Where(formula => formula.Materia == materia && formula.Grado == grado
            ).ToList();
            */
        }
    }
}
