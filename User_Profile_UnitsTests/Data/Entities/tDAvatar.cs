using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Data.Entities;
namespace UserProfileLibUnitTests.Data.Entities{
    [TestClass]
    public class tDAvatar{
        [TestMethod]
        public void DAvatar_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An avatar with a unique key is constructed.
            DAvatar avatar = new DAvatar { Avatar_ID = -1 };

            //Act: the key is retrieved.
            int key = avatar.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, avatar.Avatar_ID);
        }

        [TestMethod]
        public void DAvatarWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An avatar with malicious sql members is constructed.
            string malicious = "<div></div>";
            DAvatar avatar = new DAvatar{
                Name = malicious,
                Url = malicious
            };

            //Act: The friended user is scrubbed.
            avatar.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, avatar.Name);
            Assert.AreNotEqual(malicious, avatar.Url);
        }

        [TestMethod]
        public void DAvatarWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An avatar with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DAvatar avatar = new DAvatar{
                Name = malicious,
                Url = malicious
            };

            //Act: The friended user is scrubbed.
            avatar.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, avatar.Name);
            Assert.AreNotEqual(malicious, avatar.Url);
        }
    }
}
