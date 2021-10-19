using System.Collections.Generic;

namespace aspMVCDemo.Repository.Profile
{
    public interface IProfileRepo
    {
        List<Models.Profile.Profile> GetAll();
    }
}