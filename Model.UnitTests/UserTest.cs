using Teacher_Aide.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teacher_Aide.Model.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for UserTest and is intended
    ///to contain all UserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserTest
    {

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

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
        ///A test for UserId
        ///</summary>
        [TestMethod()]
        public void UserIdTest()
        {
            User_Accessor target = new User_Accessor();
            Assert.AreEqual(-1, target.UserId);
        }

        /// <summary>
        ///A test for Nickname
        ///</summary>
        [TestMethod()]
        public void NicknameTest()
        {
            User_Accessor target = new User_Accessor();
            const string expected = "nick";
            target.Nickname = expected;
            Assert.AreEqual(expected, target.Nickname);
        }

        /// <summary>
        ///A test for NetworkId
        ///</summary>
        [TestMethod()]
        public void NetworkIdTest()
        {
            User_Accessor target = new User_Accessor();
            const string expected = "netid";
            target.NetworkId = expected;
            Assert.AreEqual(expected, target.NetworkId);
        }

        /// <summary>
        ///A test for MiddleName
        ///</summary>
        [TestMethod()]
        public void MiddleNameTest()
        {
            User_Accessor target = new User_Accessor();
            const string expected = "Middle";
            target.MiddleName = expected;
            Assert.AreEqual(expected, target.MiddleName);
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            User_Accessor target = new User_Accessor();
            const string expected = "Last";
            target.LastName = expected;
            Assert.AreEqual(expected, target.LastName);
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            User_Accessor target = new User_Accessor();
            const string expected = "First";
            target.FirstName = expected;
            Assert.AreEqual(expected, target.FirstName);
        }

        /// <summary>
        ///A test for CreateUser
        ///</summary>
        [TestMethod()]
        public void CreateUserTest()
        {
            const string networkId = "netId";
            const string lastName = "Lastname";
            const string firstName = "Firstname";
            const string middleName = "Middlename";
            const string nickname = "Nickname";
            User actual = User.CreateUser(networkId, lastName, firstName, middleName, nickname);
            Assert.AreEqual(-1, actual.UserId);
            Assert.AreEqual(lastName, actual.LastName);
            Assert.AreEqual(firstName, actual.FirstName);
            Assert.AreEqual(middleName, actual.MiddleName);
            Assert.AreEqual(nickname, actual.Nickname);
            Assert.AreEqual(networkId, actual.NetworkId);
        }
    }
}
