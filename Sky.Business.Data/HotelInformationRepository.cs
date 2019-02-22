using System;
using Galaxy.Base;
using Galaxy.Base.Data;

namespace Sky.Business.Data
{
    public class HotelInformationRepository :BusinessObjectRepository<HotelInformation>, IHotelInformationRepository, IBusinessObjectRepository
    {

        public override void Persist()
        {

            Console.Write("Hi this is Persist from sky");
        }

    }

    public class HotelRepository :BusinessObjectRepository<Hotel>, IHotelRepository,IBusinessObjectRepository
    {
        public override void Persist()
        {

            Console.Write("Hotel repository is inject");
        }
    }


}
