using KRCO.CoreProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Business.Contract
{
    public interface ICommentBusiness
    {
        Task<List<Comment>> getCommentsByPhotoId(int photoId);
    }
}
