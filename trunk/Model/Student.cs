using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure = Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Model
{
    [type: CLSCompliant(false)]
    public class Student : User
    {
        #region Properties
        public string StudentId
        {
            get { return this.UserData.GetStudentsRows()[0].student_id; }
            set { this.UserData.GetStudentsRows()[0].student_id = value; }
        }
        #endregion
        #region Constructors
        protected Student() : base()
        {
            ((DataStructure.Users) UserData.Table.DataSet).Students.AddStudentsRow(UserData, "");
        }
        #endregion
    }
}
