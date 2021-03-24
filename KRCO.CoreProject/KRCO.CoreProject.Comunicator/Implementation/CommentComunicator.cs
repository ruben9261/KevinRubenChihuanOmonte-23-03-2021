using KRCO.CoreProject.Comunicator.Contract;
using KRCO.CoreProject.Constant;
using KRCO.CoreProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Comunicator.Implementation
{
    public class CommentComunicator : CustomHttp<Comment, List<Comment>>, ICommentComunicator
    {
        public async Task<List<Comment>> GetComments(Comment comment)
        {
            var comments = await GetHttpAsync(comment, Service.CommentsApi);

            return comments;
        }
    }
}
