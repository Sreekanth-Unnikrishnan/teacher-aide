using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure = Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Model
{
    [type: CLSCompliant(false)]
    public class User : IDisposable
    {
        #region properties
        private DataStructure.Users _userDataSet;
        private DataStructure.Users.UsersRow _userData;
        protected DataStructure.Users.UsersRow UserData { get { return _userData; } }
        public int UserId { get { return this.UserData.ta_user_id; } }
        public string NetworkId
        {
            get { return UserData.network_user_id; }
            set { UserData.network_user_id = value; }
        }
        public string LastName
        {
            get { return UserData.last_name; }
            set { UserData.last_name = value; }
        }
        public string FirstName
        {
            get { return UserData.first_name; }
            set { UserData.first_name = value; }
        }
        public string MiddleName
        {
            get { return UserData.middle_name; }
            set { UserData.middle_name = value; }
        }
        public string Nickname
        {
            get { return UserData.nickname; }
            set { UserData.nickname = value; }
        }
        #endregion
        #region Constructors
        protected User()
        {
            _userDataSet = new DataStructure.Users();
            _userData = _userDataSet._Users.AddUsersRow("", "", "", "", "");
        }
        #endregion
        #region Factory Methods
        protected internal static User CreateUser(
            string networkId, string lastName, string firstName, string middleName, string nickname)
        {
            User newUser = new User
                               {
                                   NetworkId = networkId,
                                   LastName = lastName,
                                   FirstName = firstName,
                                   MiddleName = middleName,
                                   Nickname = nickname
                               };
            return newUser;
        }
        #endregion
        #region IDisposable
        private bool _disposed;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!this._disposed && disposing)
                _userDataSet.Dispose();
            this._disposed = true;
        }
        #endregion
    }
}
