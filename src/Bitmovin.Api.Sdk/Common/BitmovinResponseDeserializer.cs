using System;
using System.Net.Http;
using Bitmovin.Api.Sdk.Models;
using Newtonsoft.Json;
using RestEase;

namespace Bitmovin.Api.Sdk.Common
{
    public class BitmovinResponseDeserializer : ResponseDeserializer
    {
        private readonly JsonSerializerSettings _jsonSettings;

        public BitmovinResponseDeserializer(JsonSerializerSettings jsonSettings)
        {
            _jsonSettings = jsonSettings;
        }

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
