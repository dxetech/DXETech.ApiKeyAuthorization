using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXETech.ApiKeyAuthorization.Security.Models
{
    public class ApiKey
    {
        public string Key { get; }
        public ApiKey(string key)
        {
            Key = key;
        }
    }
}
