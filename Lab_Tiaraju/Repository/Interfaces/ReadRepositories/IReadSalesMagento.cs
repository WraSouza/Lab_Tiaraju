using Lab_Tiaraju.Model.Entities;

namespace Lab_Tiaraju.Repository.Interfaces.ReadRepositories
{
    public interface IReadSalesMagento
    {
        Task<List<ItemChart>> GetAllSalesAsync();
    }
}
