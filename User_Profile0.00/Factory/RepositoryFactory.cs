/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   RepositoryFactory.cs
 |  Purpose:    A singleton which retrieves a repository factory instance.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Factory;
namespace UserProfileLib.Factory{
    public sealed class RepositoryFactory : SqlSRepositoryFactory, IRepositoryFactory{
        private static volatile RepositoryFactory _instance;

        //Prevents the repository from being instatinated twice in concurrent operations.
        private static object _lock = new object();

        private RepositoryFactory() { }

        public static RepositoryFactory Instance{
            get{
                if (_instance == null){
                    //Repository needs instantiated, lock to make sure not done twice.
                    lock (_lock){
                        //If between checking and lock was instanced, do not intantiate.
                        if (_instance == null){
                            //Instantiate the repository.
                            _instance = new RepositoryFactory();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
