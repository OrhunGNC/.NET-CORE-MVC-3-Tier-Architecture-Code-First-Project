using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coreModel.Model;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace coreData.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }
        public DbSet<Kid> Kids { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Taskks> Taskkss { get; set; }
        public DbSet<Titles> Title { get; set; }
        public DbSet<Units> Unit { get; set; }

    }
}
