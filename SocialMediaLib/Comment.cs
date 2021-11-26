using System;

namespace SocialMediaLib
{
    public class Comment
    {
        #region private attributes
        private Member userWhoCommented;
        private string content;
        private DateTime date;
        #endregion private attributes

        #region constructor
        public Comment(Member userWhoCommented, string content)
        {
            throw new NotImplementedException();
        }
        #endregion constructor

        #region properties
        public Member UserWhoCommented
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Content
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DateTime Date
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion properties
    }
}
