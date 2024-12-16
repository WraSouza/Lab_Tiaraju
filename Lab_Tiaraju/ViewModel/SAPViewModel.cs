using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab_Tiaraju.View;

namespace Lab_Tiaraju.ViewModel
{
    public partial class SAPViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task GoToItemSAPView()
      => await Shell.Current.GoToAsync(nameof(ItemSAPView));

        [RelayCommand]
        public async Task GoToAddBusinessPartnerView()
      => await Shell.Current.GoToAsync(nameof(AddBusinessPartnerView));
    }
}
