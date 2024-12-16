using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab_Tiaraju.Model.Entities;

namespace Lab_Tiaraju.ViewModel
{
    public partial class AddBusinessPartnerViewModel : ObservableObject
    {
        [ObservableProperty]
        string nome = string.Empty;

        [ObservableProperty]
        string telefone = string.Empty;

        [ObservableProperty]
        string email = string.Empty;

        [ObservableProperty]
        string cpf = string.Empty;

        [ObservableProperty]
        string rua = string.Empty;

        [ObservableProperty]
        string numero = string.Empty;

        [ObservableProperty]
        string uf = string.Empty;

        [ObservableProperty]
        string cidade = string.Empty;

        [ObservableProperty]
        string cep = string.Empty;

        [ObservableProperty]
        string bairro = string.Empty;

        private List<BPAddress> bpAddresses = new();
        private List<BPFiscalTaxIDCollection> bpFiscalCollection = new();

        [RelayCommand]
        public async Task AddBusinessPartner()
        {

        }
    }
}
