namespace Ett.Common.Services.Services.Lists.Interfaces
{
    using System.Threading.Tasks;

    using Ett.Common.Services.Models.Lists;

    public interface IModelsListService<TRequest>
    {
        Task<ModelsList<TRequest>> GetList(TRequest request);
    }
}
