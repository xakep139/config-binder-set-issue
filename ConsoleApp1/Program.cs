using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        using var host = Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(static (context, services)
                => services.Configure<MyOptions>(context.Configuration.GetSection("MyOptions")))
            .Build();

        var options = host.Services.GetRequiredService<IOptions<MyOptions>>();
        var value = options.Value;
        Console.WriteLine("AssignedSet element count: {0}", value.AssignedSet.Count);
        Console.WriteLine("AssignedHashSet element count: {0}", value.AssignedHashSet.Count);
        Console.WriteLine("NullableHashSet element count: {0}", value.NullableHashSet?.Count);
        Console.WriteLine("AssignedDict element count: {0}", value.AssignedDict.Count);
        Console.WriteLine("NullableDict element count: {0}", value.NullableDict?.Count);
    }
}
