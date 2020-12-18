using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Api1.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace Api1.Controllers
{

    [Route("Upload")]
    [ApiController]
    public class FileController : Controller
    {
        FilesContext _context;
        IWebHostEnvironment _appEnvironment;

        public FileController(FilesContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.Files.ToList());
        }

        //string path = _appEnvironment.ContentRootPath + "\\Files\\" + uploadedFile.FileName;
        // return CreatedAtAction("Get new file", uploadedFile);
        [HttpPost]
        //Все загружаемые файлы в ASP.NET Core представлены типом IFormFile из пространства
        //имен Microsoft.AspNetCore.Http.
        
       
        public async Task<IActionResult> AddFile(IFormFile uploadedFile, CategoryDTO category)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                // using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                using (var fileStream = new FileStream(_appEnvironment.ContentRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                _context.Files.Add(file);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}