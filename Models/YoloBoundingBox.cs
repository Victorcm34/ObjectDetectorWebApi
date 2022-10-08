using System.Drawing;
using ObjectDetectorWebApi.Services;

namespace ObjectDetectorWebApi.Models;

public class YoloBoundingBox
{
    public BoundingBoxDimensions Dimensions { get; set; } = new BoundingBoxDimensions();
    public string Label { get; set; } = "";
    public float Confidence { get; set; }
    public RectangleF Rect { get{ return new RectangleF(Dimensions.X, Dimensions.Y, Dimensions.Width, Dimensions.Height );} }
    public Color BoxColor { get; set; }
}

public class BoundingBoxDimensions : DimensionBase
{
    public BoundingBoxDimensions(){}
    public BoundingBoxDimensions(YoloParser.CellDimensions mappedBoundingBox)
    {
        X = mappedBoundingBox.X - mappedBoundingBox.Width / 2;
        Y = mappedBoundingBox.Y - mappedBoundingBox.Height / 2;
        Width = mappedBoundingBox.Width;
        Height = mappedBoundingBox.Height;
    }
}

    

