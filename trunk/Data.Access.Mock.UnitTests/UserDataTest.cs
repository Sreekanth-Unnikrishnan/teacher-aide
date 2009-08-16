using Teacher_Aide.Data.Access.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teacher_Aide.Data.Structure;

namespace Data.Access.Mock.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for UserDataTest and is intended
    ///to contain all UserDataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserDataTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetUser
        ///</summary>
        [TestMethod()]
        public void GetUserTest()
        {
            UserData target = new UserData();
            int userId = 5;
            Users actual;
            actual = target.GetUser(userId);
            Assert.AreEqual(1, actual._Users.Count);
            Assert.AreEqual(userId, actual._Users[0].ta_user_id);
            Assert.AreEqual("Doble", actual._Users[0].last_name);
            Assert.AreEqual("Amigo", actual._Users[0].first_name);
            Assert.AreEqual("C", actual._Users[0].middle_name);
            Assert.AreEqual("Ami", actual._Users[0].nickname);
            Assert.AreEqual("adoble", actual._Users[0].network_user_id);
            Assert.AreEqual(1, actual.Students.Count);
            Assert.AreEqual("Student3", actual.Students[0].student_id);
            Assert.AreEqual(1, actual.Instructors.Count);
            Assert.AreEqual("Instr3", actual.Instructors[0].instructor_id);
        }
        /// <summary>
        ///A test for GetUsers
        ///</summary>
        [TestMethod()]
        public void GetUsersTest()
        {
            UserData target = new UserData();
            Users actual;
            actual = target.GetUsers();
            Assert.AreEqual(5, actual._Users.Count);
            for (int ii = 0; ii < 5; ii++)
                Assert.AreEqual(ii + 1, actual._Users[ii].ta_user_id);
        }
    }
}
