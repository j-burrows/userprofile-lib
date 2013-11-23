/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   ProfileService.cs
 |  Purpose:    Defines the main functionality provided by the profile library.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using UserProfileLib.Data.Entities;
using UserProfileLib.Factory;
using UserProfileLib.Presentation;
using System.Linq;
using Repository.Data;
namespace UserProfileLib{
    public class ProfileService : IProfileService{
        public IEnumerable<DAvatar> Avatar_GetList() {
            return RepositoryFactory.Instance.Construct<DAvatar>();
        }

        public DUser_Profile Profile_GetByUser(string username) {
            return RepositoryFactory.Instance.Construct<DUser_Profile>(username)
                .FirstOrDefault();
        }

        public DUser_Profile Profile_Create(DUser_Profile creating, string username) {
            IDataRepository<DUser_Profile> profiles =
                RepositoryFactory.Instance.Construct<DUser_Profile>(username);
            profiles.Create(creating);
            return profiles.FirstOrDefault();
        }

        public DUser_Profile Profile_Update(DUser_Profile updating, string username){
            IDataRepository<DUser_Profile> profiles =
                RepositoryFactory.Instance.Construct<DUser_Profile>(username);
            profiles.Update(updating);
            return profiles.FirstOrDefault();
        }
        
        public void Profile_Delete(DUser_Profile deleting, string username) {
            IDataRepository<DUser_Profile> profiles =
                RepositoryFactory.Instance.Construct<DUser_Profile>(username);
            profiles.Delete(deleting);
        }

        public IEnumerable<DAvatar> Avatar_Create(DAvatar creating) {
            IDataRepository<DAvatar> avatars =
                RepositoryFactory.Instance.Construct<DAvatar>();
            avatars.Create(creating);

            return avatars;
        }
        
        public IEnumerable<DAvatar> Avatar_Update(DAvatar updating){
            IDataRepository<DAvatar> avatars =
                RepositoryFactory.Instance.Construct<DAvatar>();
            avatars.Update(updating);

            return avatars;
        }

        public IEnumerable<DAvatar> Avatar_Delete(DAvatar deleting){
            IDataRepository<DAvatar> avatars =
                RepositoryFactory.Instance.Construct<DAvatar>();
            avatars.Delete(deleting);

            return avatars;
        }

        public IEnumerable<DBlocked_User> Blocked_User_GetByUser(string username){
            return RepositoryFactory.Instance.Construct<DBlocked_User>(username);
        }

        public IEnumerable<DFriended_User> Friended_User_GetByUser(string username){
            return RepositoryFactory.Instance.Construct<DFriended_User>(username);
        }
        public IEnumerable<DBlocked_User> Blocked_User_Create(
            DBlocked_User creating, string username)
        {
            IDataRepository<DBlocked_User> blocked_users = 
                RepositoryFactory.Instance.Construct<DBlocked_User>(username);
            blocked_users.Create(creating);

            return blocked_users;
        }

        public IEnumerable<DBlocked_User> Blocked_User_Update(
            DBlocked_User updating, string username)
        {
            IDataRepository<DBlocked_User> blocked_users =
                RepositoryFactory.Instance.Construct<DBlocked_User>(username);
            blocked_users.Update(updating);

            return blocked_users;
        }

        public IEnumerable<DBlocked_User> Blocked_User_Delete(
            DBlocked_User deleting, string username)
        {
            IDataRepository<DBlocked_User> blocked_users = 
                RepositoryFactory.Instance.Construct<DBlocked_User>(username);
            blocked_users.Delete(deleting);

            return blocked_users;
        }

        public IEnumerable<DFriended_User> Friended_User_Create(
            DFriended_User creating, string username)
        {
            IDataRepository<DFriended_User> friended_users = 
                RepositoryFactory.Instance.Construct<DFriended_User>(username);
            friended_users.Create(creating);

            return friended_users;
        }

        public IEnumerable<DFriended_User> Friended_User_Update(
            DFriended_User updating, string username)
        {
            IDataRepository<DFriended_User> friended_users = 
                RepositoryFactory.Instance.Construct<DFriended_User>(username);
            friended_users.Update(updating);

            return friended_users;
        }

        public IEnumerable<DFriended_User> Friended_User_Delete(
            DFriended_User deleting, string username)
        {
            IDataRepository<DFriended_User> friended_users = 
                RepositoryFactory.Instance.Construct<DFriended_User>(username);
            friended_users.Delete(deleting);

            return friended_users;
        }
    }
}
