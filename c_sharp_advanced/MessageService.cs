using System;

namespace c_sharp_advanced
{
    public class MessageService
    {
        //public void OnVideoEncoded(object source, EventArgs args)
        //{
        //    Console.WriteLine("MessageService: Sending a text message...");
        //}

        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message... " + args.Video.Title);
        }
    }
}
