using System.Collections.Generic;
using aspMVCDemo.Models.Profile;

namespace aspMVCDemo.Manager.Profile
{
    public interface IProfileManager
    {
        List<ProfileDto> GetAll();
    }
}