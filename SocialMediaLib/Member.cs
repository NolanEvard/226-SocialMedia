using System;
using System.Collections.Generic;

namespace SocialMediaLib
{
    public class Member
    {
        #region private attributes
        private string username;
        private List<Member> followers, following;
        private List<Post> posts;
        #endregion private attributes

        #region constructor
        public Member(string username)
        {
            throw new NotImplementedException();
        }
        #endregion constructor
        #region properties
        public string Username
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<Member> Followers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<Member> Following
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<Post> Posts
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion properties

        #region public methods
        public void NewPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void LikePost(Post post, bool like = true)
        {
            throw new NotImplementedException();
        }

        public void FollowMember(Member member, bool follow = true)
        {
            throw new NotImplementedException();
        }

        public void CommentPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void RemovePost(Post post)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
