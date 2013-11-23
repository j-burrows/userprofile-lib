/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Blocked_User.cs
 |  Purpose:    Defines information about a blocked user.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
namespace UserProfileLib.Base{
    public class Blocked_User{
        public virtual int Blocked_User_ID { get; set; }
        public virtual string Author_Name { get; set; }
        public virtual string username { get; set; }
    }
}
