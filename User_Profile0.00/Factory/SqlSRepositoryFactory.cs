/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSRepositoryFactory.cs
 |  Purpose:    A factory which constructs collections of different data units which can
 |              communicate with an sql server database.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System;
using UserProfileLib.Base;
using UserProfileLib.Data.Repositories;
using Repository.Data;
using Repository.Factory;
using Repository.Helpers;
namespace UserProfileLib.Factory{
    public class SqlSRepositoryFactory : IRepositoryFactory{
        public IDataRepository<T> Construct<T>(params object[] args) where T : IDataUnit{
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Avatar))){
                //In the hierarchy tree of blocked user, a repository of it is built.
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSAvatarRepository), args);
            }
            if (Polymorphism.IsInHierachy(typeof(T), typeof(User_Profile))){
                //In the hierarchy tree of friendly user, a repository of it is built.
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSUser_ProfileRepository), args);
            }
            return null;
        }
    }
}
