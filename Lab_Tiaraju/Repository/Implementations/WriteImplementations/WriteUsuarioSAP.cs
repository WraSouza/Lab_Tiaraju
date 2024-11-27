using Firebase.Database;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.Interfaces.WriteRepositories;

namespace Lab_Tiaraju.Repository.Implementations.WriteImplementations
{
    public class WriteUsuarioSAP : IWriteUsuarioSAP
    {
        FirebaseClient firebase;

        public WriteUsuarioSAP()
        {
            firebase = new FirebaseClient("https://laboratoriotiaraju-6c89e-default-rtdb.firebaseio.com/");
        }

        public void AddUser(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Login(string username, string password)
        {
            var user = (await firebase.Child("Usuario")
               .OnceAsync<Usuario>())
               .Where(u => u.Object.UserName == username)
               .Where(u => u.Object.Password == password)
               .FirstOrDefault();


            return user != null;

        }

        public void UpdateStatus(bool status, string username)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
