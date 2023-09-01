using Microsoft.EntityFrameworkCore;
using ShıpmentFormAplicationInNetCore.Models;

namespace ShıpmentFormAplicationInNetCore.Services
{
    public class ShipmentService:IShipmentService
    {

        private readonly OrderShipmentContext _dbContext;
        public ShipmentService(OrderShipmentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderShipment> AddShipment(OrderShipment shipment)
        {
            _dbContext.OrderShipment.Add(shipment);
            await _dbContext.SaveChangesAsync();
            return shipment;
        }

        public async Task<List<OrderShipment>> GetAllOrderShipments()     
        {
            var shipments = await _dbContext.OrderShipment.ToListAsync();
            return shipments;
        }

    }
}
