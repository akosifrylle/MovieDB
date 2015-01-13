using MovieDB.NHibernate.Repo;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace MovieDB.NHibernate.SqlServer.Maps
{
    public class MovieMap : ClassMapping<MovieRepo>
    {
        public MovieMap()
        {
            Table("Movie");
            Id(x => x.Id, m=>m.Generator(Generators.Identity));
            Property(x => x.Title);
            Property(x => x.Description);
            Property(x=>x.Category);
            Property(x => x.ReleaseDate);
            Property(x => x.Rating, m => m.Column(c => c.SqlType("NUMERIC(19,5)")));
            ManyToOne(x => x.Genre, m =>
            {
                m.Column("Genre_Id");
                m.Cascade(Cascade.None);
                m.Lazy(LazyRelation.NoLazy);
                m.Fetch(FetchKind.Select);
            });
            //ManyToOne(x => x.ProductionCompany, m =>
            //{
            //    m.Column("Genre_Id");
            //    m.Cascade(Cascade.None);
            //    m.Lazy(LazyRelation.NoLazy);
            //    m.Fetch(FetchKind.Select);
            //});
        }
    }
}
