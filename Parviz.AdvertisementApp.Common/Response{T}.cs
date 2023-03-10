using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Common
{
    public class Response<T> : Response, IResponse<T>
    {
        
        private List<CustomValidationError> customValidationErrors;

        public T Data { get; set; }
        public List<CustomValidationError> Errors { get; set; }


        public Response(ResponseType responseType, string message) : base(responseType, message)
        {

        }

        public Response(ResponseType responseType, T data) : base(responseType)
        {
            Data = data;
        }

        public Response(ResponseType responseType, List<CustomValidationError> customValidationErrors, T data) : base(responseType)
        {
            Data = data;
            Errors = customValidationErrors;
        }

        
    }
}
