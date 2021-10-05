using AutoMapper;
using EventBus.Messages.Event;
using Ordering.Application.Features.Orders.Commands.CheckoutOrder;
using System;

namespace Ordering.API.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>()
                .ForMember(x => x.Id, option => option.Ignore())
                //.ForMember(x => x.Id, option => option.MapFrom(y => ))
                //y => y.Id = 0) )
                //MapFrom(y =>   y.Id  ))
                .ReverseMap()
                .ForMember(x => x.Id, option => option.Ignore());
        }
    }

//    1) Int32 => Guid

////given an integer
//int i = -1011576347;
//    //put our int at the beginning of the guid and pad remainder with zeroes
//    Guid guid = new Guid(i, 0, 0, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });

//2) Guid => Int32

////given some Guide
//Guid guid = new Guid("{c3b491e5-59ac-4f6a-81e5-27e971b903ed}");
//    //extract an integer from the beginning of the Guid
//    byte[] _bytes = guid.ToByteArray();
//    int i = ((int)_bytes[0]) | ((int)_bytes[1] << 8) | ((int)_bytes[2] << 16) | ((int)_bytes[3] << 24);

    public class GuidToIntTypeConverter : ITypeConverter<Guid, int>
    {

        public int Convert(Guid source, int destination, ResolutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
