using System.Collections.ObjectModel;
using System.Data;
using System.Text.Json;
using ProjectWork1._0.Models;
using ProjectWork1._0.ViewModels; // Corretto il namespace per le ViewModel

namespace ProjectWork1._0.Views;

public partial class SchermataVisualizzazioneFormule : ContentPage
{
    private GradoScolastico grado;
    private Materia materia;

    private FormuleViewModel _formulaViewModel; // Utilizzo della nuova ViewModel

    public SchermataVisualizzazioneFormule(GradoScolastico grado, Materia materia)
    {
        InitializeComponent();
        this.grado = grado;
        this.materia = materia;

        // Inizializzazione della ViewModel
        _formulaViewModel = new FormuleViewModel();
        BindingContext = _formulaViewModel; // Imposta il BindingContext per il data binding
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SchermataVisualizzazioneFormule(grado, materia));
    }
}
