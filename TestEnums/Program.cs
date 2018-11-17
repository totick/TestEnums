using System;

namespace TestEnums
{

    enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    };

    class MainClass
    {
        public static void Main(string[] args)
        {
            ShippingMethod method = ShippingMethod.RegisteredAirMail;
            //Writes RegisteredAirMail. WriteLine calls the ToString() method
            Console.WriteLine(method);

            //Writes 2
            Console.WriteLine((int)method);

            //Writes Express
            Console.WriteLine((ShippingMethod)3);

            int methodId = 1;
            //Writes RegularAirMail
            Console.WriteLine((ShippingMethod)methodId);

            string methodName = "RegularAirMail";
            //Parsing string to a ShippingMethod type
            var m = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            //Writes RegularAirMail
            Console.WriteLine(m);
        }
    }
}
