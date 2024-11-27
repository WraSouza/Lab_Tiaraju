using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab_Tiaraju.Helpers;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.Interfaces.ReadRepositories;
using Lab_Tiaraju.Repository.Interfaces.WriteRepositories;
using Lab_Tiaraju.View;

namespace Lab_Tiaraju.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        Usuario user = new();
        private readonly IReadUsuarioSAP _readUsuario;
        private readonly IWriteUsuarioSAP _writeUsuario;

        public LoginViewModel(IReadUsuarioSAP readUsuario, IWriteUsuarioSAP writeUsuario)
        {
            _readUsuario = readUsuario;
            _writeUsuario = writeUsuario;
        }

        public LoginViewModel()
        {

        }

        [ObservableProperty]
        //[NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string? name;

        [ObservableProperty]
        // [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        public string? password;

        // [RelayCommand(CanExecute = nameof(CanExecuteLogin))]
        [RelayCommand]
        public async Task Login()
        {

            Name = Name?.Replace(" ", "");

            Preferences.Set("Nome", Name);


            bool verificaConexao = Conectividade.VerificaConectividade();

            if (verificaConexao)
            {
                if (Name is not null)
                {
                    user = await _readUsuario.GetUsuarioByNameAsync(Name);
                }

                if (user.IsActive == true)
                {
                    if (user.Password.Equals("1234"))
                    {
                        await Shell.Current.GoToAsync(nameof(AtualizarSenhaView));

                        return;
                    }

                    if (Password is not null)
                    {
                        string senhaCriptografada = Criptografia.CriptografaSenha(Password);

                        if (Name is not null)
                        {
                            bool confirmaLogin = await _writeUsuario.Login(Name, senhaCriptografada);

                            if (confirmaLogin)
                            {
                                await Shell.Current.GoToAsync($"//{nameof(HomeView)}");

                                return;
                            }
                        }
                    }

                    //Mensagem.MensagemSenhaInvalida();

                    return;

                }

                // Mensagem.MensagemUsuarioSemAutorizacao();

                return;
            }

            // Mensagem.MensagemErroConexao();

        }

        //private bool CanExecuteLogin()
        //{
        //    var login = new LoginRequest(Name, Password);

        //    var contract = new LoginContract(login);

        //    if (!contract.IsValid)
        //        return false;

        //    return true;
        //}

    }
}
