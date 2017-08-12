using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Api
{
    [Route("api/things")]
    public class ThingController : Controller
    {
        public AppDbContext Db { get; set; }
        public ThingController(AppDbContext db)
        {
            this.Db = db;
        }

        [HttpGet]
        public Task<Thing[]> GetAll(CancellationToken cancellationToken)
        {
            return Db.Things.ToArrayAsync(cancellationToken);
        }
    }
}
