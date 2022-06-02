using Microsoft.AspNetCore.Mvc;
using RC.ML.AggressionScorerModel;

namespace RC.ML.Aggression.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SentimentController : ControllerBase
    {
        private readonly ILogger<SentimentController> _logger;
        private readonly AggressionScorer _aggressionScorer;

        public SentimentController(ILogger<SentimentController> logger, AggressionScorer aggressionScorer)
        {
            _logger = logger;
            _aggressionScorer = aggressionScorer;
        }

        [HttpGet(Name = "GeSentiment")]
        public async Task<AggressionPrediction>  GetSentiment(string comment)
        {
            return ScoreComment(comment);
        }
        private AggressionPrediction ScoreComment(string comment)
        {
            var classification = _aggressionScorer.Predict(comment);

            return new AggressionPrediction()
            {
                IsAggressive = classification.Prediction,
                Probability = classification.Probability
            };
        }
        
    }
    public class AggressionPrediction
    {
        public bool IsAggressive { get; set; }
        public float Probability { get; set; }
    }

   
}