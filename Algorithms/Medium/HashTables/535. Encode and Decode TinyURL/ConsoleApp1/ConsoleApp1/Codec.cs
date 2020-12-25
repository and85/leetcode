using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Codec
    {
        private Dictionary<string, string> _map = new Dictionary<string, string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            string key = "http://tinyurl.com/" + longUrl.GetHashCode().ToString();
            _map.Add(key, longUrl);

            return key;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return _map[shortUrl];
        }
    }
}
