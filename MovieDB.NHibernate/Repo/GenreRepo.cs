using System.Collections.Generic;

namespace MovieDB.NHibernate.Repo
{
    public class GenreRepo
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<MovieRepo> Movies { get; set; }
    }
}