using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure = Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Data.Access
{
    public interface IUserData
    {
        DataStructure.Users GetStudents();
        DataStructure.Users GetInstructors();
        DataStructure.Users GetUsers();
        DataStructure.Users GetUser(int userId);
    }
}
