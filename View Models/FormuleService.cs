using CommunityToolkit.Mvvm.ComponentModel;
using ProjectWork1._0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectWork1._0.View_Models
{
	public class FormuleService
	{
        private string fileName;

        public FormuleService(string fileName)
        {
            this.fileName = fileName; 
        }
        
        private List<Formula> ListaDiFormuleVuota()
        {
            return new List<Formula>();
        }

        //Funzioni principali:
        //-Mostra le formule/dimostrazioni filtrandole per il grado e la materia selezionati.
        public List<Formula> CaricaFormule(GradoScolastico grado, Materia materia)
        {
            //controllo se esiste prima di leggere il file, in caso esco col return 
            if (!File.Exists(fileName)) return ListaDiFormuleVuota();
            //leggo il file Json 
            string fileJson = File.ReadAllText(fileName);
            List<Formula>? formule = JsonSerializer.Deserialize<List<Formula>>(fileJson);
            if (formule == null) return ListaDiFormuleVuota();
            return formule!
                .Where(formula => formula.Materia == materia && formula.Grado == grado
            ).ToList();
        }
    }
}
