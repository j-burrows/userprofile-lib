using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Base;
namespace UserProfileLibUnitTests.Base{
    [TestClass]
    public class tUser_Profile{
        [TestMethod]
        public void Avatar_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A user profile pointer is declared.
            User_Profile user_profile;

            //Act: The pointer is constructed without parameters.
            user_profile = new User_Profile();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, user_profile);
        }
    }
}
