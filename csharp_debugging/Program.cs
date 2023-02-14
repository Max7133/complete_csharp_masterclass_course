// The friends with the shortest name will be displayed in the Output

var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };

// This Method needs a List and the amount of people that it should Select from that List 
var partyFriends = GetPartyFriends(friends, 3); // it will get 3 Friends

// Writes down the Names of those people 
foreach(var name in partyFriends)
{
    Console.WriteLine(name);
}

/// <summary>
/// This is the logic to figure out who is in a partyFriends list
/// </summary>
/// <param name="list"></param>
/// <returns></returns>
// This Method returns the List of all the people with short Names up to a certaint amount that I can pass (I passed 3) 
static List<string> GetPartyFriends(List<string> list, int count)
{
    if(list == null)
        throw new ArgumentNullException("List", "The list is empty");

    // the List that was passed
    if(count > list.Count || count <= 0)
        throw new ArgumentOutOfRangeException("count", "Count cannot be greater than the elements in the list or lower 0");

    // Initially EMPTY partyFriends List
    var partyFriends = new List<string>();

    // Copy of the List, so I won't remove from the List itself
    var buffer = new List<string>();

    // As long as partyFriends List has a lower count, then the Number that was passed, it checks for the next partyFriend
    while(partyFriends.Count < count)
    {
        var currentFriend = GetPartyFriend(buffer);
        partyFriends.Add(currentFriend); // Add that to the partyFrineds List

        // Don't do this in real life project!
        buffer.Remove(currentFriend); // And remove from the list that wass passed to us
    }
    return partyFriends;
}

// Decides which 3 name are the shortest
static string GetPartyFriend(List<string> list)
{
    string shortestName = list[0];
    // Checks for the shortest name and compares it
    for (var i = 0; i < list.Count; i++)
    {
        if (list[i].Length < shortestName.Length)
        {
            shortestName = list[i];
        }
    }
    return shortestName;
}

// Debug/Windows/Autos - shows the Variables that are surrounding the Breakpoint (for e.g. names of friends)

// Debug/Windows/Locals - shows the Variable that are available in the Local Context so in the Scope that we're currently looking at

// Autos window is a subset of the Lcals window. When the Local windows shows all the variable with in current scope, the Autos shows only the current and previously executed object’s value.

// Debug/Windows/Watch - the debugger watches a variable through the content of a storage address, computed at the time the watch condition is set.
// when the content at the storage address is changed from the value it had when the watch condition was set or when the last watch condition occurred, a breakpoint is set, and the program stops.