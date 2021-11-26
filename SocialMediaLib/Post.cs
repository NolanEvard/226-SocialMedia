using System;
using System.Collections.Generic;

namespace SocialMediaLib
{
    public class Post
    {
        #region private attributes
        private Uri video, music;
        private Member owner;
        private string description;
        private List<Member> likes;
        private List<Comment> comments;
        #endregion private attributes

        #region constructor
        public Post(Uri video, Member owner, Uri music = null, string description = null)
        {
            throw new NotImplementedException();
        }
        #endregion constructor
        #region properties
        public Uri Video
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Uri Music
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Member Owner
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public List<Member> Likes
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<Comment> Comments
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion properties

        #region public methods
        public void AddComment(Comment commentToAdd)
        {
            throw new NotImplementedException();
        }
        public void RemoveComment(Comment commentToRemove)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
