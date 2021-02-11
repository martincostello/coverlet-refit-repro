using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace Project1
{
    [Headers("User-Agent: RefitRepro")]
    public interface IGitHub
    {
        [Get("/orgs/{organization}/repos?per_page={count}")]
        Task<ICollection<Repository>> GetRepositoriesAsync(string organization, int? count = null);
    }
}
