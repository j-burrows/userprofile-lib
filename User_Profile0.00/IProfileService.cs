/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   IProfileService.cs
 |  Purpose:    Declares the main functionality provided by the profile library.
 |  Note:       This library is ready to be turned into a web service at any time.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.ServiceModel;
using UserProfileLib.Data.Entities;
using UserProfileLib.Presentation;
namespace UserProfileLib{
    [ServiceContract]
    public interface IProfileService{
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Subroutine: Avatar_GetList
         |  Purpose:    Retrieves a list of all avatars stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DAvatar> Avatar_GetList();

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Subroutine: Profile_GetByUser
         |  Purpose:    Retrieves a single user profile that matches the given username.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        DUser_Profile Profile_GetByUser(string username);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Subroutine: Profile CRUD Methods
         |  Purpose:    Provide create, update, and delete functions which can alter
         |              database collections of user profiles.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        DUser_Profile Profile_Create(DUser_Profile creating, string username);
        [OperationContract]
        DUser_Profile Profile_Update(DUser_Profile updating, string username);

        [OperationContract]
        void Profile_Delete(DUser_Profile deleting, string username);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Subroutine: Avatar CRUD Methods
         |  Purpose:    Provide create, update, and delete functions which can alter
         |              database collections of avatars.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DAvatar> Avatar_Create(DAvatar creating);
        [OperationContract]
        IEnumerable<DAvatar> Avatar_Update(DAvatar updating);
        [OperationContract]
        IEnumerable<DAvatar> Avatar_Delete(DAvatar deleting);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Blocked_User_GetByUser
         |  Purpose:    Retrieves a list of blocked users belonging to a user.
         |  Param:      username            The owner of all targetted blocked users.
         |  Return:     IEnumerable<DBlocked_User> The collection of blocked users belonging
         |                                  to user
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DBlocked_User> Blocked_User_GetByUser(string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Friended_User_GetByUser
         |  Purpose:    Retrieves a list of friended users belonging to a user.
         |  Param:      username            The owner of all targetted friended users.
         |  Return:     IEnumerable<DFriended_User> The collection of friended users 
         |                                  belonging to user
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DFriended_User> Friended_User_GetByUser(string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Blocked_User_Create
         |  Purpose:    Creates a blocked user and returns the resulting collection.
         |  Param:      username            The owner of the targetted blocked user.
         |              creating            The blocked user being created.
         |  Return:     IEnumerable<DEmail> Resulting collection of blocked user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DBlocked_User> Blocked_User_Create(DBlocked_User creating,
                                                       string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Blocked_User_Update
         |  Purpose:    Updates a blocked user and returns the resulting collection.
         |  Param:      username            The owner of the targetted blocked user.
         |              updating            The blocked user being updating.
         |  Return:     IEnumerable<DEmail> Resulting collection of blocked user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DBlocked_User> Blocked_User_Update(DBlocked_User updating,
                                                       string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Blocked_User_Delete
         |  Purpose:    Deletes a blocked user and returns the resulting collection.
         |  Param:      username            The owner of the targetted blocked user.
         |              deleting            The blocked user being deleting.
         |  Return:     IEnumerable<DEmail> Resulting collection of blocked user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DBlocked_User> Blocked_User_Delete(DBlocked_User deleting,
                                                       string username);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Friended_User_Create
         |  Purpose:    Creates a friended user and returns the resulting collection.
         |  Param:      username            The owner of the targetted friended user.
         |              creating            The friended user being deleting.
         |  Return:     IEnumerable<DEmail> Resulting collection of friended user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DFriended_User> Friended_User_Create(DFriended_User creating,
                                                         string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Friended_User_Update
         |  Purpose:    Updates a friended user and returns the resulting collection.
         |  Param:      username            The owner of the targetted friended user.
         |              updating            The friended user being updating.
         |  Return:     IEnumerable<DEmail> Resulting collection of friended user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DFriended_User> Friended_User_Update(DFriended_User updating,
                                                         string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Friended_User_Delete
         |  Purpose:    Deletes a friended user and returns the resulting collection.
         |  Param:      username            The owner of the targetted friended user.
         |              deleting            The friended user being deleting.
         |  Return:     IEnumerable<DEmail> Resulting collection of friended user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DFriended_User> Friended_User_Delete(DFriended_User deleting,
                                                        string username);
    }
}
