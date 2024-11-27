using Firebase.Database;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.Interfaces.ReadRepositories;
using Microsoft.Maui.Storage;

namespace Lab_Tiaraju.Repository.Implementations
{
    public class ReadUsuarioSAP : IReadUsuarioSAP
    {
        FirebaseClient firebase;
        public ReadUsuarioSAP()
        {
            firebase = new FirebaseClient("https://laboratoriotiaraju-6c89e-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return (await firebase.Child("Usuario")
                .OnceAsync<Usuario>()).Select(item => new Usuario
                {
                    Name = item.Object.Name,
                    UserName = item.Object.UserName,
                    IsActive = item.Object.IsActive,
                    Password = item.Object.Password,
                    Departments = item.Object.Departments,

                }).ToList();
        }


        public async Task<Usuario> GetUsuarioByNameAsync(string name)
        {
            //throw new NotImplementedException();
            var users = await GetAllAsync();

            await firebase
               .Child("Usuario")
               .OnceAsync<Usuario>();

            var selectedUser = users.Where(x => x.UserName == name).FirstOrDefault();

            return selectedUser;

        }
    }
}
