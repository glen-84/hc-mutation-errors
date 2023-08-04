# hc-mutation-errors

- `dotnet watch --no-hot-reload`
- Run GraphQL operation:
    ```gql
    mutation Example {
        notAllowed {
            long
        }

        allowed {
            long
        }
    }
    ```
- Check the console, and find `Executed 'Allowed' mutation.`.
- The allowed mutation is executed, but the return value is not included in the response data.

Note that my application also:

- Uses `[ID]` on the mutations.
- Returns `Task`s.
- Uses `AddQueryFieldToMutationPayloads`.

But this should be enough to show the general issue.
