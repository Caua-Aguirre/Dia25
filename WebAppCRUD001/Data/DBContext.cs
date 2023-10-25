using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCRUD001.Models;

namespace WebAppCRUD001.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCRUD001.Models.Consulta> Consulta { get; set; } = default!;
    }
}
