using System.Security.Cryptography.X509Certificates;

namespace EMedicine.Web.Model
{
    public class Mediciens
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Manufacture { get; set; }
        public required decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? Descount { get; set; }
        public DateTime ExpDate { get; set; }
        public int Status { get; set; }
       public string? ImgUrl { get; set; }
    }
}
