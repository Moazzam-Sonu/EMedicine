namespace EMedicine.Web.Model
{
    public class Respose
    {
        public string StatusMessage { get; set; }
        public int StatusCode { get; set; }
        public List<Users> listUsers { get; set; }
        public Users user { get; set; }
        public List<Mediciens> listMediciens { get; set; }
        public Mediciens medicien { get; set; }
        public List<Orders> listOrders { get; set; }
        public Orders order { get; set; }
        public List<OrderItems> listOrderItems { get; set; }
        public OrderItems orderItem { get; set; }

    }
}
