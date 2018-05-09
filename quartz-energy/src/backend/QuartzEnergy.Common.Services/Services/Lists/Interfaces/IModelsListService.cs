namespace QuartzEnergy.Common.Services.Services.Lists.Interfaces
{
    using System.Threading.Tasks;

    using QuartzEnergy.Common.Services.Models.Lists;

    public interface IModelsListService<TRequest>
    {
        Task<ModelsList<TRequest>> GetList(TRequest request);
    }
}
