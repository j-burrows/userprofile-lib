using Repository.Presentation;
namespace UserProfileLib.Presentation{
    public class PFriended_User : UserProfileLib.Base.Friended_User, IPresentationUnit{
        public virtual void Format(){
            if (Author_Name == null){
                Author_Name = string.Empty;
            }
            if (username == null){
                username = string.Empty;
            }
        }
    }
}
