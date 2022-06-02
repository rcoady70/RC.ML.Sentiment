using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.ML.RC.ML.AggressionScorerModel
{
    public class ModelInput
    {
        [LoadColumn(1)]
        public string Comment { get; set; }
        [LoadColumn(0),ColumnName("Label")]
        public bool IsAggressive { get; set; }
    }
}
