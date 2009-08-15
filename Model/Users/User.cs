using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Model
{
    public class User
    {
        private Users _userDataSet;
        private Users.UsersRow _userData;
        private Users.UsersRow UserData { get { return _userData; } }
        public int UserId { get { return this.UserData.ta_user_id; } }
        public string NetworkId
        {
            get { return this.UserData.network_user_id; }
            set { this.UserData.network_user_id = value; }
        }
        public string LastName
        {
            get { return this.UserData.last_name; }
            set { this.UserData.last_name = value; }
        }
        public string FirstName
        {
            get { return this.UserData.first_name; }
            set { this.UserData.first_name = value; }
        }
        public string MiddleName
        {
            get { return this.UserData.middle_name; }
            set { this.UserData.middle_name = value; }
        }
        public string NickName
        {
            get { return this.UserData.nickname; }
            set { this.UserData.nickname = value; }
        }

        private User()
        {
            _userDataSet = new Users();
            _userData = (Users.UsersRow) _userDataSet.Tables["Users"].NewRow();
            _userData.ta_user_id = -1;
        }

        protected internal static User CreateUser(
            string networkId, string lastName, string firstName, string middleName, string nickName)
        {
            User newUser = new User();
            newUser.NetworkId = networkId;
            newUser.LastName = lastName;
            newUser.FirstName = firstName;
            newUser.MiddleName = middleName;
            newUser.NickName = nickName;
            return newUser;
        }
    }
}
