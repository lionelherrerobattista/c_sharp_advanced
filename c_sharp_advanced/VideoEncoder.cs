using System;
using System.Threading;

namespace c_sharp_advanced
{
    public class VideoEncoder
    {

        //1. Define a delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //2. Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; // with arguments
        //public event EventHandler VideoIncoding; // without arguments


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            //OnVideoEncoded(); // raise event
            OnVideoEncoded(video); // raise event
        }

        //3. Raise the event
        //protected virtual void OnVideoEncoded() // convention
        //{
        //    if( VideoEncoded != null) // check if there are any subscribers
        //        VideoEncoded(this, EventArgs.Empty); // call to event like method
        //}
        protected virtual void OnVideoEncoded(Video video) // convention
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video }); // reference to encoded video
        }
    }
}
