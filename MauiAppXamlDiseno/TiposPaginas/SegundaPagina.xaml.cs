namespace MauiAppXamlDiseno.TiposPaginas;

public partial class SegundaPagina : ContentPage
{
	public SegundaPagina()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}