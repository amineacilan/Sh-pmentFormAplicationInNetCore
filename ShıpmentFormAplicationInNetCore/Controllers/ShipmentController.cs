using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShıpmentFormAplicationInNetCore.Models;
using ShıpmentFormAplicationInNetCore.Services;

namespace ShıpmentFormAplicationInNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private IShipmentService _shipmentService;
        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderShipment>>> GetShipments()
        {

            return await _shipmentService.GetAllOrderShipments();
        }


        [HttpPost]
        public async Task<ActionResult<OrderShipment>> PostShipment(OrderShipment orderShipment)
        {
            try
            {
                var shipment = _shipmentService.AddShipment(orderShipment);
                return Ok(shipment);
            }
            catch (Exception)
            {

                return NotFound();

            }
        }
     
    }
}
