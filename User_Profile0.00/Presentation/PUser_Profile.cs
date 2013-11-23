/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PUser_Profile.cs
 |  Purpose:    Defines a format function for a user profile.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using UserProfileLib.Base;
using Repository.Presentation;
namespace UserProfileLib.Presentation{
    public class PUser_Profile : UserProfileLib.Base.User_Profile, IPresentationUnit{
        public virtual void Format(){
            if (username == null){
                username = string.Empty;
            }
            if (Short_Alias == null){
                Short_Alias = string.Empty;
            }
            if(Long_Alias == null){
                Long_Alias = string.Empty;
            }
            if (avatar == null){
                avatar = new Avatar();
            }
        }
    }
}
