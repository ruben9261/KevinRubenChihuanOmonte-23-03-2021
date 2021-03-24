using KRCO.CoreProject.Business.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoBusiness _IPhotoBusiness;

        public PhotoController(IPhotoBusiness IPhotoBusiness)
        {
            _IPhotoBusiness = IPhotoBusiness;
        }
        public async Task<IActionResult> Index(int id)
        {
            var photos = await _IPhotoBusiness.getPhotosByAlbumId(id);
            return View(photos);
        }
    }
}
