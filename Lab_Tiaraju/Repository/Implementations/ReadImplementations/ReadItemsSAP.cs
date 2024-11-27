using Firebase.Database;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.ReadRepositories;

namespace Lab_Tiaraju.Repository.Implementations
{
    public class ReadItemsSAP : IReadItemsSAP
    {
        FirebaseClient firebase;
        public ReadItemsSAP()
        {
            firebase = new FirebaseClient("https://laboratoriotiaraju-6c89e-default-rtdb.firebaseio.com/");
        }

        public Task<Value> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ItemSAP> GetItemByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
