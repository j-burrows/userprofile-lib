/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   User_Profile.cs
 |  Purpose:    Defines an user's profile and its members.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
namespace UserProfileLib.Base{
    public class User_Profile{
        public int User_Profile_ID { get; set; }
        public string username { get; set; }
        public string Short_Alias { get; set; }
        public string Long_Alias { get; set; }
        public int Avatar_ID { get; set; }
        public Avatar avatar { get; set; }
    }
}
