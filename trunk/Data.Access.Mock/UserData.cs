using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess = Teacher_Aide.Data.Access;
using DataStructure = Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Data.Access.Mock
{
    public class UserData :IUserData
    {
        public DataStructure.Users GetStudents()
        {
            DataStructure.Users result = new DataStructure.Users();
            FillUsers(result, UserTypes.Students);
            return result;
        }
        public DataStructure.Users GetInstructors()
        {
            DataStructure.Users result = new DataStructure.Users();
            FillUsers(result, UserTypes.Instructors);
            return result;
        }
        public DataStructure.Users GetUsers()
        {
            DataStructure.Users result = new DataStructure.Users();
            FillUsers(result, UserTypes.AllUserTypes);
            return result;
        }
        public DataStructure.Users GetUser(int userId)
        {
            DataStructure.Users result = new DataStructure.Users();
            FillUser(result, userId);
            return result;
        }

        #region FillUser
        [Flags]
        private enum UserTypes { None = 0x00, Students = 0x01, Instructors = 0x02, AllUserTypes = 0x03 };
        private enum MockUserFieldIndexes { LastName, FirstName, MiddleName, Nickname, NetworkId, StudentId, InstructorId };
        private string[,] mockUsers = new string[,]
            {{"Byrd", "Bryant", "E", "Tatsu", "Bryant", "", "Instr2"},
                {"Messer", "Christy", "J", "Qwerty", "Christy", "", "Instr1"},
                {"Child", "First", "A", "Number1", "fchild", "Student1", ""},
                {"Child", "Second", "B", "Number2", "schild", "Student2", ""},
                {"Doble", "Amigo", "C", "Ami", "adoble", "Student3", "Instr3"}};
        //userId is equal to index + 1 since there won't be any user ID "0" in the real system
        private void FillUser(DataStructure.Users userInfo, int userId)
        {
            DataStructure.Users.UsersRow newRow = userInfo._Users.NewUsersRow();
            int userIndex = userId - 1;
            newRow.ta_user_id = userId;
            newRow.last_name = mockUsers[userIndex, (int)MockUserFieldIndexes.LastName];
            newRow.first_name = mockUsers[userIndex, (int)MockUserFieldIndexes.FirstName];
            newRow.middle_name = mockUsers[userIndex, (int)MockUserFieldIndexes.MiddleName];
            newRow.nickname = mockUsers[userIndex, (int)MockUserFieldIndexes.Nickname];
            newRow.network_user_id = mockUsers[userIndex, (int)MockUserFieldIndexes.NetworkId];
            userInfo._Users.AddUsersRow(newRow);
            //Add Student Row if appropriate
            if (!string.IsNullOrEmpty(mockUsers[userIndex, (int)MockUserFieldIndexes.StudentId]))
                userInfo.Students.AddStudentsRow(newRow, mockUsers[userIndex, (int)MockUserFieldIndexes.StudentId]);
            if (!string.IsNullOrEmpty(mockUsers[userIndex, (int)MockUserFieldIndexes.InstructorId]))
                userInfo.Instructors.AddInstructorsRow(newRow, mockUsers[userIndex, (int)MockUserFieldIndexes.InstructorId]);
        }
        private void FillUsers(DataStructure.Users userInfo, UserTypes includeUserTypes)
        {
            for (int ii = 0; ii <= mockUsers.GetUpperBound(0); ii++)
            {
                if (((includeUserTypes & UserTypes.Students) == UserTypes.Students
                    && !string.IsNullOrEmpty(mockUsers[ii, (int)MockUserFieldIndexes.StudentId]))
                    || ((includeUserTypes & UserTypes.Instructors) == UserTypes.Instructors
                    && !string.IsNullOrEmpty(mockUsers[ii, (int)MockUserFieldIndexes.InstructorId])))
                {
                    FillUser(userInfo, ii + 1);
                }
            }
        }
        #endregion
    }
}
