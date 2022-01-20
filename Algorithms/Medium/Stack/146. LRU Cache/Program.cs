// See https://aka.ms/new-console-template for more information
var cache = new LRUCache(3);
cache.Put(1, 1);
cache.Put(2, 2);
cache.Put(3, 3);
cache.Put(4, 4);
Console.WriteLine(cache.Get(4));
Console.WriteLine(cache.Get(3));
Console.WriteLine(cache.Get(2));
Console.WriteLine(cache.Get(1));
cache.Put(5, 5);
Console.WriteLine(cache.Get(1));
Console.WriteLine(cache.Get(2));
Console.WriteLine(cache.Get(3));
Console.WriteLine(cache.Get(4));
Console.WriteLine(cache.Get(5));

