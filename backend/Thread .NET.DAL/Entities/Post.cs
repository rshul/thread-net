﻿using System.Collections.Generic;
using Thread_.NET.DAL.Entities.Abstract;
using Thread_.NET.DAL.Entities.Interfaces;

namespace Thread_.NET.DAL.Entities
{
    public sealed class Post : BaseEntity, ISoftDeletable
    {
        public Post()
        {
            Comments = new List<Comment>();
            Reactions = new List<PostReaction>();
        }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public int? PreviewId { get; set; }
        public Image Preview { get; set; }

        public string Body { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Comment> Comments { get; private set; }
        public ICollection<PostReaction> Reactions { get; private set; }
    }
}
