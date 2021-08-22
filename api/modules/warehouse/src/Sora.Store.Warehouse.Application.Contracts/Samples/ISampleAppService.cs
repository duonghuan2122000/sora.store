using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Sora.Store.Warehouse.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
