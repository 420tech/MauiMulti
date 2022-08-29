namespace MauiMulti.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		Title = "Detail page";
	}
}
