using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class MagentoView : ContentPage
{
	public MagentoView(MagentoViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;

    }
}