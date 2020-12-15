using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using File1.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace FileUploadApp.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext _context;
        IWebHostEnvironment _appEnvironment;

        public HomeController(ApplicationContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            _context.Files.Load();
            return View(_context.Files.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))//using чистит выделенную память, выделенную
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                _context.Files.Add(file);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public async Task<IActionResult> AddFile(IFormFileCollection uploads)
        //{
        //    foreach (var uploadedFile in uploads)
         //   {
                // путь к папке Files
           //     string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
           //     using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            //    {
            //        await uploadedFile.CopyToAsync(fileStream);
            //    }
           //     FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
           //     _context.Files.Add(file);
           // }
           // _context.SaveChanges();

        //    return RedirectToAction("Index");
       // }
    }
}