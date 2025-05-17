using ProjectWork1._0.Views;    
namespace ProjectWork1._0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new SchermataIniziale());

            _ = CopiaFileJsonSeServeAsync(); // Esegui l'operazione asincrona senza bloccare
        }

        private async Task CopiaFileJsonSeServeAsync()
        {
            string fileName = "formule.json";
            string targetPath = Path.Combine(FileSystem.AppDataDirectory, fileName);

            if (!File.Exists(targetPath))
            {
                try
                {
                    using var stream = await FileSystem.OpenAppPackageFileAsync($"Json/{fileName}");
                    using var reader = new StreamReader(stream);
                    var content = await reader.ReadToEndAsync();

                    Console.WriteLine("✅ File JSON copiato in:");
                    Console.WriteLine(targetPath);

                    Console.WriteLine("📄 Contenuto del file:");
                    Console.WriteLine(content);

                    File.WriteAllText(targetPath, content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Errore nella copia del file JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("ℹ️ Il file esiste già, nessuna copia necessaria.");
            }
        }
    }
}
