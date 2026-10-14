namespace MauiAppJogoVelha2026
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(vez == "X")
            {
                btn.Text = "X";
                btn.TextColor = Color.Parse("Blue");
                vez = "O";
            } else
            {
                btn.Text = "O";
                btn.TextColor = Color.Parse("Green");
                vez = "X";
            }

            btn.IsEnabled = false;


            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlertAsync("Parabéns!!", "O X Ganhou! 🏆", "OK");
                Zerar();
            }

        } // fecha método

        void Zerar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
            
            btn11.Text = "";
            btn11.IsEnabled = true;
            
            btn12.Text = "";
            btn12.IsEnabled = true;
        }
    }
}
