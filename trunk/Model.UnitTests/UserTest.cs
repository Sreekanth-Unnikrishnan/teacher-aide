using Teacher_Aide.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teacher_Aide.Data.Structure;

namespace Teacher_Aide.Model.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for UserTest and is intended
    ///to contain all UserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserTest
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
        ///A test for UserId
        ///</summary>
        [TestMethod()]
        public void UserIdTest()
        {
            User_Accessor target = new User_Accessor(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UserId;
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        ///A test for Nickname
        ///</summary>
        [TestMethod()]
        public void NicknameTest()
        {
            User_Accessor target = new User_Accessor();
            string expected = "nick";
            string actual;
            target.Nickname = expected;
            actual = target.Nickname;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for NetworkId
        ///</summary>
        [TestMethod()]
        public void NetworkIdTest()
        {
            User_Accessor target = new User_Accessor();
            string expected = "netid";
            string actual;
            target.NetworkId = expected;
            actual = target.NetworkId;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MiddleName
        ///</summary>
        [TestMethod()]
        public void MiddleNameTest()
        {
            User_Accessor target = new User_Accessor();
            string expected = "Middle";
            string actual;
            target.MiddleName = expected;
            actual = target.MiddleName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            User_Accessor target = new User_Accessor();
            string expected = "Last";
            string actual;
            target.LastName = expected;
            actual = target.LastName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            User_Accessor target = new User_Accessor();
            string expected = "First";
            string actual;
            target.FirstName = expected;
            actual = target.FirstName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CreateUser
        ///</summary>
        [TestMethod()]
        public void CreateUserTest()
        {
            string networkId = "netId";
            string lastName = "Lastname";
            string firstName = "Firstname";
            string middleName = "Middlename";
            string Nickname = "Nickname";
            User actual;
            actual = User.CreateUser(networkId, lastName, firstName, middleName, Nickname);
            Assert.AreEqual(-1, actual.UserId);
            Assert.AreEqual(lastName, actual.LastName);
            Assert.AreEqual(firstName, actual.FirstName);
            Assert.AreEqual(middleName, actual.MiddleName);
            Assert.AreEqual(Nickname, actual.Nickname);
            Assert.AreEqual(networkId, actual.NetworkId);
        }
    }
}
