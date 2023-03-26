using Microsoft.Maui.Controls;

namespace MauiApp2;

public partial class MainSystem : ContentPage
{
	public MainSystem()
	{
		InitializeComponent();

        var Spr�k = new List<string>();
        Spr�k.Add("Engelsk");
        Spr�k.Add("Spansk");
        Spr�k.Add("Fransk");
        Spr�k.Add("Dansk");
        Spr�k.Add("Norsk");
        
        Picker picker = new Picker { Title = "Velg Spr�ket" };
        picker.ItemsSource = Spr�k;
    }
    private void BtnUrl_Klikk(object sender, EventArgs e)
    {

        Navigation.PushAsync(new NewPage1());
    }


}