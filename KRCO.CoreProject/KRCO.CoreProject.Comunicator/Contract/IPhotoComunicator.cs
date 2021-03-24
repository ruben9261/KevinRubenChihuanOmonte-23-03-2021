using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRCO.CoreProject.Model.Model;

namespace KRCO.CoreProject.Comunicator.Contract
{
    public interface IPhotoComunicator
    {
        Task<List<Photo>> GetPhotos(Photo photo);

    }
}
