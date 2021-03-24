using KRCO.CoreProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Business.Contract
{
    public interface IPhotoBusiness
    {
        Task<List<Photo>> getPhotosByAlbumId(int albumId);
    }
}
