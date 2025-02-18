namespace Natter.Schema;
public class Enums
{
    public enum relationType
    {
        to,
        with
    }
    public enum emotion
    {
        happy,
        angry,
        sad,
        mardy,
        relieved,
        joyful,
        excited,
        nervous,
        scared,
        love,
        aaaw,
        confused,
        annoyed,
        surprised,
        manic
    }
    public enum behaviour
    {
        infeed,
        infeedhighlightcontent,
        fullscreen
    }
    public enum level
    {
        admin,
        contributor,
        viewer
    }

    public enum type
    {
        broadcast,
        group
    }
}

public class PostPartnerRelation
{
    public string id { get; set; }
    public string postId { get; set; }
    public string userId { get; set; }
    public Enums.relationType relationType { get; set; }
}

public class PostPageRelation
{
    public string id { get; set; }
    public string postId { get; set; }
    public string pageId { get; set; }
}

public class Message
{
    public string id { get; set; }
    public string postId { get; set; }
    public string messageThreadId { get; set; }
}

public class Comment
{
    public string id { get; set; }
    public string parentPostId { get; set; }
    public string childPostId { get; set; }
}

public class PostUserTag
{
    public string id { get; set; }
    public string postId { get; set; }
    public string userId { get; set; }
}

public class Reaction
{
    public string id { get; set; }
    public string userId { get; set; }
    public string postId { get; set; }
    public string name {get; set;}
    public string imageURL { get; set; }
    public Enums.emotion emotion { get; set; }
    public int intensity { get; set; }
}

public class Post
{
    public string id { get; set; }
    public string userId { get; set; }
    public string circle { get; set; }
    public Enums.behaviour behaviour { get; set; }
    public string type { get; set; }
    public string bodyHTML { get; set; }
    public string locationName { get; set; }
    public string description { get; set; }
}

public class MessageThreadRelation
{
    public string id { get; set; }
    public string messageThreadId { get; set; }
    public string userId { get; set; }
    public Enums.level level { get; set; }
}

public class MessageThread
{
    public string id { get; set; }
    public string name { get; set; }
    public string avatarURL { get; set; }
    public string bannerURL { get; set; }
}

public class GroupMembership
{
    public string id { get; set; }
    public string userId { get; set; }
    public string pageId { get; set; }
    public Enums.level level { get; set; }
}

public class UserRelation
{
    public string id { get; set; }
    public string establishingUserId { get; set; }
    public string recievingUserId { get; set; }
    public string type { get; set; }
}

public class Page
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string avatarURL { get; set; }
    public string bannerURL { get; set; }
    public string ownerUserId { get; set; }
    public Enums.type type { get; set; }
}

public class UserLink
{
    public string id { get; set; }
    public string userId { get; set; }
    public string link { get; set; }
}

public class User
{
    public string id { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string avatarURL { get; set; }
    public string bannerURL { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
}