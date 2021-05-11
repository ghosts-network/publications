﻿using System;

namespace GhostNetwork.Content.Comments
{
    public class Comment
    {
        public Comment(string id, string content, DateTimeOffset createdOn, string publicationId, string replyCommentId, UserInfo author)
        {
            Id = id;
            Content = content;
            CreatedOn = createdOn;
            PublicationId = publicationId;
            ReplyCommentId = replyCommentId;
            Author = author;
        }

        public string Id { get; }

        public string Content { get; }

        public string PublicationId { get; }

        public UserInfo Author { get; }

        public DateTimeOffset CreatedOn { get; }

        public string ReplyCommentId { get; }

        public static Comment New(string text, string publicationId, string replyId, UserInfo author)
        {
            return new Comment(default, text, DateTimeOffset.UtcNow, publicationId, replyId, author);
        }
    }
}