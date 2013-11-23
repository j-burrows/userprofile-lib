/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BUser_Profile.cs
 |  Purpose:    Defines the business logic of a user's profile.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace UserProfileLib.Business{
    public class BUser_Profile : UserProfileLib.Presentation.PUser_Profile, IBusinessUnit{
        public readonly ProtocolStack User_Profile_ID_Rules =
            ProtocolStack.ForKey("User_Profile_ID");
        public readonly ProtocolStack username_Rules = ProtocolStack.ForUsername();
        public readonly ProtocolStack Short_Alias_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 4 }, "Short_Alias");
        public readonly ProtocolStack Long_Alias_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 32 }, "Long_Alias");
        public readonly ProtocolStack Avatar_ID_Rules = ProtocolStack.ForKey("Avatar_ID");

        public virtual bool CreateValid(){
            bool isValid = true;
            isValid = User_Profile_ID_Rules.Create.passes(User_Profile_ID) && isValid;
            isValid = username_Rules.Create.passes(username) && isValid;
            isValid = Short_Alias_Rules.Create.passes(Short_Alias) && isValid;
            isValid = Long_Alias_Rules.Create.passes(Long_Alias) && isValid;
            isValid = Avatar_ID_Rules.Create.passes(Avatar_ID) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = User_Profile_ID_Rules.Update.passes(User_Profile_ID) && isValid;
            isValid = username_Rules.Update.passes(username) && isValid;
            isValid = Short_Alias_Rules.Update.passes(Short_Alias) && isValid;
            isValid = Long_Alias_Rules.Update.passes(Long_Alias) && isValid;
            isValid = Avatar_ID_Rules.Update.passes(Avatar_ID) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid(){
            return true;                    //Always valid for deletion at this level.
        }

        public virtual bool Equivilant(IBusinessUnit comparing){
            return false;                   //Never equivilant, no unique attributes.
        }
    }
}
