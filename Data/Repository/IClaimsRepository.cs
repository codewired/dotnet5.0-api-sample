using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebAPI.Models;

namespace SampleWebAPI.Data.Repository
{
    public interface IClaimsRepository
    {
        List<Claim> GetAllClaims(bool includeMembers);
    }
}
