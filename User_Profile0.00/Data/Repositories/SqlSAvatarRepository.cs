/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSAvatarRepository.cs
 |  Purpose:    Collection of avatars which can communicate with an sql server database.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using UserProfileLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
using System.Data;
using System.Data.SqlClient;
namespace UserProfileLib.Data.Repositories{
    public class SqlSAvatarRepository : SqlSRepository<DAvatar>{
        public SqlSAvatarRepository() : base() {
            //The collection is filled with every avatar stored in the database.
            string query = "EXEC Account.Avatar_GetList;";
            FillRepository(query);
        }

        protected override void CreateEval(DAvatar creating){
            SqlCommand cmd = new SqlCommand("Account.Avatar_Create");
            cmd.AddParam("Url", creating.Url);
            cmd.AddParam("Name", creating.Name);

            //The entry is created in the database.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is created in main memory collection.
        }

        protected override void UpdateEval(DAvatar updating){
            SqlCommand cmd = new SqlCommand("Account.Avatar_Update");
            cmd.AddParam("Avatar_ID", updating.Avatar_ID);
            cmd.AddParam("Url", updating.Url);
            cmd.AddParam("Name", updating.Name);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }

        protected override void DeleteEval(DAvatar deleting){
            SqlCommand cmd = new SqlCommand("Account.Avatar_Delete");
            cmd.AddParam("Avatar_ID", deleting.Avatar_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
