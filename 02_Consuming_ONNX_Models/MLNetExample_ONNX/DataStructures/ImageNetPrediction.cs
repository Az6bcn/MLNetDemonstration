using Microsoft.ML.Data;

namespace MLNetExample_ONNX.DataStructures
{
    public class ImageNetPrediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
}
