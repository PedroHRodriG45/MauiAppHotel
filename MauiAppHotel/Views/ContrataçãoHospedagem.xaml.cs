using MauiAppHotel.Views;

namespace MauiAppHotel.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
	public ContrataçãoHospedagem()
	{
		InitializeComponent();
	}
    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}