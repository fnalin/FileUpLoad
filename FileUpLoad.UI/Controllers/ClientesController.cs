using FileUpLoad.Data.EF;
using FileUpLoad.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpLoad.UI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly CadClienteDataContext _ctx;
        private IHostingEnvironment _env;

        public ClientesController(CadClienteDataContext ctx, IHostingEnvironment env)
        {
            _ctx = ctx;
            _env = env;
        }

        public IActionResult Folder()
        {
            string webRootPath = _env.WebRootPath;
            string contentRootPath = _env.ContentRootPath;

            return Content(webRootPath + "\n" + contentRootPath);
        }

        public async Task<IActionResult> Index()
        {
            var model = await _ctx.Clientes.ToListAsync();
            //foreach (var cliente in model)
            //{
            //    if (!string.IsNullOrEmpty(cliente.UrlFoto))
            //    {
            //        byte[] imageArray = System.IO.File.ReadAllBytes(cliente.);
            //        foto = Convert.ToBase64String(imageArray);
            //    }
            //}
            return View(model);
        }

        public IActionResult Add() => View();

        public async Task<IActionResult> Save(IFormFile file, Cliente cliente)
        {
            if (file.Length > 0)
            {

                cliente.UrlFoto = $@"{_env.ContentRootPath}\files\{file.FileName}";
                _ctx.Clientes.Add(cliente);
                using (var stream = new FileStream(cliente.UrlFoto, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                await _ctx.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}
