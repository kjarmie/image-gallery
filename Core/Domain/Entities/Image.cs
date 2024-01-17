namespace Core.Domain.Entities;

public class Image
{
    public Guid Id { get; set; }
    public string RawImage { get; set; }
    public ImageFormat ImageFormat { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime UploadDate { get; set; }

    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}