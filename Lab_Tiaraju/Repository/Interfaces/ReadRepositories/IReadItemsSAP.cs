using Lab_Tiaraju.Model.Entities;

namespace Lab_Tiaraju.Repository.ReadRepositories
{
    public interface IReadItemsSAP
    {
        Task<Value> GetAllItemsAsync();
        Task<ItemSAP> GetItemByCode(string  code);
    }
}
