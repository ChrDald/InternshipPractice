using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class QAPracticeContext : DbContext
    {
        public QAPracticeContext(DbContextOptions<QAPracticeContext> options)
            : base(options)
        { }

        public DbSet<TeamLeader> TeamLeaders { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=QATestDb;Trusted_Connection=True;");
        //}
    }

    public class TeamLeader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TeamId { get; set; }
    }

}
