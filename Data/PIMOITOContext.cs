using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIMOITO.Models;

namespace PIMOITO.Data
{
    public class PIMOITOContext : DbContext
    {
        public PIMOITOContext (DbContextOptions<PIMOITOContext> options)
            : base(options)
        {
        }

        public DbSet<PIMOITO.Models.Pessoa> Pessoa { get; set; }
    }
}
