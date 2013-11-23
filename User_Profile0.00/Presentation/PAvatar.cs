/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PAvatar.cs
 |  Purpose:    Defines a format function for an avatar.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Presentation;
namespace UserProfileLib.Presentation{
    public class PAvatar : UserProfileLib.Base.Avatar, IPresentationUnit{
        public virtual void Format() { 
            if(Url == null){
                Url = string.Empty;
            }
            if (Name == null){
                Name = string.Empty;
            }
        }
    }
}
