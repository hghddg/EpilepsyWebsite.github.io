using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Client.Static
{
    public static class Endpoint
    {

        private static readonly string Prefix = "api";

        public static readonly string AttractionsEndpoint = $"{Prefix}/attractions";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string CountryEndpoint = $"{Prefix}/countries";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string HotelEndpoint = $"{Prefix}/hotels";
        public static readonly string ItinerariesEndpoint = $"{Prefix}/itineraries";
        public static readonly string ItenaryItemsEndpoint = $"{Prefix}/itenanryitems";
        public static readonly string LocationEndpoint = $"{Prefix}/locations";
        public static readonly string PaymentEndpoint = $"{Prefix}/payments";
    }
}
