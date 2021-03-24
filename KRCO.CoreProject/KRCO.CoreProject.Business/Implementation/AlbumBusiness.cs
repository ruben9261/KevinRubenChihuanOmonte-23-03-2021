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
    public class AlbumBusiness: IAlbumBusiness
    {
        private readonly IAlbumComunicator _IAlbumComunicator;
        public AlbumBusiness(IAlbumComunicator IAlbumComunicator) {
            _IAlbumComunicator = IAlbumComunicator;
        }
        public async Task<List<Album>> getAlbums() {
            return await _IAlbumComunicator.GetAlbums(null);
        }
    }
}
