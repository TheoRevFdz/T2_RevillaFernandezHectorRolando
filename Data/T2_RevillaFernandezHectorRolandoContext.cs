using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T2_RevillaFernandezHectorRolando.Models;

namespace T2_RevillaFernandezHectorRolando.Data
{
    public class T2_RevillaFernandezHectorRolandoContext : DbContext
    {
        public T2_RevillaFernandezHectorRolandoContext (DbContextOptions<T2_RevillaFernandezHectorRolandoContext> options)
            : base(options)
        {
        }

        public DbSet<T2_RevillaFernandezHectorRolando.Models.Ventas> Ventas { get; set; } = default!;
    }
}
