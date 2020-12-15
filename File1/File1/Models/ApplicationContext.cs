﻿using Microsoft.EntityFrameworkCore;

namespace File1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        
        {
            Database.EnsureCreated();
        }
    }
}