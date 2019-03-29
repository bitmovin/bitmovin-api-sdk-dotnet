using System;
using System.Net;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Common
{
    public class BitmovinApiException : Exception
    {
        public BitmovinApiException(HttpStatusCode httpStatusCode, ResponseError responseError)
        {
            HttpStatusCode = httpStatusCode;
            RequestId = responseError.RequestId;
            Status = responseError.Status;
            ErrorData = responseError.Data;
        }
        
        public HttpStatusCode HttpStatusCode { get; }
        public string RequestId { get; }
        public ResponseStatus Status { get; }
        public ResponseErrorData ErrorData { get; }
    }
}
