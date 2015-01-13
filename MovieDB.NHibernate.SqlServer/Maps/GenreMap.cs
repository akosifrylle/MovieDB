using MovieDB.NHibernate.Repo;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace MovieDB.NHibernate.SqlServer.Maps
{
    public class GenreMap : ClassMapping<GenreRepo>
    {
        public GenreMap()
        {
            Table("Genre");
            Id(x => x.Id, m=>m.Generator(Generators.Identity));
            Property(x => x.Name);
            Bag(c => c.Movies, m =>
            {
                m.Cascade(Cascade.DeleteOrphans);
                m.Inverse(true);
                m.Key(k => k.Column("Genre_Id"));
                m.Fetch(CollectionFetchMode.Select);
                m.Lazy(CollectionLazy.NoLazy);
            }, ce => ce.OneToMany());
        }
    }
}