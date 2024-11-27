using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class DepartmentsView : ContentPage
{
	public DepartmentsView(DepartmentsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;

    }
}