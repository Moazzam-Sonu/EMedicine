namespace EMedicine.Web.Model
{
    public class Orders
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string OrderId { get; set; }
        public decimal TotalOrder { get; set; }
        public string OrderStatus { get; set; }
    }
}
