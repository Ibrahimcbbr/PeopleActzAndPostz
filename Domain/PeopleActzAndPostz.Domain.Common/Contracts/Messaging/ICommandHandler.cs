using MediatR;

namespace PeopleActzAndPostz.Application.Common.Contracts.Messaging
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
     where TCommand : ICommand<TResponse>
    {
    }
}
