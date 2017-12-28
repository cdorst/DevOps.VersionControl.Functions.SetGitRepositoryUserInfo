using static Common.Functions.WrapStringInDoubleQuotes.StringWrapper;
using static DevOps.VersionControl.Functions.RunGitConfigCommand.GitConfigCommandRunner;

namespace DevOps.VersionControl.Functions.SetGitRepositoryUserInfo
{
    public static class UserInfoSetter
    {
        private const string UserEmail = "user.email";
        private const string UserName = "user.name";

        public static void SetUserInfo(string repositoryDirectory, string username, string email)
        {
            SetEmail(repositoryDirectory, email);
            SetName(repositoryDirectory, username);
        }

        private static void InvokeGitConfig(string directory, string key, string value)
            => Config(directory, key, WrapInDoubleQuotes(value));

        private static void SetEmail(string directory, string value)
            => InvokeGitConfig(directory, UserEmail, value);

        private static void SetName(string directory, string value)
            => InvokeGitConfig(directory, UserName, value);
    }
}
