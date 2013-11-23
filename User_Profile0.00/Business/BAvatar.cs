/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BAvatar.cs
 |  Purpose:    Defines the business logic of a user's profile.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace UserProfileLib.Business{
    public class BAvatar : UserProfileLib.Presentation.PAvatar, IBusinessUnit{
        public readonly ProtocolStack Avatar_ID_Rules = ProtocolStack.ForKey("Avatar_ID");
        public readonly ProtocolStack Url_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 1024 }, "Url");
        public readonly ProtocolStack Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Name");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Avatar_ID_Rules.Create.passes(Avatar_ID) && isValid;
            isValid = Url_Rules.Create.passes(Url) && isValid;
            isValid = Name_Rules.Create.passes(Name) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Avatar_ID_Rules.Update.passes(Avatar_ID) && isValid;
            isValid = Url_Rules.Update.passes(Url) && isValid;
            isValid = Name_Rules.Update.passes(Name) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid() {
            return true;                    //Always valid for deletion at this level.
        }

        public virtual bool Equivilant(IBusinessUnit comparing) {
            return false;                   //Never equivilant, no unique attributes.
        }
    }
}
