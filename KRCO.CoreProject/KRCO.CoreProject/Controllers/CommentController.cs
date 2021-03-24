using KRCO.CoreProject.Business.Contract;
using KRCO.CoreProject.Model.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentBusiness _ICommentBusiness;

        public CommentController(ICommentBusiness ICommentBusiness)
        {
            _ICommentBusiness = ICommentBusiness;
        }

        [HttpGet]
        public async Task<List<Comment>> getCommentsByPhotoId(int photoId)
        {
            var comments = await _ICommentBusiness.getCommentsByPhotoId(photoId);
            return comments;
        }
    }
}
