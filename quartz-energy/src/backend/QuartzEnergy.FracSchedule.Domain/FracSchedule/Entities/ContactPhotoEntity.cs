namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using QuartzEnergy.Common.Domain.Entities;

    public class ContactPhotoEntity : IntIdEntity
    {
        public string FileName { get; set; }

        public string MimeType { get; set; }

        public int ContactId { get; set; }

        public virtual ContactEntity Contact { get; set; }
    }
}