using FluentNHibernate.Mapping;
using MovieDB.NHibernate.Repo;

namespace MovieDB.NHibernate.SqlServer.Maps
{
    public class GenreMap : ClassMap<GenreRepo>
    {
        public GenreMap()
        {
            Table("Genre");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}