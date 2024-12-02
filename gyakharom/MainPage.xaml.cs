using System.Collections.ObjectModel;

namespace gyakharom
{
    public partial class MainPage : ContentPage
    {
        public DataModel DataModel { get; set; }
        public MainPage()
        {
            DataModel = new DataModel(this);
            BindingContext = DataModel;
            InitializeComponent();
        }

        public async Task DisplayHowManyA()
        {
            await DisplayAlert(string.Empty, $"{DataModel.HowManyA} db A kezdőbetűs név van.", "Bezár");
        }
    }
}
