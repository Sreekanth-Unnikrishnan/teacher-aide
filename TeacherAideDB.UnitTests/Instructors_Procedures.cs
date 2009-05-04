using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;
using Microsoft.Data.Schema.UnitTesting.Conditions;

namespace TeacherAideDB.UnitTests
{
    [TestClass()]
    public class Instructors_Procedures : DatabaseTestClass
    {

        public Instructors_Procedures()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void Instructors_CRUD()
        {
            DatabaseTestActions testActions = this.Instructors_CRUDData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Instructors_CRUD_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructors_Procedures));
            Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition checkDelete;
            Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition newRowReturned;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkInstructorNumber;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedInstructorNumber;
            Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition updatedRowReturned;
            this.Instructors_CRUDData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            Instructors_CRUD_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            checkDelete = new Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition();
            newRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
            checkInstructorNumber = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            checkUpdatedInstructorNumber = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            updatedRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // Instructors_CRUD_TestAction
            // 
            Instructors_CRUD_TestAction.Conditions.Add(newRowReturned);
            Instructors_CRUD_TestAction.Conditions.Add(checkInstructorNumber);
            Instructors_CRUD_TestAction.Conditions.Add(updatedRowReturned);
            Instructors_CRUD_TestAction.Conditions.Add(checkUpdatedInstructorNumber);
            Instructors_CRUD_TestAction.Conditions.Add(checkDelete);
            resources.ApplyResources(Instructors_CRUD_TestAction, "Instructors_CRUD_TestAction");
            // 
            // Instructors_CRUDData
            // 
            this.Instructors_CRUDData.PosttestAction = null;
            this.Instructors_CRUDData.PretestAction = null;
            this.Instructors_CRUDData.TestAction = Instructors_CRUD_TestAction;
            // 
            // checkDelete
            // 
            checkDelete.Enabled = true;
            checkDelete.Name = "checkDelete";
            checkDelete.ResultSet = 4;
            // 
            // newRowReturned
            // 
            newRowReturned.Enabled = true;
            newRowReturned.Name = "newRowReturned";
            newRowReturned.ResultSet = 2;
            // 
            // checkInstructorNumber
            // 
            checkInstructorNumber.ColumnNumber = 2;
            checkInstructorNumber.Enabled = true;
            checkInstructorNumber.ExpectedValue = "teacher1";
            checkInstructorNumber.Name = "checkInstructorNumber";
            checkInstructorNumber.NullExpected = false;
            checkInstructorNumber.ResultSet = 2;
            checkInstructorNumber.RowNumber = 1;
            // 
            // checkUpdatedInstructorNumber
            // 
            checkUpdatedInstructorNumber.ColumnNumber = 2;
            checkUpdatedInstructorNumber.Enabled = true;
            checkUpdatedInstructorNumber.ExpectedValue = "teacher2";
            checkUpdatedInstructorNumber.Name = "checkUpdatedInstructorNumber";
            checkUpdatedInstructorNumber.NullExpected = false;
            checkUpdatedInstructorNumber.ResultSet = 3;
            checkUpdatedInstructorNumber.RowNumber = 1;
            // 
            // updatedRowReturned
            // 
            updatedRowReturned.Enabled = true;
            updatedRowReturned.Name = "updatedRowReturned";
            updatedRowReturned.ResultSet = 3;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private DatabaseTestActions Instructors_CRUDData;
    }
}
