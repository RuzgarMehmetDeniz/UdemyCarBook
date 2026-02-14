using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
    {
        public int Id { get; set; }

        public GetTagCloudByIBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}
