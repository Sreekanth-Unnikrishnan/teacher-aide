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
    public class Students_Procedures : DatabaseTestClass
    {

        public Students_Procedures()
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
        public void Students_CRUD()
        {
            DatabaseTestActions testActions = this.Students_CRUDData;
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
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Students_CRUD_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students_Procedures));
            Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition newRowReturned;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkStudentNumber;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedStudentNumber;
            Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition updatedRowReturned;
            Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition checkDelete;
            this.Students_CRUDData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            Students_CRUD_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            newRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
            checkStudentNumber = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            checkUpdatedStudentNumber = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            updatedRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
            checkDelete = new Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition();
            // 
            // Students_CRUDData
            // 
            this.Students_CRUDData.PosttestAction = null;
            this.Students_CRUDData.PretestAction = null;
            this.Students_CRUDData.TestAction = Students_CRUD_TestAction;
            // 
            // Students_CRUD_TestAction
            // 
            Students_CRUD_TestAction.Conditions.Add(newRowReturned);
            Students_CRUD_TestAction.Conditions.Add(checkStudentNumber);
            Students_CRUD_TestAction.Conditions.Add(updatedRowReturned);
            Students_CRUD_TestAction.Conditions.Add(checkUpdatedStudentNumber);
            Students_CRUD_TestAction.Conditions.Add(checkDelete);
            resources.ApplyResources(Students_CRUD_TestAction, "Students_CRUD_TestAction");
            // 
            // newRowReturned
            // 
            newRowReturned.Enabled = true;
            newRowReturned.Name = "newRowReturned";
            newRowReturned.ResultSet = 2;
            // 
            // checkStudentNumber
            // 
            checkStudentNumber.ColumnNumber = 2;
            checkStudentNumber.Enabled = true;
            checkStudentNumber.ExpectedValue = "student1";
            checkStudentNumber.Name = "checkStudentNumber";
            checkStudentNumber.NullExpected = false;
            checkStudentNumber.ResultSet = 2;
            checkStudentNumber.RowNumber = 1;
            // 
            // checkUpdatedStudentNumber
            // 
            checkUpdatedStudentNumber.ColumnNumber = 2;
            checkUpdatedStudentNumber.Enabled = true;
            checkUpdatedStudentNumber.ExpectedValue = "student2";
            checkUpdatedStudentNumber.Name = "checkUpdatedStudentNumber";
            checkUpdatedStudentNumber.NullExpected = false;
            checkUpdatedStudentNumber.ResultSet = 3;
            checkUpdatedStudentNumber.RowNumber = 1;
            // 
            // updatedRowReturned
            // 
            updatedRowReturned.Enabled = true;
            updatedRowReturned.Name = "updatedRowReturned";
            updatedRowReturned.ResultSet = 3;
            // 
            // checkDelete
            // 
            checkDelete.Enabled = true;
            checkDelete.Name = "checkDelete";
            checkDelete.ResultSet = 4;
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

        private DatabaseTestActions Students_CRUDData;
    }
}
