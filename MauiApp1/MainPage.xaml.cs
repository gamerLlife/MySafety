namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            count = count == 1 ? 0 : 1;
            btn_register.Text = count == 1 ? $"Registered" : "Register";
            SemanticScreenReader.Announce(btn_register.Text);
        }
    }

}
