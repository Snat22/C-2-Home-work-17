using System;
using System.Collections.Generic;

public static class Cache<T>
{
     static Dictionary<string, T> cache = new Dictionary<string, T>();

    public static void Add(string key, T item)
    {
        if (!cache.ContainsKey(key))
        {
            cache.Add(key, item);
        }
        else
        {
            Console.WriteLine("Элемент с таким ключом уже существует в кэше.");
        }
    }

    public static T Get(string key)
    {
        if (cache.ContainsKey(key))
        {
            return cache[key];
        }
        else
        {
            Console.WriteLine("Элемент с указанным ключом отсутствует в кэше.");
            return default;
        }
    }

    public static void Remove(string key)
    {
        if (cache.ContainsKey(key))
        {
            cache.Remove(key);
        }
        else
        {
            Console.WriteLine("Элемент с указанным ключом отсутствует в кэше.");
        }
    }
}
