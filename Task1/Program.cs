

        Cache<int>.Add("key1", 10);
        Cache<string>.Add("key2", "Hello");

        int cachedInt = Cache<int>.Get("key1");
        Console.WriteLine($"Cached int value: {cachedInt}");
        
        int cachedInt1 = Cache<int>.Get("key1");
        Console.WriteLine($"Cached int value: {cachedInt1}");

        string cachedString = Cache<string>.Get("key2");
        Console.WriteLine($"Cached string value: {cachedString}");
        
        string cachedString1 = Cache<string>.Get("key3");
        Console.WriteLine($"Cached string value: {cachedString1}");

        Cache<int>.Remove("key1");
        int removedInt = Cache<int>.Get("key1");
        Console.WriteLine($"Removed int value: {removedInt}");
