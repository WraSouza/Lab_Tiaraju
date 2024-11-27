namespace Lab_Tiaraju.Model.Entities
{
    public class BillingAddress
    {
        public string city { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string postcode { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;
        public string region_code { get; set; } = string.Empty;
        public List<object> street { get; set; } = [];
        public string telephone { get; set; } = string.Empty;
        public string vat_id { get; set; } = string.Empty;
    }
}
