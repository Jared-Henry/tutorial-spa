using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Api
{
    [Route("api/[controller]")]
    public class ThingsController : Controller
    {
        public AppDbContext Db { get; set; }
        public ThingsController(AppDbContext db)
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
