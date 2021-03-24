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
    public class PhotoBusiness : IPhotoBusiness
    {
        private readonly IPhotoComunicator _IPhotoComunicator;
        public PhotoBusiness(IPhotoComunicator IPhotoComunicator)
        {
            _IPhotoComunicator = IPhotoComunicator;
        }

        public async Task<List<Photo>> getPhotosByAlbumId(int albumId)
        {
            var photo = new Photo();
            photo.albumId = albumId;

            return await _IPhotoComunicator.GetPhotos(photo);
        }
    }
}
