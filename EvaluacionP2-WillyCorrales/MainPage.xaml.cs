namespace EvaluacionP2_WillyCorrales
{
    public partial class MainPage : ContentPage
    {
        string reca = null;
        string num = null;
        
        public MainPage()
        {
            InitializeComponent();

            WCOperador.Items.Add("Claro");
            WCOperador.Items.Add("Movistar");
            WCOperador.Items.Add("Tuenti");
        }

        private void RecargaSelect(object sender, CheckedChangedEventArgs num)
        {
            var recarga = sender as RadioButton;
            confirmacion.Text = $"Ha seleccionado una recarga de {recarga.Content}";
            reca = (string)recarga.Content;

        }
        void numero(object sender, TextChangedEventArgs e)
        {
            num = e.NewTextValue;
        }



        private async void RecargaHecha(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string texto = $"Se hizo una recarga de {reca} dólares en la siguiente fecha {fechaActual}";

            string rutaArchivo = Path.Combine("E:\\Yo\\Local\\EvaluacionP2-WillyCorrales\\EvaluacionP2-WillyCorrales\\EvaluacionP2-WillyCorrales\\Resources\\Texto\\", $"{num}.txt");

            File.WriteAllText(rutaArchivo, texto);

            await DisplayAlert("Finalizado", "Recarga exitosa", "Ok");

        }

        
    }
}