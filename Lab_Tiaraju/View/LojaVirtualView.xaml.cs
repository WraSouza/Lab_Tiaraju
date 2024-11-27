using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class LojaVirtualView : ContentPage
{
    private readonly LojaVirtualViewModel _viewModel;

    public LojaVirtualView(LojaVirtualViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = _viewModel = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.GetMagentoSales();
    }
}