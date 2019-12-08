using System;

namespace DeleteAgency.Kentico11.ImageMagick.Events
{
    public class ImageMagickImageOptimizerEvents
    {
        public EventHandler<ImageMagickImageOptimizerEventArgs> Before;

        public EventHandler<ImageMagickImageOptimizerEventArgs> After;

        public EventHandler<ImageMagickImageOptimizerEventArgs> Error;
    }
}