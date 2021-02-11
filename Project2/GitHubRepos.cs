using System.Collections.Generic;
using System.Threading.Tasks;
using Project1;
using Refit;

namespace Project2
{
    public static class GitHubRepos
    {
        public static async Task<ICollection<Repository>> GetRepositoriesAsync()
        {
            var client = RestService.For<IGitHub>("https://api.github.com");
            return await client.GetRepositoriesAsync("coverlet-coverage");
        }
    }
}
