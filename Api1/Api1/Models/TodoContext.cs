using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Api1.Models
{
    public class TodoContext : DbContext
    {

        //public TodoContext(DbContextOptions<TodoContext> options)
        //    : base(options)
        //{

        //}

        public TodoContext()
            : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DocumentsDB;Trusted_Connection=False;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
