using Flurl.Http;
using Lab_Tiaraju.Helpers;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.Interfaces.ReadRepositories;

namespace Lab_Tiaraju.Repository.Implementations.ReadImplementations
{
    public class ReadSalesMagento : IReadSalesMagento
    {
        public async Task<List<ItemChart>> GetAllSalesAsync()
        {
            try
            {
                var sales = await Constants.urlMagentoOrders
                                .GetJsonAsync<List<ItemChart>>();

                return sales;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
    }
}
