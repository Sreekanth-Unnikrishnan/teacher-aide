using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teacher_Aide.Model
{
    [type: CLSCompliant(false)]
    public class Instructor : User
    {
        #region Properties
        public string InstructorId
        {
            get { return this.UserData.GetInstructorsRows()[0].instructor_id; }
            set { this.UserData.GetInstructorsRows()[0].instructor_id = value; }
        }
        #endregion
        #region Constructors
        protected Instructor() : base() { }
        #endregion
    }
}
