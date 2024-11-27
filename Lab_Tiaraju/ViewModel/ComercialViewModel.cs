using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab_Tiaraju.View;

namespace Lab_Tiaraju.ViewModel
{
    public partial class ComercialViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task GoToLojaVirtualView()
      => await Shell.Current.GoToAsync(nameof(LojaVirtualView));
    }
}
