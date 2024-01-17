namespace WeatherApp_CET301
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherPage();
        }
    }
}