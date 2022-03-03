using System.Collections.Generic;

namespace ConsoleApp1;

public class MyOptions
{
    // This works:
    public ISet<string> AssignedSet { get; set; } = new HashSet<string>();

    // This works:
    public HashSet<string> AssignedHashSet { get; set; } = new HashSet<string>();

    // This works:
    public HashSet<string>? NullableHashSet { get; set; }

    // This causes an exception:
    //public ISet<string>? NullableSet { get; set; }

    // This works:
    public IDictionary<string, HashSet<string>> AssignedDict { get; set; } = new Dictionary<string, HashSet<string>>();

    // This works:
    public IDictionary<string, HashSet<string>>? NullableDict { get; set; }

    // This causes an exception:
    //public IDictionary<string, ISet<string>> AssignedISetDict { get; set; } = new Dictionary<string, ISet<string>>();

    // This causes an exception:
    //public IDictionary<string, ISet<string>>? NullableISetDict { get; set; }
}
