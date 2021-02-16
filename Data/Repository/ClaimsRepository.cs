using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleWebAPI.Models;

namespace SampleWebAPI.Data.Repository
{
    public class ClaimsRepository : IClaimsRepository
    {

        private readonly AppDBContext _ctx;
        private readonly ILogger<ClaimsRepository> _logger;

        public ClaimsRepository(AppDBContext ctx, ILogger<ClaimsRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }


        public List<Claim> GetAllClaims(bool includeMembers)
        {
            if (includeMembers)
            {

                return _ctx.Claims
                           .Include(m => m.Member)
                           .ToList();

            }
            else
            {
                return _ctx.Claims
                           .ToList();
            }
        }

    }
}
