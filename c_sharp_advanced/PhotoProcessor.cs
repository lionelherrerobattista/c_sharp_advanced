using System;

namespace c_sharp_advanced
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo); // custom delegate
        //public void Process(string path, PhotoFilterHandler filterHandler) // custom delegate
        public void Process(string path, Action<Photo> filterHandler) // generic delegate
        {
            var photo = Photo.Load(path);

            filterHandler(photo); // delegate being used

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}
