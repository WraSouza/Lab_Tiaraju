using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab_Tiaraju.View;

namespace Lab_Tiaraju.ViewModel
{
    public partial class DepartmentsViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task GoToComercialView()
       => await Shell.Current.GoToAsync(nameof(ComercialView));
    }
}
