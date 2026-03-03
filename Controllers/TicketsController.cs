using Microsoft.AspNetCore.Mvc;
using RentEasyAPI.Models;

namespace RentEasyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Ticket>> GetTickets() 
        {
            var mockTickets = new List<Ticket> {
                new Ticket { TicketId = 1, TenantId = 1, Subject = "Heating", Description = "Radiator making loud clicking noises", Status = "Not Fixed" },
                new Ticket { TicketId = 2, TenantId = 2, Subject = "Kitchen", Description = "The sink has a problem", Status = "Not Fixed" },
                new Ticket { TicketId = 3, TenantId = 1, Subject = "Electrical", Description = "Flickering lights in the hallway", Status = "In Progress" },
                new Ticket { TicketId = 4, TenantId = 3, Subject = "Security", Description = "Front door lock is sticking", Status = "Fixed" },
                new Ticket { TicketId = 5, TenantId = 2, Subject = "Plumbing", Description = "Toilet constantly running", Status = "Not Fixed" },
                new Ticket { TicketId = 6, TenantId = 4, Subject = "Windows", Description = "Draft coming from bedroom window", Status = "Not Fixed" },
                new Ticket { TicketId = 7, TenantId = 1, Subject = "Pest Control", Description = "Ants found in pantry", Status = "In Progress" },
                new Ticket { TicketId = 8, TenantId = 5, Subject = "Flooring", Description = "Loose floorboard in living room", Status = "Fixed" },
                new Ticket { TicketId = 9, TenantId = 3, Subject = "Appliances", Description = "Oven door handle is loose", Status = "Not Fixed" },
                new Ticket { TicketId = 10, TenantId = 2, Subject = "Bathroom", Description = "Shower head has low pressure", Status = "In Progress" },
                new Ticket { TicketId = 11, TenantId = 6, Subject = "Paint", Description = "Water stain on ceiling", Status = "Not Fixed" },
                new Ticket { TicketId = 12, TenantId = 4, Subject = "HVAC", Description = "AC unit blowing warm air", Status = "Fixed" },
                new Ticket { TicketId = 13, TenantId = 1, Subject = "Exterior", Description = "Gutter is overflowing", Status = "Not Fixed" },
                new Ticket { TicketId = 14, TenantId = 7, Subject = "Intercom", Description = "Buzzer not notifying phone", Status = "In Progress" },
                new Ticket { TicketId = 15, TenantId = 5, Subject = "Kitchen", Description = "Dishwasher leaking from bottom", Status = "Not Fixed" },
                new Ticket { TicketId = 16, TenantId = 2, Subject = "Lighting", Description = "Outdoor patio light is out", Status = "Fixed" },
                new Ticket { TicketId = 17, TenantId = 8, Subject = "Common Area", Description = "Elevator making grinding noise", Status = "Not Fixed" },
                new Ticket { TicketId = 18, TenantId = 3, Subject = "Plumbing", Description = "Low hot water duration", Status = "In Progress" },
                new Ticket { TicketId = 19, TenantId = 9, Subject = "Safety", Description = "Smoke detector chirping", Status = "Fixed" },
                new Ticket { TicketId = 20, TenantId = 4, Subject = "Trash", Description = "Compactor area is blocked", Status = "Not Fixed" },
                new Ticket { TicketId = 21, TenantId = 6, Subject = "Kitchen", Description = "Refrigerator door seal broken", Status = "In Progress" },
                new Ticket { TicketId = 22, TenantId = 1, Subject = "Electrical", Description = "Outlet in kitchen sparked", Status = "Not Fixed" },
                new Ticket { TicketId = 23, TenantId = 7, Subject = "Windows", Description = "Broken screen on balcony door", Status = "Fixed" },
                new Ticket { TicketId = 24, TenantId = 10, Subject = "Plumbing", Description = "Slow drain in bathtub", Status = "Not Fixed" }
            };

            return Ok(mockTickets);
        }
    }
}
