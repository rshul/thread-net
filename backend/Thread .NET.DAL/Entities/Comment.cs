﻿using System.Collections.Generic;
using Thread_.NET.DAL.Entities.Abstract;
using Thread_.NET.DAL.Entities.Interfaces;

namespace Thread_.NET.DAL.Entities
{
    public sealed class Comment : BaseEntity, ISoftDeletable
    {
        public Comment()
        {
            Reactions = new List<CommentReaction>();
        }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public bool IsDeleted { get; set; }
        
        public string Body { get; set; }

        public ICollection<CommentReaction> Reactions { get; private set; }
    }
}
