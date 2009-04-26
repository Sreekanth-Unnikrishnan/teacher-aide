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
  public class Users_Procedures : DatabaseTestClass
  {

    public Users_Procedures()
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
    public void Users_Insert()
    {
      DatabaseTestActions testActions = this.Users_InsertData;
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
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Users_Insert_TestAction;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_Procedures));
      Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition newRowReturned;
      Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkNetId;
      Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkLastName;
      Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkFirstName;
      Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkMiddleName;
      Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkNickname;
      this.Users_InsertData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
      Users_Insert_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      newRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
      checkNetId = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
      checkLastName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
      checkFirstName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
      checkMiddleName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
      checkNickname = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
      // 
      // Users_Insert_TestAction
      // 
      Users_Insert_TestAction.Conditions.Add(newRowReturned);
      Users_Insert_TestAction.Conditions.Add(checkNetId);
      Users_Insert_TestAction.Conditions.Add(checkLastName);
      Users_Insert_TestAction.Conditions.Add(checkFirstName);
      Users_Insert_TestAction.Conditions.Add(checkMiddleName);
      Users_Insert_TestAction.Conditions.Add(checkNickname);
      resources.ApplyResources(Users_Insert_TestAction, "Users_Insert_TestAction");
      // 
      // newRowReturned
      // 
      newRowReturned.Enabled = true;
      newRowReturned.Name = "newRowReturned";
      newRowReturned.ResultSet = 1;
      newRowReturned.RowCount = 1;
      // 
      // checkNetId
      // 
      checkNetId.ColumnNumber = 2;
      checkNetId.Enabled = true;
      checkNetId.ExpectedValue = "netid";
      checkNetId.Name = "checkNetId";
      checkNetId.NullExpected = false;
      checkNetId.ResultSet = 1;
      checkNetId.RowNumber = 1;
      // 
      // checkLastName
      // 
      checkLastName.ColumnNumber = 3;
      checkLastName.Enabled = true;
      checkLastName.ExpectedValue = "Last";
      checkLastName.Name = "checkLastName";
      checkLastName.NullExpected = false;
      checkLastName.ResultSet = 1;
      checkLastName.RowNumber = 1;
      // 
      // checkFirstName
      // 
      checkFirstName.ColumnNumber = 4;
      checkFirstName.Enabled = true;
      checkFirstName.ExpectedValue = "First";
      checkFirstName.Name = "checkFirstName";
      checkFirstName.NullExpected = false;
      checkFirstName.ResultSet = 1;
      checkFirstName.RowNumber = 1;
      // 
      // checkMiddleName
      // 
      checkMiddleName.ColumnNumber = 5;
      checkMiddleName.Enabled = true;
      checkMiddleName.ExpectedValue = "M";
      checkMiddleName.Name = "checkMiddleName";
      checkMiddleName.NullExpected = false;
      checkMiddleName.ResultSet = 1;
      checkMiddleName.RowNumber = 1;
      // 
      // checkNickname
      // 
      checkNickname.ColumnNumber = 6;
      checkNickname.Enabled = true;
      checkNickname.ExpectedValue = "Nick";
      checkNickname.Name = "checkNickname";
      checkNickname.NullExpected = false;
      checkNickname.ResultSet = 1;
      checkNickname.RowNumber = 1;
      // 
      // Users_InsertData
      // 
      this.Users_InsertData.PosttestAction = null;
      this.Users_InsertData.PretestAction = null;
      this.Users_InsertData.TestAction = Users_Insert_TestAction;
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

    private DatabaseTestActions Users_InsertData;
  }
}
