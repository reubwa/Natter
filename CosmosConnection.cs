using Microsoft.Azure.Cosmos;

namespace Natter;

public static class CosmosConnection
{
    public static async void prepDB(CosmosClient cosmosClient)
    {
        DatabaseResponse response = await cosmosClient.CreateDatabaseIfNotExistsAsync(
                id: "core"
            );
        publics.cosmosClient = cosmosClient;
        publics.database = response.Database;
    }

    public static async void createContainers()
    {
        Container postPartnerRelation = await publics.database.CreateContainerIfNotExistsAsync(
                id: "postPartnerRelation",
                partitionKeyPath: "/postId",
                throughput: 400
                );
        Container postPageRelation = await publics.database.CreateContainerIfNotExistsAsync(
                id: "postPageRelation",
                partitionKeyPath: "/pageId",
                throughput: 400
            );
        Container message = await publics.database.CreateContainerIfNotExistsAsync(
                id: "message",
                partitionKeyPath: "/messageThreadId",
                throughput: 400
            );
        Container comment = await publics.database.CreateContainerIfNotExistsAsync(
                id: "comment",
                partitionKeyPath: "/parentPostId",
                throughput: 400
            );
        Container postUserTag = await publics.database.CreateContainerIfNotExistsAsync(
                id: "postUserTag",
                partitionKeyPath: "/postId",
                throughput: 400
            );
        Container reaction = await publics.database.CreateContainerIfNotExistsAsync(
                id: "reaction",
                partitionKeyPath: "/postId",
                throughput: 400
            );
        Container post = await publics.database.CreateContainerIfNotExistsAsync(
                id: "post",
                partitionKeyPath: "/userId",
                throughput: 400
            );
        Container messageThreadRelation = await publics.database.CreateContainerIfNotExistsAsync(
                id: "messageThreadRelation",
                partitionKeyPath: "/messageThreadId",
                throughput: 400
            );
        Container messageThread = await publics.database.CreateContainerIfNotExistsAsync(
                id: "messageThread",
                partitionKeyPath: "/messageThreadId",
                throughput: 400
            );
        Container groupMembership = await publics.database.CreateContainerIfNotExistsAsync(
                id: "groupMembership",
                partitionKeyPath: "/pageId",
                throughput: 400
            );
        Container userRelation = await publics.database.CreateContainerIfNotExistsAsync(
                id: "userRelation",
                partitionKeyPath: "/establishingUserId",
                throughput: 400
            );
        Container page = await publics.database.CreateContainerIfNotExistsAsync(
                id: "page",
                partitionKeyPath: "/ownerUserId",
                throughput: 400
            );
        Container userLink = await publics.database.CreateContainerIfNotExistsAsync(
                id: "userLink",
                partitionKeyPath: "/userId",
                throughput: 400
            );
        Container user = await publics.database.CreateContainerIfNotExistsAsync(
                id: "user",
                partitionKeyPath: "/location",
                throughput: 400
            );
    }
}

public class publics
{
    public static CosmosClient cosmosClient { get; set; }
    public static Database database { get; set; }
}