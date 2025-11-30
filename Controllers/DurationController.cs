using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using static Linca_David_Lab4_MasterEB.DurationPredictionModel;

namespace Linca_David_Lab4_MasterEB.Controllers
{
    public class DurationController : Controller
    {
        public IActionResult Time(ModelInput input)
        {
            MLContext mlContext = new MLContext();

            ITransformer mlModel =
                mlContext.Model.Load(@".\DurationPredictionModel.mlnet", out var modelInputSchema);

            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput,
                ModelOutput>(mlModel);

            ModelOutput result = predEngine.Predict(input);

            ViewBag.Duration = result.Score;

            return View(input);
        }
    }
}