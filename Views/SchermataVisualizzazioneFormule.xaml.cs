using System.Collections.ObjectModel;
using System.Data;
using System.Text.Json;
using ProjectWork1._0.Models;
using ProjectWork1._0.View_Models;

namespace ProjectWork1._0.Views;

public partial class SchermataVisualizzazioneFormule : ContentPage
{
	//private GradoScolastico grado;
	//private Materia materia;

/* Modifica senza merge dal progetto 'ProjectWork1.0 (net8.0-windows10.0.19041.0)'
Prima:
	FormuleViewModel caricamentoContenuti = new FormuleViewModel();
	public SchermataVisualizzazioneFormule(GradoScolastico grado, Materia materia)
Dopo:
	FormuleService caricamentoContenuti = new FormuleViewModel();
	public SchermataVisualizzazioneFormule(GradoScolastico grado, Materia materia)
*/
/*
	FormuleService _formulaService = new FormuleService("formule.json");
	public SchermataVisualizzazioneFormule(GradoScolastico grado, Materia materia)
	{
		InitializeComponent();
		this.grado = grado;
		this.materia = materia;
		//CaricaFormule();
	}
*/

	/*private void CaricaFormule()
	{
		LezioniPicker.ItemsSource = _formulaService.CaricaFormule(grado, materia);

    }

    private void LezioniPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        Formula? lezioneSelezionata = (Formula)LezioniPicker.SelectedItem;
		if(lezioneSelezionata != null)
		{
            DescrizioneLabel.Text = lezioneSelezionata.Descrizione;
            DescrizioneLabel.IsVisible = true;

        }
    }*/

    /*
    private async void OnBackButtonClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new SchermataVisualizzazioneFormule(grado, materia));
    }
    */




    private readonly FormuleViewModel viewModel;

    public SchermataVisualizzazioneFormule(GradoScolastico grado, Materia materia)
    {
        /*
        InitializeComponent();
        viewModel = new FormuleViewModel(new FormuleService());
        BindingContext = viewModel;
        viewModel.Carica(grado, materia);
        */
        InitializeComponent();

        // Percorso file JSON: metti il nome corretto del tuo file
        string filePath = Path.Combine(FileSystem.AppDataDirectory, "formule.json");

        viewModel = new FormuleViewModel(new FormuleService(filePath));
        BindingContext = viewModel;

        viewModel.Carica(grado, materia);

    }

    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }



}