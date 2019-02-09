using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace Galaxy.Base.Data.Mapping
{
    public class BusinessInfoMapping : IAutoMappingOverride<BusinessInfo>
    {
        void IAutoMappingOverride<BusinessInfo>.Override(AutoMapping<BusinessInfo> mapping)
        {
            mapping.Id(d => d.Id);
            mapping.Map(s=>s.Name);
        }
    }
}
