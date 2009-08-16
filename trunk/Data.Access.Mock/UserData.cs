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
        /*
        public DataStructure.Users GetStudents()
        {
            DataStructure.Users result = new DataStructure.Users();
            return result;
        }
        public DataStructure.Users GetStudent(int userId)
        {
            DataStructure.Users result = new DataStructure.Users();
            return result;
        }
        public DataStructure.Users GetInstructors()
        {
            DataStructure.Users result = new DataStructure.Users();
            return result;
        }
        public DataStructure.Users GetInstructor(int userId)
        {
            DataStructure.Users result = new DataStructure.Users();
            return result;
        }
        public DataStructure.Users GetUsers()
        {
            DataStructure.Users result = new DataStructure.Users();
            return result;
        }
        */
        public DataStructure.Users GetUser(int userId)
        {
            DataStructure.Users result = new DataStructure.Users();
            //result._Users.Columns["ta_user_id"].AutoIncrement = false;
            FillUser(result, userId);
            return result;
        }

        #region FillUser
        private const int LastName = 0;
        private const int FirstName = 1;
        private const int MiddleName = 2;
        private const int Nickname = 3;
        private const int NetworkId = 4;
        private const int StudentId = 5;
        private const int InstructorId = 6;
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
            newRow.last_name = mockUsers[userIndex, LastName];
            newRow.first_name = mockUsers[userIndex, FirstName];
            newRow.middle_name = mockUsers[userIndex, MiddleName];
            newRow.nickname = mockUsers[userIndex, Nickname];
            newRow.network_user_id = mockUsers[userIndex, NetworkId];
            userInfo._Users.AddUsersRow(newRow);
            //Add Student Row if appropriate
            if (!string.IsNullOrEmpty(mockUsers[userIndex, StudentId]))
                userInfo.Students.AddStudentsRow(newRow, mockUsers[userIndex, StudentId]);
            if (!string.IsNullOrEmpty(mockUsers[userIndex, InstructorId]))
                userInfo.Instructors.AddInstructorsRow(newRow, mockUsers[userIndex, InstructorId]);
        }
        #endregion
    }
}
