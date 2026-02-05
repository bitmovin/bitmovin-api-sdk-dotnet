using System;
using System.Net;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Common
{
    /// <summary>
    /// Exception thrown when a Bitmovin API request fails
    /// </summary>
    public class BitmovinApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the BitmovinApiException class
        /// </summary>
        /// <param name="message">The error message</param>
        /// <param name="httpStatusCode">The HTTP status code</param>
        /// <param name="responseError">The response error details (optional)</param>
        /// <param name="innerException">The inner exception (optional)</param>
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

        /// <summary>
        /// Gets the HTTP status code of the failed request
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; }

        /// <summary>
        /// Gets the request ID from the error response
        /// </summary>
        public string RequestId { get; }

        /// <summary>
        /// Gets the response status from the error response
        /// </summary>
        public ResponseStatus? Status { get; }

        /// <summary>
        /// Gets the error data from the response
        /// </summary>
        public ResponseErrorData ErrorData { get; }
    }
}
