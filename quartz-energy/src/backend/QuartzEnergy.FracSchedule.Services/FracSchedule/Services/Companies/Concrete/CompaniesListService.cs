namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Companies.Concrete
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Services.Lists;
    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    public sealed class CompaniesListService
        : IntIdNoRequestListService<CompanyEntity>, ICompaniesListService
    {
        public CompaniesListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}