using Microsoft.AspNetCore.Mvc;

namespace ABPTestTask.Controllers
{
    public class ButtonColor
    {
        [HttpGet("button-color")]
        public ActionResult<Experiment> GetButtonColorExperiment(string deviceToken)
        {
            var experiment = _context.Experiments
                .FirstOrDefault(e => e.DeviceToken == deviceToken && e.Key == "button_color");

            if (experiment == null)
            {
                // Generate a random button color for the device and store it in the database
                var buttonColors = new List<string> { "#FF0000", "#00FF00", "#0000FF" };
                var randomColor = buttonColors[new Random().Next(buttonColors.Count)];

                experiment = new Experiment
                {
                    Key = "button_color",
                    Value = randomColor,
                    DeviceToken = deviceToken
                };

                _context.Experiments.Add(experiment);
                _context.SaveChanges();
            }

            return experiment;
        }
    }
}
