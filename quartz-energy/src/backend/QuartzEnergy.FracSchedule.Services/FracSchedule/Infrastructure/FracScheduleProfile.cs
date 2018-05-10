namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Infrastructure
{
    using AutoMapper;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Entity;

    public class FracScheduleProfile : Profile
    {
        public FracScheduleProfile()
        {
            // Entities
            this.CreateMap<ScheduleEntity, Schedule>()
                .ConstructUsing(e => new Schedule(
                    e.Id, 
                    e.WellId, 
                    e.CompanyId, 
                    e.FracStartDate, 
                    e.FracEndDate,
                    e.CreatedDate))
               .ReverseMap();
        }
    }
}