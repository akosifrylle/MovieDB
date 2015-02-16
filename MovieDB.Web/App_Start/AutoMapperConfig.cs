using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieDB.NHibernate.Repo;

namespace MovieDB.Web
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.AddProfile<NHRepoAutoMapperProfile>();
            }
            );
        }
    }
}