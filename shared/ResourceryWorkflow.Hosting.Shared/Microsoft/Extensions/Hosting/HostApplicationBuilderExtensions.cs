using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Hosting;

public static class HostApplicationBuilderExtensions
{
    public static IHostApplicationBuilder AddSharedEndpoints(this IHostApplicationBuilder builder)
    {
        builder.AddRabbitMQClient(
            connectionName: ResourceryWorkflowNames.RabbitMq,
            action =>
                action.ConnectionString = builder.Configuration.GetConnectionString(
                    ResourceryWorkflowNames.RabbitMq
                )
        );
        builder.AddRedisDistributedCache(connectionName: ResourceryWorkflowNames.Redis);
        builder.AddSeqEndpoint(connectionName: ResourceryWorkflowNames.Seq);

        return builder;
    }
}
