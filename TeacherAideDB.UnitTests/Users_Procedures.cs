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
    public void Users_CRUD()
    {
      DatabaseTestActions testActions = this.Users_CRUDData;
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
        Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Users_CRUD_TestAction;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_Procedures));
        Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition newRowReturned;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkNetId;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkLastName;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkFirstName;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkMiddleName;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkNickname;
        Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition updatedRowReturned;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedNetId;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedLastName;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedFirstName;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedMiddleName;
        Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition checkUpdatedNickname;
        Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition checkDelete;
        Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition newUserIdResult;
        this.Users_CRUDData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
        Users_CRUD_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
        newRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
        checkNetId = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkLastName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkFirstName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkMiddleName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkNickname = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        updatedRowReturned = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
        checkUpdatedNetId = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkUpdatedLastName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkUpdatedFirstName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkUpdatedMiddleName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkUpdatedNickname = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
        checkDelete = new Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition();
        newUserIdResult = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
        // 
        // Users_CRUD_TestAction
        // 
        Users_CRUD_TestAction.Conditions.Add(newUserIdResult);
        Users_CRUD_TestAction.Conditions.Add(newRowReturned);
        Users_CRUD_TestAction.Conditions.Add(checkNetId);
        Users_CRUD_TestAction.Conditions.Add(checkLastName);
        Users_CRUD_TestAction.Conditions.Add(checkFirstName);
        Users_CRUD_TestAction.Conditions.Add(checkMiddleName);
        Users_CRUD_TestAction.Conditions.Add(checkNickname);
        Users_CRUD_TestAction.Conditions.Add(updatedRowReturned);
        Users_CRUD_TestAction.Conditions.Add(checkUpdatedNetId);
        Users_CRUD_TestAction.Conditions.Add(checkUpdatedLastName);
        Users_CRUD_TestAction.Conditions.Add(checkUpdatedFirstName);
        Users_CRUD_TestAction.Conditions.Add(checkUpdatedMiddleName);
        Users_CRUD_TestAction.Conditions.Add(checkUpdatedNickname);
        Users_CRUD_TestAction.Conditions.Add(checkDelete);
        resources.ApplyResources(Users_CRUD_TestAction, "Users_CRUD_TestAction");
        // 
        // newRowReturned
        // 
        newRowReturned.Enabled = true;
        newRowReturned.Name = "newRowReturned";
        newRowReturned.ResultSet = 2;
        newRowReturned.RowCount = 1;
        // 
        // checkNetId
        // 
        checkNetId.ColumnNumber = 2;
        checkNetId.Enabled = true;
        checkNetId.ExpectedValue = "netid";
        checkNetId.Name = "checkNetId";
        checkNetId.NullExpected = false;
        checkNetId.ResultSet = 2;
        checkNetId.RowNumber = 1;
        // 
        // checkLastName
        // 
        checkLastName.ColumnNumber = 3;
        checkLastName.Enabled = true;
        checkLastName.ExpectedValue = "Last";
        checkLastName.Name = "checkLastName";
        checkLastName.NullExpected = false;
        checkLastName.ResultSet = 2;
        checkLastName.RowNumber = 1;
        // 
        // checkFirstName
        // 
        checkFirstName.ColumnNumber = 4;
        checkFirstName.Enabled = true;
        checkFirstName.ExpectedValue = "First";
        checkFirstName.Name = "checkFirstName";
        checkFirstName.NullExpected = false;
        checkFirstName.ResultSet = 2;
        checkFirstName.RowNumber = 1;
        // 
        // checkMiddleName
        // 
        checkMiddleName.ColumnNumber = 5;
        checkMiddleName.Enabled = true;
        checkMiddleName.ExpectedValue = "M";
        checkMiddleName.Name = "checkMiddleName";
        checkMiddleName.NullExpected = false;
        checkMiddleName.ResultSet = 2;
        checkMiddleName.RowNumber = 1;
        // 
        // checkNickname
        // 
        checkNickname.ColumnNumber = 6;
        checkNickname.Enabled = true;
        checkNickname.ExpectedValue = "Nick";
        checkNickname.Name = "checkNickname";
        checkNickname.NullExpected = false;
        checkNickname.ResultSet = 2;
        checkNickname.RowNumber = 1;
        // 
        // updatedRowReturned
        // 
        updatedRowReturned.Enabled = true;
        updatedRowReturned.Name = "updatedRowReturned";
        updatedRowReturned.ResultSet = 3;
        // 
        // checkUpdatedNetId
        // 
        checkUpdatedNetId.ColumnNumber = 2;
        checkUpdatedNetId.Enabled = true;
        checkUpdatedNetId.ExpectedValue = "netid2";
        checkUpdatedNetId.Name = "checkUpdatedNetId";
        checkUpdatedNetId.NullExpected = false;
        checkUpdatedNetId.ResultSet = 3;
        checkUpdatedNetId.RowNumber = 1;
        // 
        // checkUpdatedLastName
        // 
        checkUpdatedLastName.ColumnNumber = 3;
        checkUpdatedLastName.Enabled = true;
        checkUpdatedLastName.ExpectedValue = "Last2";
        checkUpdatedLastName.Name = "checkUpdatedLastName";
        checkUpdatedLastName.NullExpected = false;
        checkUpdatedLastName.ResultSet = 3;
        checkUpdatedLastName.RowNumber = 1;
        // 
        // checkUpdatedFirstName
        // 
        checkUpdatedFirstName.ColumnNumber = 4;
        checkUpdatedFirstName.Enabled = true;
        checkUpdatedFirstName.ExpectedValue = "First2";
        checkUpdatedFirstName.Name = "checkUpdatedFirstName";
        checkUpdatedFirstName.NullExpected = false;
        checkUpdatedFirstName.ResultSet = 3;
        checkUpdatedFirstName.RowNumber = 1;
        // 
        // checkUpdatedMiddleName
        // 
        checkUpdatedMiddleName.ColumnNumber = 5;
        checkUpdatedMiddleName.Enabled = true;
        checkUpdatedMiddleName.ExpectedValue = "N";
        checkUpdatedMiddleName.Name = "checkUpdatedMiddleName";
        checkUpdatedMiddleName.NullExpected = false;
        checkUpdatedMiddleName.ResultSet = 3;
        checkUpdatedMiddleName.RowNumber = 1;
        // 
        // checkUpdatedNickname
        // 
        checkUpdatedNickname.ColumnNumber = 6;
        checkUpdatedNickname.Enabled = true;
        checkUpdatedNickname.ExpectedValue = "Nick2";
        checkUpdatedNickname.Name = "checkUpdatedNickname";
        checkUpdatedNickname.NullExpected = false;
        checkUpdatedNickname.ResultSet = 3;
        checkUpdatedNickname.RowNumber = 1;
        // 
        // checkDelete
        // 
        checkDelete.Enabled = true;
        checkDelete.Name = "checkDelete";
        checkDelete.ResultSet = 4;
        // 
        // Users_CRUDData
        // 
        this.Users_CRUDData.PosttestAction = null;
        this.Users_CRUDData.PretestAction = null;
        this.Users_CRUDData.TestAction = Users_CRUD_TestAction;
        // 
        // newUserIdResult
        // 
        newUserIdResult.Enabled = true;
        newUserIdResult.Name = "newUserIdResult";
        newUserIdResult.ResultSet = 1;
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

    private DatabaseTestActions Users_CRUDData;
  }
}
