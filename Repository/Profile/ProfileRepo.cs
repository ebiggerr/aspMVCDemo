using System.Collections.Generic;
using System.Linq;
using aspMVCDemo.EF;

namespace aspMVCDemo.Repository.Profile
{
    public class ProfileRepo
    {
        private readonly AspMVCDemoDbContext _context;

        public ProfileRepo(AspMVCDemoDbContext DbContext)
        {
            _context = DbContext;
        }
        
        public List<Models.Profile.Profile> GetAll()
        {
            return _context.Profiles.ToList();
        }
    }
}