using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class AddBusinessPartnerView : ContentPage
{
	public AddBusinessPartnerView(AddBusinessPartnerViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}