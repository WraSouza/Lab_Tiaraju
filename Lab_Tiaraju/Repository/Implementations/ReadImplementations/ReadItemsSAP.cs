using Firebase.Database;
using Flurl;
using Flurl.Http;
using Lab_Tiaraju.Helpers;
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

        public async Task<ItemSAP> GetAllItemsAsync(string skipValue)
        {
            //throw new NotImplementedException();
            try
            {
                //return await Constants.urlSapItens
                //                .SetQueryParam("id",skipValue)
                //                .GetJsonAsync<ItemSAP>();

                var skipDTO = new { skip =  skipValue };

                var responde = await Constants.urlSapItens
                                        .PostJsonAsync(skipDTO)
                                        .ReceiveJson<ItemSAP>();

                return responde;

            }
            catch (FlurlHttpTimeoutException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        public Task<ItemSAP> GetItemByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
