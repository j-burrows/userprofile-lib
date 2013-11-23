/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BBlocked_User.cs
 |  Purpose:    Defines the business logic of a blocked user.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace UserProfileLib.Business{
    public class BBlocked_User : UserProfileLib.Presentation.PBlocked_User, IBusinessUnit{
        public static readonly ProtocolStack Blocked_User_ID_Rules = ProtocolStack.ForKey();
        public static readonly ProtocolStack username_Rules = ProtocolStack.ForUsername();
        public static readonly ProtocolStack Author_Name_Rules = ProtocolStack.WithPremise(
            new Premise { maxLength = 32, nullable = false }, "Author_Name" );

        public virtual bool CreateValid(){
            bool isValid = true;
            isValid = Blocked_User_ID_Rules.Create.passes(Blocked_User_ID) && isValid;
            isValid = username_Rules.Create.passes(username) && isValid;
            isValid = Author_Name_Rules.Create.passes(Author_Name) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Blocked_User_ID_Rules.Update.passes(Blocked_User_ID) && isValid;
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
