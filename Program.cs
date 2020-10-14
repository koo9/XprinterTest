using System;
using System.Net;
using System.Runtime.InteropServices;
using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Utilities;

namespace XprinterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter printer IP address: (e.g. 192.168.0.2) default port is 9000");
            var ip = Console.ReadLine();

            var printer = new NetworkPrinter(ip, 9000, true);

            var e = new EPSON();
            printer.Write(ByteSplicer.Combine(
                e.Initialize(),
                e.PrintLine("Hello Xprinter!")
                ));

            Console.Read();
        }
    }
}
