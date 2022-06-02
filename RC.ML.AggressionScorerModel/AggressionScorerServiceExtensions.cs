using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ML;
using RC.ML.RC.ML.AggressionScorerModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RC.ML.AggressionScorerModel
{
    public static class AggressionScorerServiceExtensions
    {
        //Use retrained model AggressionScoreModel is input to the retaining so will not work.
        private static readonly string _modelFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MLModel", "AggressionScoreRetrainedModel.zip");

        public static void AddAggressionScorerPredictionEnginePool(this IServiceCollection services)
        {
            //User engine pool as predict engine is not thread safe.
            services.AddPredictionEnginePool<ModelInput, ModelOutput>()
                                            .FromFile(filePath: _modelFile, watchForChanges: true);
        }
    }
}
