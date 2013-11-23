/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Friended_User.cs
 |  Purpose:    Defines information about a friended user.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
namespace UserProfileLib.Base{
    public class Friended_User{
        public virtual int Friended_User_ID { get; set; }
        public virtual string Author_Name { get; set; }
        public virtual string username { get; set; }
    }
}
