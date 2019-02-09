using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;


namespace Galaxy.Base.Data
{
    public class GalaxyNhibernate
    {
        private ISession session;
        public ISession Session
        {
            get
            {
                if (session != null)
                {
                    return session;
                }

                session = GetSessionFactory().OpenSession();
               
                return session;
            }
        }

        public ISessionFactory GetSessionFactory()
        {
            var cfg = new Configuration();
    
            
             var buildSessionFactory = Fluently.Configure(cfg).Database(MsSqlConfiguration.MsSql2012.ConnectionString(""))
                .Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<BusinessObject>()))
                .BuildSessionFactory();
            return buildSessionFactory;
        }
    }
}
