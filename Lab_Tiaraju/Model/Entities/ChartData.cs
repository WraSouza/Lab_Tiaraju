namespace Lab_Tiaraju.Model.Entities
{
    public class ChartData
    {
        public ChartData(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; private set; } = string.Empty;
        public int Quantity { get; private set; }
    }
}
