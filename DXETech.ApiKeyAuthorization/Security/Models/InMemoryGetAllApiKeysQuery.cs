using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXETech.ApiKeyAuthorization.Security.Models
{
    public class InMemoryGetAllApiKeysQuery : IGetAllApiKeysQuery
    {
        public Task<IReadOnlyDictionary<string, ApiKey>> ExecuteAsync()
        {
            var apiKeys = new List<ApiKey>
            {
                new ApiKey("my-secret-key")
            };

            IReadOnlyDictionary<string, ApiKey> readonlyDictionary = apiKeys.ToDictionary(x => x.Key, x => x);
            return Task.FromResult(readonlyDictionary);
        }
    }
}
