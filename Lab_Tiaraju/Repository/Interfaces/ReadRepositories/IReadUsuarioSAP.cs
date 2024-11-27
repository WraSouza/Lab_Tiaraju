using Lab_Tiaraju.Model.Entities;

namespace Lab_Tiaraju.Repository.Interfaces.ReadRepositories
{
    public interface IReadUsuarioSAP
    {
        Task<Usuario> GetUsuarioByNameAsync(string name);
    }
}
