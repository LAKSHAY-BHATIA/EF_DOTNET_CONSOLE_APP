using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Models
{
   public class ActorDbContext: DbContext
    {
        public DbSet<Actor> Actors { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbcontextOptionBuilder)
        {
            dbcontextOptionBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
