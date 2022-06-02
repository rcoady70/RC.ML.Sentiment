using Microsoft.Extensions.ML;
using RC.ML.RC.ML.AggressionScorerModel;

namespace RC.ML.AggressionScorerModel
{
    public class AggressionScorer
    {
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;
        
        public AggressionScorer(PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }
        /// <summary>
        /// Predict get sentiment
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ModelOutput Predict(string input) =>
            _predictionEnginePool.Predict(new ModelInput() { Comment = input });

    }
}
