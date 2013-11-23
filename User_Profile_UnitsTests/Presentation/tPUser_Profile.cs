using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Presentation;
namespace UserProfileLibUnitTests.Presentation{
    [TestClass]
    public class tPUser_Profile{
        [TestMethod]
        public void PUser_Profile_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: an avatar with null members is constructed.
            PUser_Profile user_profile = new PUser_Profile { 
                Short_Alias = null, 
                Long_Alias = null ,
                username = null
            };

            //Act: The blocked user is formatted.
            user_profile.Format();

            //Assert: The blocked user's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, user_profile.Short_Alias);
            Assert.AreEqual(string.Empty, user_profile.Long_Alias);
            Assert.AreEqual(string.Empty, user_profile.username);
        }
    }
}
