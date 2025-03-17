using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestTopOrder.Data.Contracts
{
    public interface ICountriesService
    {
        Task<List<CountryDto>> GetCountriesAsync();
    }
}
