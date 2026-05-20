namespace MauiAppHotel.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
    App PropriedadesApp;

	public ContrataçãoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.listaquartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkout.Date.Value.AddMonths(6);
	}
    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        } catch (Exception ex) 
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime Data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = Data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = Data_selecionada_checkin.AddMonths(6);
    }
}