using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace Galaxy.Base.Data.Mapping
{
    public class FeatureMapping : IAutoMappingOverride<Feature>
    {
        public void Override(AutoMapping<Feature> mapping)
        {
            mapping.Id(s => s.Id);
            mapping.Map(s => s.Name);
            mapping.Map(s => s.Value);
        }
    }
}
