using CommunityToolkit.Mvvm.ComponentModel;
using Lab_Tiaraju.Model.Entities;
using Lab_Tiaraju.Repository.Interfaces.ReadRepositories;
using System.Collections.ObjectModel;


namespace Lab_Tiaraju.ViewModel
{
    public partial class LojaVirtualViewModel : ObservableObject
    {
        [ObservableProperty]
        string? maisVendido = string.Empty;

        [ObservableProperty]
        string menosVendido;

        public ObservableCollection<ChartData> DatasFromMagento { get; set; } = new();

        public ObservableCollection<ChartData> ItensMenosVdendidos { get; set; } = new();

        List<ChartData> newChartData = [];

        private readonly IReadSalesMagento _salesMagento;
        public LojaVirtualViewModel(IReadSalesMagento salesMagento)
        {
            _salesMagento = salesMagento;

        }

        internal async Task GetMagentoSales()
        {
            int quantidade = 0;

            List<string> itemsName = [];

            var allSales = await _salesMagento.GetAllSalesAsync();

            for (int i = 0; i < allSales.Count; i++)
            {
                for (int j = 0; j < allSales[i].items.Count; j++)
                {
                    if (!itemsName.Contains(allSales[i].items[j].name) && allSales[i].items[j].name != "")
                    {
                        itemsName.Add(allSales[i].items[j].name);
                    }
                }

            }

            for (int i = 0; i < itemsName.Count; i++)
            {
                for (int j = 0; j < allSales.Count; j++)
                {
                    for (int z = 0; z < allSales[j].items.Count; z++)
                    {
                        if (itemsName[i].Equals(allSales[j].items[z].name))
                        {
                            quantidade = quantidade + allSales[j].items[z].qty_ordered;
                        }
                    }

                }

                ChartData chartData = new(itemsName[i], quantidade);

                newChartData.Add(chartData);

               // DatasFromMagento.Add(chartData);

                quantidade = 0;
            }

            List<ChartData> sortedList = newChartData.OrderByDescending(x => x.Quantity).ToList();

            for(int i = 0; i < 10; i++)
            {
                ChartData chartData = new(sortedList[i].Name, sortedList[i].Quantity);

                DatasFromMagento.Add(chartData);
            }

            for(int i = sortedList.Count; i > sortedList.Count - 10; i--)
            {
                ChartData chartData = new(sortedList[i-1].Name, sortedList[i-1].Quantity);

                ItensMenosVdendidos.Add(chartData);
            }

            maisVendido = newChartData[0].Name;

            int indiceMaximo = newChartData.Count;

            menosVendido = newChartData[indiceMaximo - 1].Name;
        }            

        
    }
}
