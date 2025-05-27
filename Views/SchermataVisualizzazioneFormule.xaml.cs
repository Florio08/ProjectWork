using System.Collections.ObjectModel;
using System.Data;
using System.Text.Json;
using ProjectWork1._0.Models;
using ProjectWork1._0.View_Models;

namespace ProjectWork1._0.Views;

public partial class SchermataVisualizzazioneFormule : ContentPage
{
    private readonly FormuleViewModel viewModel;

    public SchermataVisualizzazioneFormule(GradoScolastico grado, Materia materia)
    {
        InitializeComponent();

        // Percorso file JSON: metti il nome corretto del tuo file
        string filePath = FileSystem.OpenAppPackageFileAsync("formule.json").Result.ToString();

        viewModel = new FormuleViewModel();
        BindingContext = viewModel;

        viewModel.Carica(grado, materia);

    }
    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}