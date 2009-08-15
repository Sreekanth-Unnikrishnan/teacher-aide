using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Model
{
    [type: CLSCompliant(false)]
    public class User : IDisposable
    {
        private Users _userDataSet;
        private Users.UsersRow _userData;
        protected Users.UsersRow UserData { get { return _userData; } }
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
        public string Nickname
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
            string networkId, string lastName, string firstName, string middleName, string nickname)
        {
            User newUser = new User();
            newUser.NetworkId = networkId;
            newUser.LastName = lastName;
            newUser.FirstName = firstName;
            newUser.MiddleName = middleName;
            newUser.Nickname = nickname;
            return newUser;
        }
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
