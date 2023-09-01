using System.Text.Json.Serialization;

namespace ShıpmentFormAplicationInNetCore.Models
{
    public class OrderShipment
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public long OrderCode { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }
    }
}
