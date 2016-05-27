using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class URL
{
    static string parseProtocol(string text, int lastIndex)
    {
        string protocol = text.Substring(0, lastIndex);
        return protocol;
    }
    static string parseServer(string text, int startIndex, int lastIndex)
    {
        lastIndex = lastIndex - startIndex;
        string server = text.Substring(startIndex, lastIndex);
        return server;
    }
    static string parseResource(string text, int startIndex)
    {
        int from = startIndex;
        int lastIndex = text.Length - from;
        string resource = text.Substring(from, lastIndex);
        return resource;
    }
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int protocolServer = text.IndexOf("://");
        int serverResource = text.IndexOf('/', protocolServer + 3);
        string protocol = parseProtocol(text, protocolServer);
        string server = parseServer(text, protocolServer + 3, serverResource);
        string resource = parseResource(text, serverResource);
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
}