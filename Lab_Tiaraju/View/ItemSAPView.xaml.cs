using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class ItemSAPView : ContentPage
{
    private readonly ItemSAPViewModel _viewModel;

    public ItemSAPView(ItemSAPViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = _viewModel = viewModel;

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.GetAllItemsAsync();
    }
}