using ShıpmentFormAplicationInNetCore.Models;

namespace ShıpmentFormAplicationInNetCore.Services
{
    public interface IShipmentService
    {
       Task<OrderShipment> AddShipment(OrderShipment shipment);
       Task<List<OrderShipment>> GetAllOrderShipments();
    }
}
