using AutoMapper;
using fashionDesignAPI.Dto.Users.Request;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Mapper.Users
{
    public class PostUsersProfile : Profile
    {
        public PostUsersProfile()
        {
            CreateMap<PostUsers, User>().ReverseMap();
        }
    }
}
