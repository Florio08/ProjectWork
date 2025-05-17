using ProjectWork1._0.Models;

namespace ProjectWork1._0.Views;

public partial class SchermataIniziale : ContentPage
{
	public SchermataIniziale()
	{
		InitializeComponent();
	}
    //Funzioni principali:
    //-Gestisce la selezione del grado.
    //-Filtra le materie disponibili in base al grado selezionato.
    //-Porta alla pagina successiva(quella per la scelta della materia)
    private void OnBtnSuperioriClicked(object sender, EventArgs e)
    {
        var grado = GradoScolastico.SUPERIORI;
        // Esegui l'azione desiderata quando il pulsante viene cliccato
        // Ad esempio, naviga a un'altra pagina o esegui un'operazione
        Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }

    private void OnBtnMedieClicked(object sender, EventArgs e)
    {
        var grado = GradoScolastico.MEDIE;
        Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }

    private void OnBtnElementariClicked(object sender, EventArgs e)
    {
        var grado = GradoScolastico.ELEMENTARE;
        Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }
}