using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class ComercialView : ContentPage
{
	public ComercialView(ComercialViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;

    }
}