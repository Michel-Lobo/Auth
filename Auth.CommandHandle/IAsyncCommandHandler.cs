using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.CommandHandle
{
    public interface IAsyncCommandHandler<TCommand> : ICommandHandler where TCommand : ICommandHandler
    {
        Task HandleAsync(TCommand command);
    }
}
