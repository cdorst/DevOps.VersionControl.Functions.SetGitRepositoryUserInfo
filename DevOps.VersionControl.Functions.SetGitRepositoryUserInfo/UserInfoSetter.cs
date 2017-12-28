using static DevOps.VersionControl.Functions.RunGitConfigCommand.GitConfigCommandRunner;

namespace DevOps.VersionControl.Functions.SetGitRepositoryUserInfo
{
    public static class UserInfoSetter
    {
        private const string UserEmail = "user.email";
        private const string UserName = "user.name";

        public static void SetUserInfo(string repositoryDirectory, string username, string email)
        {
            Config(repositoryDirectory, UserEmail, email);
            Config(repositoryDirectory, UserName, username);
        }
    }
}
