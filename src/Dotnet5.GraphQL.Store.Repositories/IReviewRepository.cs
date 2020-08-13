using System;
using Dotnet5.GraphQL.Store.Domain.Entities.Reviews;
using Dotnet5.GraphQL.Store.Repositories.Abstractions;

namespace Dotnet5.GraphQL.Store.Repositories
{
    public interface IReviewRepository : IRepository<Review, Guid> { }
}