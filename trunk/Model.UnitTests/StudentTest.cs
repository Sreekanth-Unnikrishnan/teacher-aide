using Teacher_Aide.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Teacher_Aide.Model.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for StudentTest and is intended
    ///to contain all StudentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentTest
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
        ///A test for StudentId
        ///</summary>
        [TestMethod()]
        public void StudentIdTest()
        {
            Student_Accessor target = new Student_Accessor();
            const string expected = "Student1";
            target.StudentId = expected;
            Assert.AreEqual(expected, target.StudentId);
        }
    }
}
