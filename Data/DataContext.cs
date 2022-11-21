using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_PA1._2_z3_MVC.Models;

namespace ASP.NET_PA1._2_z3_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_PA1._2_z3_MVC.Models.Miasto>
            Miasta { get; set; } = default!;
    }
}
