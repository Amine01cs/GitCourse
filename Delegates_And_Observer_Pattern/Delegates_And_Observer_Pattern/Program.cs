using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Observer_Pattern
{
    internal class Program
    {
        public delegate void UploadedVedio(string ChName, string VidTitle);
        static void Main(string[] args)
        {
            YoutubeChannel channel = new YoutubeChannel("Programming Advices");

            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();
            Subscriber subscriber3 = new Subscriber();

            subscriber1.Subscribe(channel);
            subscriber2.Subscribe(channel);
            subscriber3.Subscribe(channel);

            channel.UplouaedNewVideo("React Course ");

            //channel.uploadedVedio("CyberLeeak","Leeaks GTA VI");// Problem 1 : you can jump avoid validation and restruction of youtube content.

            //channel.uploadedVedio = null; // Problem 2 : made any channel to have 0 subscribers .

            channel.UplouaedNewVideo("ASP.NET Crash Course");

        }
        public class YoutubeChannel
        {
            // event KeyWord solve the Two problems above : 
            // Cannot Invoking Direct Without class.
            // Cannot setting to null.

            public event UploadedVedio uploadedVedio;
            public string ChannelName { get; set; }

            public YoutubeChannel(string channelName) { ChannelName = channelName; }
            public void UplouaedNewVideo(string Title)
            {
                Console.WriteLine($"Uploaed Vedio {Title} is successfully");
                if(uploadedVedio != null)
                {
                    uploadedVedio(ChannelName, Title);

                }
                
            }
        }
        public class Subscriber
        {
            
            public void Subscribe(YoutubeChannel channel)
            {
                channel.uploadedVedio += Notification;
            }
            public void Notification(string ChannelName,string VedioTitle)// Handler
            {
                Console.WriteLine($"{ChannelName} Uploaded A New Video with Title {VedioTitle}");
            }
        }
    }
}
