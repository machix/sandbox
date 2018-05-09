namespace QuartzEnergy.FracSchedule.Web.Controllers.Vehicles
{
    using AutoMapper;

    using QuartzEnergy.Common.Files.Controllers;
    using QuartzEnergy.Common.Files.Services;

    public sealed class VehiclePhotosController
        : EntityUploadController
    {
        public VehiclePhotosController(IEntityFilesService filesService, IMapper mapper)
            : base(filesService, mapper)
        {
        }
    }
}
