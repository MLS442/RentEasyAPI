using Microsoft.AspNetCore.Mvc;
using RentEasyAPI.Models;
using System.Runtime.Intrinsics.X86;

namespace RentEasyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TenantsController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<Tenant>> GetTenants()
        {
            var list = new List<Tenant>
            {
                new Tenant { Id = 1, FullName = "Stranger", Address = "222 Anywhere", Phone = "111-111-1111", Email = "stranger@email.test", BirthDate = new DateOnly(1914, 04, 04) },
                new Tenant { Id = 2, FullName = "Alice Johnson", Address = "123 Maple St", Phone = "555-0101", Email = "alice.johnson@email.test", BirthDate = new DateOnly(1985, 05, 12) },
                new Tenant { Id = 3, FullName = "Bob Smith", Address = "456 Oak Ave", Phone = "555-0102", Email = "bob.smith@email.test", BirthDate = new DateOnly(1990, 08, 23) },
                new Tenant { Id = 4, FullName = "Charlie Davis", Address = "789 Pine Rd", Phone = "555-0103", Email = "charlie.davis@email.test", BirthDate = new DateOnly(1978, 11, 30) },
                new Tenant { Id = 5, FullName = "Diana Prince", Address = "101 Amazon Way", Phone = "555-0104", Email = "diana.prince@email.test", BirthDate = new DateOnly(1982, 01, 15) },
                new Tenant { Id = 6, FullName = "Edward Norton", Address = "202 Birch Ln", Phone = "555-0105", Email = "edward.norton@email.test", BirthDate = new DateOnly(1995, 03, 22) },
                new Tenant { Id = 7, FullName = "Fiona Gallagher", Address = "303 Cedar Blvd", Phone = "555-0106", Email = "fiona.gallagher@email.test", BirthDate = new DateOnly(1988, 07, 09) },
                new Tenant { Id = 8, FullName = "George Miller", Address = "404 Elm St", Phone = "555-0107", Email = "george.miller@email.test", BirthDate = new DateOnly(1972, 12, 14) },
                new Tenant { Id = 9, FullName = "Hannah Abbott", Address = "505 Willow Dr", Phone = "555-0108", Email = "hannah.abbott@email.test", BirthDate = new DateOnly(1992, 06, 18) },
                new Tenant { Id = 10, FullName = "Ian Wright", Address = "606 Spruce Ct", Phone = "555-0109", Email = "ian.wright@email.test", BirthDate = new DateOnly(1980, 09, 05) },
                new Tenant { Id = 11, FullName = "Jenny Kim", Address = "707 Aspen Pl", Phone = "555-0110", Email = "jenny.kim@email.test", BirthDate = new DateOnly(1998, 02, 27) },
                new Tenant { Id = 12, FullName = "Kevin Hart", Address = "808 Cherry Cir", Phone = "555-0111", Email = "kevin.hart@email.test", BirthDate = new DateOnly(1979, 07, 06) },
                new Tenant { Id = 13, FullName = "Laura Palmer", Address = "909 Twin Peaks", Phone = "555-0112", Email = "laura.palmer@email.test", BirthDate = new DateOnly(1991, 10, 10) },
                new Tenant { Id = 14, FullName = "Michael Scott", Address = "1725 Slough Ave", Phone = "555-0113", Email = "michael.scott@email.test", BirthDate = new DateOnly(1965, 03, 15) },
                new Tenant { Id = 15, FullName = "Nina Simone", Address = "111 Jazz Way", Phone = "555-0114", Email = "nina.simone@email.test", BirthDate = new DateOnly(1933, 02, 21) }
    

            };

            return Ok(list);
        }
    }
}

