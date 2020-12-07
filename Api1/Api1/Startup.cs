using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Api1.Models;
using Microsoft.AspNetCore.Http;




namespace Api1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Добавляет контекст базы данных в контейнер внедрения зависимостей.
            // Указывает, что контекст базы данных будет использовать базу данных в памяти.
            //services.AddDbContext<TodoContext>(opt =>
            //  opt.UseInMemoryDatabase("TodoList"));
            services.AddDbContext<TodoContext>();
            services.AddControllers();

            //// получаем строку подключения из файла конфигурации
            //string connection = Configuration.GetConnectionString("DefaultConnection");
            //// добавляем контекст MobileContext в качестве сервиса в приложение
            //services.AddDbContext<ApplicationContext>(options =>
            //    options.UseSqlServer(connection));
            ////services.AddControllersWithViews();
            //services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, ILogger<Program> logger2)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //для логирования
          
            loggerFactory.AddFile("logger.txt");
            //var logger = loggerFactory.CreateLogger("FileLogger");
            // хочу добавить категорию <Startup>

            // var logger = loggerFactory.CreateLogger("FileLogger");

            // logger2.LogInformation;


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
