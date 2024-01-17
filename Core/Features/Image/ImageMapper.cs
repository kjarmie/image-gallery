using Riok.Mapperly.Abstractions;
using GetImages = Core.Features.Image.Queries.GetImages;

namespace Core.Features.Image;

[Mapper]
public partial class ImageMapper
{
    public partial GetImages.Response ToGetImagesResponse(Domain.Entities.Image image);
}