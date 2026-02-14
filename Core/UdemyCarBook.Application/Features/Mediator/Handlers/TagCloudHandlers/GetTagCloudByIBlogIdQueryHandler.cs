using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResult;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIBlogIdQueryHandler : IRequestHandler<GetTagCloudByIBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _repository;

        public GetTagCloudByIBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByIBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetTagCloudsByBlogId(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResult
            {
                BlogID = x.BlogID,
                TagCloudID = x.TagCloudID,
                Title = x.Title
            }).ToList();
        }
    }
}
