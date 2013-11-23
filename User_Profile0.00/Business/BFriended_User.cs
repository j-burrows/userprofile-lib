/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BFriended_User.cs
 |  Purpose:    Defines the business logic of a friended user.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace UserProfileLib.Business{
    public class BFriended_User : UserProfileLib.Presentation.PFriended_User, IBusinessUnit{
        public readonly ProtocolStack Friended_User_ID_Rules = ProtocolStack.ForKey("Friended_User_ID");
        public readonly ProtocolStack username_Rules = ProtocolStack.ForUsername();
        public readonly ProtocolStack Author_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 32}, "Author_Name_Rules");

        public virtual bool CreateValid(){
            bool isValid = true;
            isValid = Friended_User_ID_Rules.Create.passes(Friended_User_ID) && isValid;
            isValid = username_Rules.Create.passes(username) && isValid;
            isValid = Author_Name_Rules.Create.passes(Author_Name) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Friended_User_ID_Rules.Update.passes(Friended_User_ID) && isValid;
            isValid = username_Rules.Update.passes(username) && isValid;
            isValid = Author_Name_Rules.Update.passes(Author_Name) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid(){
            return true;
        }

        public virtual bool Equivilant(IBusinessUnit comparing){
            return false;
        }
    }
}
