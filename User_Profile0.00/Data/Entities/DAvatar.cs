/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DAvatar.cs
 |  Purpose:    Defines the data access methods for an avatar.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace UserProfileLib.Data.Entities{
    public class DAvatar : UserProfileLib.Business.BAvatar, IDataUnit{
        //Primary key used to index in the database
        public int key {
            get { return Avatar_ID; }
            set { Avatar_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row) {
            //A row of data from a database table is parsed into an avatar.
            Avatar_ID = row["Avatar_ID"].ToInt();
            Url = row["Url"].ToStr();
            Name = row["Name"].ToStr();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DAvatar>(comparing);
        }

        public virtual void Scrub() {
            //All string members have html/sql injection replaced with safe characters.
            Url = Url.Scrub();
            Name = Name.Scrub();
        }
    }
}
