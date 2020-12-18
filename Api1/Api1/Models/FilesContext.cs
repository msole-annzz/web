using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api1.Models
{
    public class FilesContext : DbContext
    {
        public FilesContext(DbContextOptions<FilesContext> options)
            : base(options)
        {
        }
        //для файлов
        public DbSet<FileModel> Files { get; set; }
    }
}
