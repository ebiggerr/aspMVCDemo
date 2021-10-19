using System.Collections.Generic;
using aspMVCDemo.Models.Profile;
using aspMVCDemo.Repository.Profile;
using AutoMapper;

namespace aspMVCDemo.Manager.Profile
{
    public class ProfileManager
    {
        private readonly ProfileRepo _profileRepo;
        private IMapper _IMapper;
        private MapperConfiguration config;

        public ProfileManager(ProfileRepo profileRepo)
        {
            _profileRepo = profileRepo;
            this.InitializeMapperConfig();
        }
        
        private void InitializeMapperConfig()
        {
            //singleton
            if (config != null)
            {
            }
            else
            {
                config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Profile.Profile, ProfileDto>());
                _IMapper = config.CreateMapper();
            }
            
        }

        public List<ProfileDto> GetAll()
        {
            var profiles = _profileRepo.GetAll();
            
            return _IMapper.Map<List<Models.Profile.Profile>,List<ProfileDto>>(profiles);
        }
    }
}