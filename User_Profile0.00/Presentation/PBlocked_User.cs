using Repository.Presentation;
namespace UserProfileLib.Presentation{
    public class PBlocked_User : UserProfileLib.Base.Blocked_User, IPresentationUnit{
        public virtual void Format() {
            if(Author_Name==null){
                Author_Name = string.Empty;
            }
            if(username == null){
                username = string.Empty;
            }
        }
    }
}
