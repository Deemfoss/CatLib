using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace CatLib.Controllers
{
    public class TinyMceController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public TinyMceController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string data)
        {
            var message = "Hello " + data;
            return Content(message);
        }

        [HttpPost]
        public async Task<string> UploadImg(IFormFile imgfile)
        {
            string message;
            string wwwPath = this._hostingEnvironment.WebRootPath;
            string contentPath = this._hostingEnvironment.ContentRootPath;
            var saveimg = Path.Combine(wwwPath, "Images", imgfile.FileName);
            string imgext = Path.GetExtension(imgfile.FileName);

            if (imgext == ".jpg" || imgext == ".png")
            {
                using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                {

                    await imgfile.CopyToAsync(uploadimg);
                    message = "The selected file" + imgfile.FileName + " is save";
                }

            }
            else
            {
                message = "only JPG and PNG extensions are supported";
            }
            return "filename : " + saveimg + " message :" + message;
        }
    }
}
