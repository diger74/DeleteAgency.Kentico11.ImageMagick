using ImageMagick;

namespace DeleteAgency.Kentico11.ImageMagick.Optimizations.Interfaces
{
    public interface IOptimization
    {
        void Apply(MagickImage image);
    }
}