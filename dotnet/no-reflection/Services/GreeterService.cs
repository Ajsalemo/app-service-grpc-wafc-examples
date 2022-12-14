using Grpc.Core;
using noreflection;

namespace noreflection.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(Empty request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello, from app-service-grpc-wafc-examples-dotnet-noreflection - gRPC"
        });
    }
}
