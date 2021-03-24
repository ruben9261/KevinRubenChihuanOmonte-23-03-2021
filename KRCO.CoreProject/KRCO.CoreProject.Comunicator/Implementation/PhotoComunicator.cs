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
    public class PhotoComunicator : CustomHttp<Photo, List<Photo>>, IPhotoComunicator
    {
        public async Task<List<Photo>> GetPhotos(Photo photo)
        {
            var photos = await GetHttpAsync(photo, Service.PhotosApi);

            return photos;
        }
    }
}
