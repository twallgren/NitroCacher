using NitroCacher.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NitroCacher.Plugins
{
    class MemoryCache : ICache
    {
        private static Lazy<ConcurrentDictionary<string, dynamic>> _cache =
            new Lazy<ConcurrentDictionary<string, dynamic>>(() => new ConcurrentDictionary<string, dynamic>());

        private ConcurrentDictionary<string, dynamic> Cache => _cache.Value;

        public void Clear()
        {
            Cache.Clear();
        }

        public void Delete(string key)
        {
            Cache.TryRemove(key, out var ignoredValue);
        }

        public T Get<T>(string key)
        {
            Cache.TryGetValue(key, out var result);
            //File.AppendAllText(@"C:\Temp\nitrolog.txt", $"Pulled this from cache. key:{key} value:{result}\n");
            return result;
        }

        public bool Has(string key)
        {
            //File.AppendAllText(@"C:\Temp\nitrolog.txt", $"Checking cache for key:{key}\n");
            return Cache.ContainsKey(key);
        }

        public void Set<T>(string key, T value)
        {
            //File.AppendAllText(@"C:\Temp\nitrolog.txt", $"Just cached this response. key:{key} value:{value}\n");
            Cache.AddOrUpdate(key, (k) => value, (k, v) => value);
        }
    }
}