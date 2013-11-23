/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DBlocked_User.cs
 |  Purpose:    Defines the data access logic of a blocked user.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Data;
using Repository.Helpers;
namespace UserProfileLib.Data.Entities{
    public class DBlocked_User: UserProfileLib.Business.BBlocked_User, IDataUnit{
        //Primary key used for indexing in the database.
        public int key {
            get { return Blocked_User_ID; }
            set { Blocked_User_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(System.Data.DataRow row){
            //Row from the database is parsed into a blocked user.
            Blocked_User_ID = row["Blocked_User_ID"].ToInt();
            Author_Name = row["Author_Name"].ToStr();
            username = row["username"].ToStr();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DBlocked_User>(comparing);
        }

        public void Scrub() {
            //All string members are scrubbed.
            Author_Name = Author_Name.Scrub();
            username = username.Scrub();
        }
    }
}
