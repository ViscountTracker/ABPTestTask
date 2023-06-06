using Microsoft.AspNetCore.Mvc;

namespace ABPTestTask.Controllers
{
    public class Price
    {   //TODO: create "context" this method responsible for conection DB
        [HttpGet("price")]
        public ActionResult<Experiment> GetPriceExperiment(string deviceToken)//DB connection 
        {
            var experiment = _context.Experiments
                .FirstOrDefault(e => e.DeviceToken == deviceToken && e.Key == "price");

            if (experiment == null)
            {
                // Generate a random price option for the device and store it in the database
                var priceOptions = new List<string> { "10", "20", "50", "5" };
                var randomPrice = priceOptions[new Random().Next(priceOptions.Count)];

                experiment = new Experiment
                {
                    Key = "price",
                    Value = randomPrice,
                    DeviceToken = deviceToken
                };

                _context.Experiments.Add(experiment);
                _context.SaveChanges();
            }

            return experiment;
        }
    }
}
