namespace MauiApp2;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnLogin_Clicked(object sender, EventArgs e)
    {
		if (txtbruker.Text == "User" & txtpassord.Text == "Passord")
			Navigation.PushAsync(new MainSystem());
    }


    private void BtnReg_Clicked(object sender, EventArgs e)
    {
       
            Navigation.PushAsync(new pageReg());
    }
}

