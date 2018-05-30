namespace Ett.TimeTracker.Domain.Entities
{
    using Ett.Common.Domain.Entities;

    public class UserPhotoEntity : IntIdEntity
    {
        public string FileName { get; set; }

        public string MimeType { get; set; }

        public int UserId { get; set; }

        public virtual UserEntity User { get; set; }
    }
}