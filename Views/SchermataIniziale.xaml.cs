using ProjectWork1._0.Models;

namespace ProjectWork1._0.Views;

//Funzioni principali:
//-Gestisce la selezione del grado.
//-Filtra le materie disponibili in base al grado selezionato.
//-Porta alla pagina successiva(quella per la scelta della materia)
public partial class SchermataIniziale : ContentPage
{
	public SchermataIniziale()
	{
		InitializeComponent();
	}

    // Gestisce il click del pulsante per le scuole superiori
    // Naviga alla schermata di selezione della materia per le scuole superiori
    private void OnBtnSuperioriClicked(object sender, EventArgs e)
    {
        var grado = GradoScolastico.SUPERIORI;
        // Esegui l'azione desiderata quando il pulsante viene cliccato
        // Ad esempio, naviga a un'altra pagina o esegui un'operazione
        Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }

    // Gestisce il click del pulsante per le scuole medie
    // Naviga alla schermata di selezione della materia per le scuole medie
    private void OnBtnMedieClicked(object sender, EventArgs e)
    {
        var grado = GradoScolastico.MEDIE;
        Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }

    // Gestisce il click del pulsante per le scuole elementari
    // Naviga alla schermata di selezione della materia per le scuole elementari
    private void OnBtnElementariClicked(object sender, EventArgs e)
    {
        var grado = GradoScolastico.ELEMENTARE;
        Navigation.PushAsync(new SchermataSelezioneMateria(grado));
    }
}