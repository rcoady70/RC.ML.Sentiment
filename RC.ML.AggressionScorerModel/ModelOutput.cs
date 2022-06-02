using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.ML.RC.ML.AggressionScorerModel
{
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }
        public float Probability { get; set; }
    }
}
