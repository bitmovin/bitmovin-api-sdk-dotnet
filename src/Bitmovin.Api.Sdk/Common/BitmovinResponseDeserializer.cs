using System;
using System.Net.Http;
using Bitmovin.Api.Sdk.Models;
using Newtonsoft.Json;
using RestEase;

namespace Bitmovin.Api.Sdk.Common
{
    /// <summary>
    /// Custom response deserializer for Bitmovin API responses
    /// </summary>
    public class BitmovinResponseDeserializer : ResponseDeserializer
    {
        private readonly JsonSerializerSettings _jsonSettings;

        /// <summary>
        /// Initializes a new instance of the BitmovinResponseDeserializer class
        /// </summary>
        /// <param name="jsonSettings">The JSON serializer settings</param>
        public BitmovinResponseDeserializer(JsonSerializerSettings jsonSettings)
        {
            _jsonSettings = jsonSettings;
        }

        /// <summary>
        /// Deserializes the HTTP response content
        /// </summary>
        /// <typeparam name="T">The type to deserialize to</typeparam>
        /// <param name="content">The response content string</param>
        /// <param name="response">The HTTP response message</param>
        /// <param name="info">The response deserializer info</param>
        /// <returns>The deserialized object</returns>
        public override T Deserialize<T>(string content, HttpResponseMessage response, ResponseDeserializerInfo info)
        {
            try
            {
                var responseEnvelope = JsonConvert.DeserializeObject<ResponseEnvelope<T>>(content, _jsonSettings);
                return responseEnvelope.Data.Result;
            }
            catch (Exception e)
            {
                throw new BitmovinApiException("Error when deserializing response", response.StatusCode, null, e);
            }
        }
    }
}
