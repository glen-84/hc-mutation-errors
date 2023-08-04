using HotChocolate.Authorization;

namespace hc_mutation_errors.Types;

[MutationType]
public static class Mutations
{
    [Authorize(Roles = new[] { "x" })]
    public static long NotAllowed()
    {
        Console.WriteLine("Executed 'NotAllowed' mutation.");

        return 1;
    }

    public static long Allowed()
    {
        Console.WriteLine("Executed 'Allowed' mutation.");

        return 2;
    }
}
