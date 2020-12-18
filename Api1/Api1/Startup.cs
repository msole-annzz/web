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
// ���� ��� ��������� swagger
using System;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;//��� ������������� � ������ OpenApiInfo
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Text.Json.Serialization;

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
            //��������� �������� ���� ������ � ��������� ��������� ������������.
            // ���������, ��� �������� ���� ������ ����� ������������ ���� ������ � ������.
            services.AddDbContext<TodoContext>(opt =>
              opt.UseInMemoryDatabase("TodoList"));
            services.AddDbContext<FilesContext>(opt =>
             opt.UseInMemoryDatabase("FilesList"));
            //������������ Enum � Json, ��������� ����� �� �������� � cswagger ������������ ��������� �������, � �� �������
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

            //���������� swagger
            //�������� �� ���������, ������������ � ����� AddSwaggerGen, 
            //����� ������������ ��� ���������� ����� ��������, ��� �����, 
            //�������� � ��������
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Api1",
                    Description = "It's my first API ",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Olga",
                        Email = "annzz@yandex.ru",
                        //Email = string.Empty,
                        //Url = new Uri("https://twitter.com/spboyer"),
                    },
                    //License = new OpenApiLicense
                    //{
                    //    Name = "Use under LICX",
                    //    Url = new Uri("https://example.com/license"),
                    //}
                });
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //��� �����������
          
            loggerFactory.AddFile("logger.txt");
            //var logger = loggerFactory.CreateLogger("FileLogger");

            // ��� ������������ ���������� ��������� JSON � ����������������� ���������� Swagger.
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                //����� ������������ ���������������� ��������� Swagger � �������� 
                //�������� ���������� (http://localhost:<port>/)
                c.RoutePrefix = string.Empty;
            });

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
