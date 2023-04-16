using MediatR;
using PeopleActzAndPostz.Application.Common.Contracts.Messaging;

namespace PeopleActzAndPostz.Application.Common.ContractsMessaging
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
         where TQuery : IQuery<TResponse>
    {
    }
}
