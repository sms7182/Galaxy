using System;
using System.Collections.Generic;
using System.Text;
using Galaxy.Base;

namespace Sky.Business
{
   public interface IHotelInformationRepository :IBusinessObjectRepository<HotelInformation>
    {
    }
   public interface IHotelRepository : IBusinessObjectRepository<Hotel>
   {
   }
}
