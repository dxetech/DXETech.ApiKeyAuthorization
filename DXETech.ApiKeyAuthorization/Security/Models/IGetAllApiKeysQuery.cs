using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXETech.ApiKeyAuthorization.Security.Models
{
    public interface IGetAllApiKeysQuery
    {
        Task<IReadOnlyDictionary<string, ApiKey>> ExecuteAsync();
    }
}
