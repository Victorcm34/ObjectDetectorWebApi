using ObjectDetectorWebApi.Models;

namespace ObjectDetectorWebApi.Interfaces
{
    public interface IYoloParser
    {
        public float[] ExtractClasses(float[] modelOutput, int x, int y, int channel);
        public IEnumerable<YoloBoundingBox> ParseOutputs(float[] yoloModelOutputs, float threshold = .3f);
        public IEnumerable<YoloBoundingBox> FilterBoundingBoxes(IEnumerable<YoloBoundingBox> boxes, int limit, float threshold);
    }
}