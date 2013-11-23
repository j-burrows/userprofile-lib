using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Presentation;
namespace UserProfileLibUnitTests.Presentation{
    [TestClass]
    public class tPAvatar{
        [TestMethod]
        public void PAvatar_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: an avatar with null members is constructed.
            PAvatar avatar = new PAvatar { 
                Name = null, 
                Url = null 
            };

            //Act: The blocked user is formatted.
            avatar.Format();

            //Assert: The blocked user's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, avatar.Name);
            Assert.AreEqual(string.Empty, avatar.Url);
        }
    }
}
