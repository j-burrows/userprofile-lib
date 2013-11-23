/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSUser_ProfileRepository.cs
 |  Purpose:    Collection of user profile's which interacts with an sql server database.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using UserProfileLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace UserProfileLib.Data.Repositories{
    public class SqlSUser_ProfileRepository : SqlSRepository<DUser_Profile>{
        public SqlSUser_ProfileRepository(string username) : base() {
            //The collection is filled with every user profile associated with given user.
            string query = string.Format(
                @"EXEC Account.User_Profile_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DUser_Profile creating){
            SqlCommand cmd = new SqlCommand("Account.User_Profile_Create");
            cmd.AddParam("username", creating.username);
            cmd.AddParam("Short_Alias", creating.Short_Alias);
            cmd.AddParam("Long_Alias", creating.Long_Alias);
            cmd.AddParam("Avatar_ID", creating.Avatar_ID);

            //The entry is created in the database.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is created in main memory collection.
        }

        protected override void UpdateEval(DUser_Profile updating){
            SqlCommand cmd = new SqlCommand("Account.User_Profile_Delete");
            cmd.AddParam("User_Profile_ID", updating.User_Profile_ID);
            cmd.AddParam("Avatar_ID", updating.Avatar_ID);
            cmd.AddParam("Short_Alias", updating.Short_Alias);
            cmd.AddParam("Long_Alias", updating.Long_Alias);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }

        protected override void DeleteEval(DUser_Profile deleting){
            SqlCommand cmd = new SqlCommand("Account.User_Profile_Delete");
            cmd.AddParam("User_Profile_ID", deleting.User_Profile_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
