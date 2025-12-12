using System;
using System.Collections.Concurrent;

namespace Singleton_DesignPattern
{
    public sealed class CacheManager
    {
        private static readonly Lazy<CacheManager> _instance =
            new Lazy<CacheManager>(() => new CacheManager());
        public static CacheManager Instance => _instance.Value;

        private readonly ConcurrentDictionary<string, object> _cache;

        // Private constructor
        private CacheManager()
        {
            _cache = new ConcurrentDictionary<string, object>();
            Console.WriteLine("CacheManager initialized.");
        }  

        public void Set(string key, object value)
        {
            _cache[key] = value;
            Console.WriteLine($"Cache SET: {key} = {value}");
        }

        public object? Get(string key)
        {
            _cache.TryGetValue(key, out var value);
            Console.WriteLine($"Cache GET: {key} = {value}");
            return value;
        }

        public bool Remove(string key)
        {
            return _cache.TryRemove(key, out _);
        }
    }
}