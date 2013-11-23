using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Base;
namespace UserProfileLibUnitTests.Base{
    [TestClass]
    public class tAvatar{
        [TestMethod]
        public void Avatar_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A avatar pointer is declared.
            Avatar avatar;

            //Act: The pointer is constructed without parameters.
            avatar = new Avatar();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, avatar);
        }
    }
}
