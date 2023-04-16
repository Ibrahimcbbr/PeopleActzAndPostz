using MediatR;

namespace PeopleActzAndPostz.Application.Common.Contracts.Messaging
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
