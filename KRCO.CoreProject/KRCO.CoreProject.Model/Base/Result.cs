using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Model.Base
{
    public class Result<T>
    {
        public ResultType Type { get; set; }

        public int Id { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public Result(T data)
        {
            Data = data;
            Type = ResultType.Ok;
            Errors = new List<string>();
        }

        public Result()
        {

        }

        public Result(ResultType type, IEnumerable<string> errors)
        {
            Type = type;
            Errors = errors;
        }

        public Result(ResultType type, string error)
        {
            Type = type;
            Errors = new List<string> { error };
        }
        public Result(ResultType type, int id)
        {
            Type = type;
            Id = id;
        }
        public Result(ResultType type, string error, string message)
        {
            Type = type;
            Errors = new List<string> { error };
            Message = message;
        }
    }
}
 
