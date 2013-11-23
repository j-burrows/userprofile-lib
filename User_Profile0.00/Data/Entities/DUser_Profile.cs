/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DUser_Profile.cs
 |  Purpose:    Defines the data access methods for a user profile.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace UserProfileLib.Data.Entities{
    public class DUser_Profile : UserProfileLib.Business.BUser_Profile, IDataUnit{
        //Primary key used to index in the database
        public int key {
            get { return User_Profile_ID; }
            set { User_Profile_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row){
            //A row of data from a database table is parsed into a user profile.
            User_Profile_ID = row["User_Profile_ID"].ToInt();
            Avatar_ID = row["Avatar_ID"].ToInt();
            username = row["username"].ToStr();
            Short_Alias = row["Short_Alias"].ToStr();
            Long_Alias = row["Long_Alias"].ToStr();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DUser_Profile>(comparing);
        }

        public virtual void Scrub() {
            //All string members have html/sql injection replaced with safe characters.
            username = username.Scrub();
            Short_Alias = Short_Alias.Scrub();
            Long_Alias = Long_Alias.Scrub();
        }
    }
}
