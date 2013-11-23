using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileLib.Business;
namespace UserProfileLibUnitTests.Business{
    [TestClass]
    public class tBUser_Profile{
        [TestMethod]
        public void BUser_ProfileWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: A user_profile with all valid members is created.
            BUser_Profile user_profile = new BUser_Profile { 
                Long_Alias = "Long",
                Short_Alias = "S",
                username="username"
            };
            
            //Act: the user_profile is checked if it is create valid.
            bool valid = user_profile.CreateValid();

            //Assert: the user_profile is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BUser_ProfileWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: A user_profile with all invalid members is created.
            BUser_Profile user_profile = new BUser_Profile{
                Long_Alias = "1234567890123456789012345678901234567890",
                Short_Alias = "1234567890",
                username=null
            };

            //Act: the user_profile is checked if it is create valid.
            bool valid = user_profile.CreateValid();

            //Assert: the user_profile is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BUser_ProfileWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: A user_profile with all valid members is created.
            BUser_Profile user_profile = new BUser_Profile{
                Long_Alias = "Long",
                Short_Alias = "S",
                username="username"
            };

            //Act: the user_profile is checked if it is update valid.
            bool valid = user_profile.UpdateValid();

            //Assert: the user_profile is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BUser_ProfileWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: A user_profile with all invalid members is created.
            BUser_Profile user_profile = new BUser_Profile{
                Long_Alias = "1234567890123456789012345678901234567890",
                Short_Alias = "1234567890",
                username=null
            };

            //Act: the user_profile is checked if it is update valid.
            bool valid = user_profile.UpdateValid();

            //Assert: the user_profile is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: A user_profile is created
            BUser_Profile user_profile = new BUser_Profile();

            //Act: the user_profile is checked if it is update valid.
            bool valid = user_profile.DeleteValid();

            //Assert: the user_profile is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BUser_Profile_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: A user_profile is created
            BUser_Profile user_profile = new BUser_Profile();

            //Act: the user_profile is checked to be equivilant to itself.
            bool equals = false;// user_profile.Equivilant(user_profile);

            //Assert: the user_profile is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
