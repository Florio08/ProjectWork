using ProjectWork1._0.Models;

namespace ProjectWork1._0.Views;

//Funzioni principali:
//-Gestisce la selezione della materia.
//-Porta alla pagina successiva(quella delle formule)
public partial class SchermataSelezioneMateria : ContentPage
{
    private GradoScolastico grado;

	public SchermataSelezioneMateria(GradoScolastico grado)
	{
		InitializeComponent();
        this.grado = grado;

        btnGoniometria.IsVisible = false;
        if (grado == GradoScolastico.SUPERIORI)
        {
            btnGoniometria.IsVisible = true;
        }
	}

    private void OnBtnAlgebraClicked(object sender, EventArgs e)
    {
        var materia = Materia.ALGEBRA;
        // Esegui l'azione desiderata quando il pulsante viene cliccato
        // Ad esempio, naviga a un'altra pagina o esegui un'operazione
        Navigation.PushAsync(new SchermataVisualizzazioneFormule(grado, materia));
    }

    private void OnBtnGeometriaClicked(object sender, EventArgs e)
    {
        var materia = Materia.GEOMETRIA;
        Navigation.PushAsync(new SchermataVisualizzazioneFormule(grado, materia));
    }

    private void OnBtnGoniometriaCkicked(object sender, EventArgs e)
    {
        var materia = Materia.GONIOMETRIA;
        Navigation.PushAsync(new SchermataVisualizzazioneFormule(grado, materia));
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }
}