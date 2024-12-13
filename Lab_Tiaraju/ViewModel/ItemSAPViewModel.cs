using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.ReadRepositories;
using System.Collections.ObjectModel;

namespace Lab_Tiaraju.ViewModel
{
    public partial class ItemSAPViewModel : ObservableObject
    {
        private readonly string amostra = "AMOSTRA PARA ANÁLISE";
        private int _pageSize = 20;
        private int initialSkipIndex = 0;

        public ObservableCollection<Value> ItemsSAP { get; set; } = new ObservableCollection<Value>();

        [ObservableProperty]
        bool isBusy;

        [ObservableProperty]
        bool isLoading;

        private readonly IReadItemsSAP _readItems;
        public ItemSAPViewModel(IReadItemsSAP readItems)
        {
            _readItems = readItems;            
        }

        [RelayCommand]
        public async Task LoadMoreData()
        {            

            if (isLoading)
                return;

            isLoading = true;

            var items = await _readItems.GetAllItemsAsync(initialSkipIndex.ToString());            

            for (int i = 0; i < items.value.Count; i++)
            {
                if (items.value[i].ItemName != amostra)
                {
                    Value newItem = new Value(items.value[i].ItemCode, items.value[i].ItemName, items.value[i].BarCode, items.value[i].QuantityOnStock);
                    ItemsSAP.Add(newItem);
                }
            }

            isLoading = false;

            initialSkipIndex += 20;
        }

        [RelayCommand]
        internal async Task GetAllItemsAsync()
        {
            int initialIndex = 0;
            IsBusy = true;

            ItemsSAP.Clear();
            var items = await _readItems.GetAllItemsAsync(initialIndex.ToString());   
            
            if(items.value.Count > 0)
            {
                Shell.Current.Dispatcher.Dispatch(() =>
                {
                    var recordsToBeAdded = items.value.Take(_pageSize).ToList();

                    for (int i = 0; i < recordsToBeAdded.Count; i++)
                    {
                        if (items.value[i].ItemName != amostra)
                        {
                            Value newItem = new Value(items.value[i].ItemCode, items.value[i].ItemName, items.value[i].BarCode, items.value[i].QuantityOnStock);
                            ItemsSAP.Add(newItem);
                        }
                    }
                });
            }
           

            //for (int i = 0; i < items.value.Count; i++)
            //{
            //    if(items.value[i].ItemName != amostra)
            //    {
            //       

            //        Value newItem = new Value(items.value[i].ItemCode, items.value[i].ItemName, items.value[i].BarCode, items.value[i].QuantityOnStock);
            //        ItemsSAP.Add(newItem);
            //    }
               
            //}

            IsBusy = false;
           
        }
        
    }
}
