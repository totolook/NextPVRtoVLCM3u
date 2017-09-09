using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using NextpvrtoVlc.Model;

namespace NextpvrtoVlc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to XML NextPVR to M3U Converter");
            Console.WriteLine("Author: Antonio di Giovanni (Totolook) Version: 0.01");
            //if (args[0] == null) {
                Console.Write("Please,specify the xml file to convert: ");
                String filename = Console.ReadLine();
            //}

            XmlSerializer serializer = new XmlSerializer(typeof(Channels));
          

            FileStream fs = new FileStream(filename, FileMode.Open);
            Channels ch;
            ch = (Channels)serializer.Deserialize(fs);
            StringBuilder m3u = new StringBuilder();
            foreach (var p in ch.Channel)
            {
                Console.WriteLine("["+p.Number+"] Name= "+ p.Name+" Frequency= "+p.Tuning.Locator.Frequency+" Programm= "+ p.Tuning.Service_id);
                m3u.Append(vlcM3U.coverted(p.Name, p.Tuning.Locator.Frequency, p.Tuning.Service_id));
            }
            Console.WriteLine(m3u.ToString());
            FileStream m3uOut = new FileStream(fs.Name + "-Converted.m3u", FileMode.Create);
            byte[] buffer = new UTF8Encoding(true).GetBytes(m3u.ToString());
            m3uOut.Write(buffer, 0, buffer.Length);
            Console.ReadLine();





        }
     
    }
}

