using KRCO.CoreProject.Business.Contract;
using KRCO.CoreProject.Comunicator.Contract;
using KRCO.CoreProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Business.Implementation
{
    public class CommentBusiness : ICommentBusiness
    {
        private readonly ICommentComunicator _ICommentComunicator;
        public CommentBusiness(ICommentComunicator ICommentComunicator)
        {
            _ICommentComunicator = ICommentComunicator;
        }

        public async Task<List<Comment>> getCommentsByPhotoId(int photoId)
        {
            var comment = new Comment();
            comment.postId = photoId;

            return await _ICommentComunicator.GetComments(comment);
        }
    }
}
