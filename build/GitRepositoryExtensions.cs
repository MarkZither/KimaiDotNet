using Nuke.Common.Git;
using Nuke.Common.Utilities;

public static class GitRepositoryExtensions
{
    public static bool IsOnMainBranch(this GitRepository repository)
    {
        return repository.Branch?.EqualsOrdinalIgnoreCase("main") ?? false;
    }
}