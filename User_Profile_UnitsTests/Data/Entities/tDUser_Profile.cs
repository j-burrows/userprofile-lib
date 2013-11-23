using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Data.Entities;
namespace UserProfileLibUnitTests.Data.Entities{
    [TestClass]
    public class tDUser_Profile{
        
        [TestMethod]
        public void DUser_Profile_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An user_profile with a unique key is constructed.
            DUser_Profile user_profile = new DUser_Profile { User_Profile_ID = -1 };

            //Act: the key is retrieved.
            int key = user_profile.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, user_profile.User_Profile_ID);
        }

        [TestMethod]
        public void DUser_ProfileWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An user_profile with malicious sql members is constructed.
            string malicious = "<div></div>";
            DUser_Profile user_profile = new DUser_Profile{
                Short_Alias = malicious,
                Long_Alias = malicious,
                username = malicious
            };

            //Act: The friended user is scrubbed.
            user_profile.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, user_profile.Short_Alias);
            Assert.AreNotEqual(malicious, user_profile.Long_Alias);
            Assert.AreNotEqual(malicious, user_profile.username);
        }

        [TestMethod]
        public void DUser_ProfileWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An user_profile with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DUser_Profile user_profile = new DUser_Profile{
                Short_Alias = malicious,
                Long_Alias = malicious,
                username = malicious
            };

            //Act: The friended user is scrubbed.
            user_profile.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, user_profile.Short_Alias);
            Assert.AreNotEqual(malicious, user_profile.Long_Alias);
            Assert.AreNotEqual(malicious, user_profile.username);
        }
    }
}
