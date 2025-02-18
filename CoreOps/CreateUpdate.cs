using Microsoft.Azure.Cosmos;
using Natter.Schema;

namespace Natter.CoreOps;

public class Push
{
    public static async void PostPartnerRelation(PostPartnerRelation relation)
    {
        var container = publics.database.GetContainer("postPartnerRelation");
        PostPartnerRelation upsertedItem = await container.UpsertItemAsync<PostPartnerRelation>(
                item: relation,
                partitionKey: new PartitionKey(relation.postId)
            );
    }

    public static async void PostPageRelation(PostPageRelation relation)
    {
        var container = publics.database.GetContainer("postPageRelation");
        PostPageRelation upsertedItem = await container.UpsertItemAsync<PostPageRelation>(
                item: relation,
                partitionKey: new PartitionKey(relation.pageId)
            );
    }

    public static async void Message(Message message)
    {
        var container = publics.database.GetContainer("message");
        Message upsertedItem = await container.UpsertItemAsync<Message>(
                item: message,
                partitionKey: new PartitionKey(message.messageThreadId)
            );
    }

    public static async void Comment(Comment comment)
    {
        var container = publics.database.GetContainer("comment");
        Comment upsertedItem = await container.UpsertItemAsync<Comment>(
                item: comment,
                partitionKey: new PartitionKey(comment.parentPostId)
            );
    }

    public static async void PostUserTag(PostUserTag tag)
    {
        var container = publics.database.GetContainer("postUserTag");
        PostUserTag upsertedItem = await container.UpsertItemAsync<PostUserTag>(
                item: tag,
                partitionKey: new PartitionKey(tag.postId)
            );
    }

    public static async void Reaction(Reaction reaction)
    {
        var container = publics.database.GetContainer("reaction");
        Reaction upsertedItem = await container.UpsertItemAsync<Reaction>(
                item: reaction,
                partitionKey: new PartitionKey(reaction.postId)
            );
    }

    public static async void Post(Post post)
    {
        var container = publics.database.GetContainer("post");
        Post upsertedItem = await container.UpsertItemAsync<Post>(
                item: post,
                partitionKey: new PartitionKey(post.userId)
            );
    }

    public static async void MessageThreadRelation(MessageThreadRelation relation)
    {
        var container = publics.database.GetContainer("messageThreadRelation");
        MessageThreadRelation upsertedItem = await container.UpsertItemAsync<MessageThreadRelation>(
                item: relation,
                partitionKey: new PartitionKey(relation.messageThreadId)
            );
    }

    public static async void MessageThread(MessageThread messageThread)
    {
        var container = publics.database.GetContainer("messageThread");
        MessageThread upsertedItem = await container.UpsertItemAsync<MessageThread>(
                item: messageThread,
                partitionKey: new PartitionKey(messageThread.name)
            );
    }

    public static async void GroupMembership(GroupMembership groupMembership)
    {
        var container = publics.database.GetContainer("groupMembership");
        GroupMembership upsertedItem = await container.UpsertItemAsync<GroupMembership>(
                item: groupMembership,
                partitionKey: new PartitionKey(groupMembership.pageId)
            );
    }

    public static async void UserRelation(UserRelation relation)
    {
        var container = publics.database.GetContainer("userRelation");
        UserRelation upsertedItem = await container.UpsertItemAsync<UserRelation>(
                item: relation,
                partitionKey: new PartitionKey(relation.establishingUserId)
            );
    }

    public static async void Page(Page page)
    {
        var container = publics.database.GetContainer("page");
        Page upsertedItem = await container.UpsertItemAsync<Page>(
                item: page,
                partitionKey: new PartitionKey(page.ownerUserId)
            );
    }

    public static async void UserLink(UserLink link)
    {
        var container = publics.database.GetContainer("userLink");
        UserLink upsertedItem = await container.UpsertItemAsync<UserLink>(
                item: link,
                partitionKey: new PartitionKey(link.userId)
            );
    }

    public static async void User(Schema.User user)
    {
        var container = publics.database.GetContainer("user");
        Schema.User upsertedItem = await container.UpsertItemAsync<Schema.User>(
                item: user,
                partitionKey: new PartitionKey(user.location)
            );
    }
}