using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApiAvancevscContext : DbContext
    {
        public ApiAvancevscContext(DbContextOptions<ApiAvancevscContext> options) : base(options)
        {
            
        }
    }
}