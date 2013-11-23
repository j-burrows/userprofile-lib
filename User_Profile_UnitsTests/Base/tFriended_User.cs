using System;
using UserProfileLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserProfileLibUnitTests.Base{
    [TestClass]
    public class tFriended_User{
        [TestMethod]
        public void FriendedUser_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A friended user pointer is declared.
            Friended_User friended_user;

            //Act: The pointer is constructed without parameters.
            friended_user = new Friended_User();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, friended_user);
        }
    }
}
