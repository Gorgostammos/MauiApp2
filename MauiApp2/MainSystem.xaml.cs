using Microsoft.Maui.Controls;

namespace MauiApp2;

public partial class MainSystem : ContentPage
{
	public MainSystem()
	{
		InitializeComponent();

        var Språk = new List<string>();
        Språk.Add("Engelsk");
        Språk.Add("Spansk");
        Språk.Add("Fransk");
        Språk.Add("Dansk");
        Språk.Add("Norsk");
        
        Picker picker = new Picker { Title = "Velg Språket" };
        picker.ItemsSource = Språk;
    }
    private void BtnUrl_Klikk(object sender, EventArgs e)
    {

        Navigation.PushAsync(new NewPage1());
    }


}