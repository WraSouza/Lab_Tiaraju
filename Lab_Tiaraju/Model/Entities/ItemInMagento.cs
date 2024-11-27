namespace Lab_Tiaraju.Model.Entities
{
    public class ItemInMagento
    {
        public string status { get; set; } = string.Empty;
        public int total_qty_ordered { get; set; }
        public List<object> items { get; set; }
        public BillingAddress billing_address { get; set; }
        public object total_paid { get; set; }
        public double base_price { get; set; }
        public double price { get; set; }
        public int qty_ordered { get; set; }
        public double row_invoiced { get; set; }
        public string created_at { get; set; } = string.Empty;
        public string sku { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
    }
}
