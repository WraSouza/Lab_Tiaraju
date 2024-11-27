using CommunityToolkit.Mvvm.ComponentModel;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.ReadRepositories;
using System.Collections.ObjectModel;

namespace Lab_Tiaraju.ViewModel
{
    public partial class ItemSAPViewModel : ObservableObject
    {
        public ObservableCollection<Value> ItemsSAP { get; set; } = new ObservableCollection<Value>();

        private readonly IReadItemsSAP _readItems;
        public ItemSAPViewModel(IReadItemsSAP readItems)
        {
            _readItems = readItems;

            GetAllItemsAsync();
        }

        async void GetAllItemsAsync()
        {
            ItemsSAP.Add(await _readItems.GetAllItemsAsync());
        }
        
    }
}
