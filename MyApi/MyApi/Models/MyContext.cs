using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//Контекст базы данных  —это основной класс, который координирует
//функциональные возможности Entity Framework для модели данных.
namespace MyApi.Models
{
    public class MyContext: DbContext// наследуется от DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public DbSet<MyItem> TodoItems { get; set; }
    }
}
