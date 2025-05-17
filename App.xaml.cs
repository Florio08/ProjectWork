using ProjectWork1._0.Views;    
namespace ProjectWork1._0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SchermataIniziale());
        }
    }
}
