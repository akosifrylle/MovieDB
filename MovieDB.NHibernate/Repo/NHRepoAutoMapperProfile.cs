using AutoMapper;

namespace MovieDB.NHibernate.Repo
{
    public class NHRepoAutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Genre, GenreRepo>();
            Mapper.CreateMap<GenreRepo, Genre>();
            Mapper.CreateMap<Movie, MovieRepo>();
            Mapper.CreateMap<MovieRepo, Movie>();
            Mapper.CreateMap<User, UserRepo>();
            Mapper.CreateMap<UserRepo, User>();
        }
    }
}
