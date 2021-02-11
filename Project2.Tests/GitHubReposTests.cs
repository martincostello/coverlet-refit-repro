using System.Threading.Tasks;
using Xunit;

namespace Project2.Tests
{
    public static class GitHubReposTests
    {
        [Fact]
        public static async Task Can_Get_Repositories()
        {
            var actual = await GitHubRepos.GetRepositoriesAsync();

            Assert.NotNull(actual);
            Assert.NotEqual(0, actual.Count);
        }
    }
}
