using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestEase;

namespace Bitmovin.Api.Sdk.Common
{
    internal class BitmovinQueryParamSerializer : RequestQueryParamSerializer
    {
        public override IEnumerable<KeyValuePair<string, string>> SerializeQueryParam<T>(string name, T value, RequestQueryParamSerializerInfo info)
        {
            var serializedValue = Serialize(value);
            if (serializedValue != null)
            {
                yield return new KeyValuePair<string, string>(name, serializedValue);
            }
        }

        public override IEnumerable<KeyValuePair<string, string>> SerializeQueryCollectionParam<T>(string name, IEnumerable<T> values, RequestQueryParamSerializerInfo info)
        {
            if (values == null)
            {
                yield break;
            }

            foreach (var value in values)
            {
                var serializedValue = Serialize(value);
                if (serializedValue != null)
                {
                    yield return new KeyValuePair<string, string>(name, serializedValue);
                }
            }
        }

        private string Serialize<T>(T value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is DateTime dateTime)
            {
                return dateTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            }

            return value.ToString();
        }
    }
}
