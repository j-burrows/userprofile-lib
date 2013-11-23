/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DFriended_User.cs
 |  Purpose:    Defines the data access logic of a friended user.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace UserProfileLib.Data.Entities{
    public class DFriended_User : UserProfileLib.Business.BFriended_User, IDataUnit{
        //Primary key used for indexing in the database.
        public int key {
            get { return Friended_User_ID; }
            set { Friended_User_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row){
            //Row from the database is parsed into a blocked user.
            Friended_User_ID = row["Friended_User_ID"].ToInt();
            Author_Name = row["Author_Name"].ToStr();
            username = row["username"].ToStr();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DFriended_User>(comparing);
        }

        public void Scrub() {
            //All string members are scrubbed.
            Author_Name = Author_Name.Scrub();
            username = username.Scrub();
        }
    }
}
