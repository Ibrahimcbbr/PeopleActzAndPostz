using MediatR;

namespace PeopleActzAndPostz.Application.Common.Contracts.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
