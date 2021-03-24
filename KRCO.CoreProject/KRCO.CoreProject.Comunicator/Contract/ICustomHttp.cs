using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Comunicator.Contract
{
    public interface ICustomHttp<Request, Response>
    where Request : class
    where Response : class, new()
    {
        Task<Response> GetHttpAsync(Request request, String api);
        Task<Response> PostHttpAsync(Request request, String api);
    }
}
