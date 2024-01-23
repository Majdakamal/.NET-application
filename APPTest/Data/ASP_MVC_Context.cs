using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APPTest.Data
{
    public class ASP_MVC_Context : DbContext
    {
        public ASP_MVC_Context (DbContextOptions<ASP_MVC_Context> options)
            : base(options)
        {
        }

        public DbSet<APPTest.Models.Produit> Pottery { get; set; } = default!;
    }
}
