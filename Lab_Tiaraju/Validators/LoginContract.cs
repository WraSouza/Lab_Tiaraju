using Lab_Tiaraju.Model.Entities;
using Flunt.Validations;

namespace Lab_Tiaraju.Validators
{
    public class LoginContract
    {
        public LoginContract(LoginRequest login)
        {
            //Requires()
            //    .IsNotNullOrEmpty(login.UserName, nameof(login.UserName), "Usuário Deve Ser Preenchido")
            //    .IsNotNullOrEmpty(login.Password, nameof(login.Password), "Senha Não Pode Ser Nula");

        }

    }
}
