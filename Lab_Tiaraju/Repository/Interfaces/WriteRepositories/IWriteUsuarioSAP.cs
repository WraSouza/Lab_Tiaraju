using Lab_Tiaraju.Model.Entities;

namespace Lab_Tiaraju.Repository.Interfaces.WriteRepositories
{
    public interface IWriteUsuarioSAP
    {
        void AddUser(Usuario usuario);

        void UpdateUser(Usuario usuario);

        void UpdateStatus(bool status, string username);

        Task<bool> Login(string username, string password);

    }
}
