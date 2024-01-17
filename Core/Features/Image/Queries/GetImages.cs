using Core.Data.Contracts;
using Core.Domain.Entities;
using Core.Features.Image.Data;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Core.Features.Image.Queries.GetImages;

public sealed record Query() : IRequest<Fin<Seq<Response>>>;

public sealed class Handler : IRequestHandler<Query, Fin<Seq<Response>>>
{
    private readonly ILogger _logger;
    private readonly IDbContext _dbContext;
    private readonly IImageQueryRepository _imageQueryRepository;

    private readonly ImageMapper _mapper = new ImageMapper();

    public Handler(ILogger logger, IDbContext dbContext, IImageQueryRepository imageQueryRepository)
    {
        _logger = logger;
        _dbContext = dbContext;
        _imageQueryRepository = imageQueryRepository;
    }

    public async Task<Fin<Seq<Response>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var result = await _imageQueryRepository.ReadAllAsync();
        return result.Match(ok =>
                Fin<Seq<Response>>.Succ(ok.Map(e => _mapper.ToGetImagesResponse(e))),
            err => Fin<Seq<Response>>.Fail(err)
        );
    }
}

public sealed record Response(
    Guid Id,
    string RawImage,
    ImageFormat ImageFormat,
    string Title,
    string Description,
    DateTime UploadDate,
    DateTime CreatedOn,
    string CreatedBy,
    DateTime ModifiedOn,
    string ModifiedBy
);