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
    public class AlbumComunicator : CustomHttp<Album, List<Album>>, IAlbumComunicator
    {
        public async Task<List<Album>> GetAlbums(Album Album)
        {
            var albums = await GetHttpAsync(Album, Service.AlbumApi);

            return albums;
        }
    }
}
