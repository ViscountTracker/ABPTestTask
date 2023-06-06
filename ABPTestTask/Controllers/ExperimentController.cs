using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ABPTestTask.Controllers
{

    [Route("api/experiment")]
    [ApiController]
    public class ExperimentController : ControllerBase
    {
        private readonly IExperimentRepository _experimentRepository;

        public ExperimentController(IExperimentRepository experimentRepository)
        {
            _experimentRepository = experimentRepository;
        }

    }
    //experimentRepository TODO: create new method use this name

    //TODO: Fix bugs in this code.
    [HttpGet("experiment")]
    public ActionResult<Experiment> GetExperiment(string expirementKey, [FromQuery] string deviceToken) 
    {
        var experiment = _experimentRepository.GetExperiment(expirementKey, deviceToken);
        if (experiment == null)
        {
            // Create new experiment for the device token
            var newExperiment = _experimentRepository.CreateExperiment(expirementKey, deviceToken);
            return Ok(newExperiment);
        }
        else
        {
            return Ok(experiment);
        }
    }
}
