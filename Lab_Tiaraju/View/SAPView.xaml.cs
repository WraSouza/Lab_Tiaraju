using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class SAPView : ContentPage
{
	public SAPView(SAPViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;

    }
}