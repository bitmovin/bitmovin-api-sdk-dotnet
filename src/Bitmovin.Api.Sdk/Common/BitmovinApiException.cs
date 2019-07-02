using System;
using System.Net;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Common
{
    public class BitmovinApiException : Exception
    {
        public BitmovinApiException(
            string message,
            HttpStatusCode httpStatusCode,
            ResponseError responseError = null,
            Exception innerException = null)
            : base(message, innerException)
        {
            HttpStatusCode = httpStatusCode;
            RequestId = responseError?.RequestId;
            Status = responseError?.Status ?? ResponseStatus.ERROR;
            ErrorData = responseError?.Data;
        }

        public HttpStatusCode HttpStatusCode { get; }
        public string RequestId { get; }
        public ResponseStatus? Status { get; }
        public ResponseErrorData ErrorData { get; }
    }
}
