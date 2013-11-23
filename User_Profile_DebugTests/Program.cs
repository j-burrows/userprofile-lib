using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfileLib;
using UserProfileLib.Data.Entities;
using UserProfileLib.Factory;
using UserProfileLib.Presentation;
using Repository.Data;

namespace UserProfileLibDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository.Configuration.connString = "Server=localhost;Database=ApplicationData;Trusted_Connection=True;";

            IDataRepository<DUser_Profile> repo = RepositoryFactory.Instance.Construct<DUser_Profile>("user");
            IProfileService service = new ProfileService();
            IEnumerable<PAvatar> m = service.Avatar_Delete(new DAvatar { key = 1 });
            Console.WriteLine(m.Count());
        }
    }
}
