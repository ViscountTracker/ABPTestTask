using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ABPTestTask.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("experiment")]
    [ApiController]
    public class ExperimentController : ControllerBase//TODO: FIX BUGS
    {
        private readonly IExperimentRepository _experimentRepository;

        public ExperimentController(IExperimentRepository experimentRepository)
        {
            _experimentRepository = experimentRepository;
        }
    }

    //TODO: Fix bugs in this code.
    /// <summary>
    ///
    /// </summary>
    /// <param name="expirementKey"></param>
    /// <param name="deviceTekon"></param>
    /// <returns></returns>
    [HttpGet("experiment")]
    public ActionResult<Experiment> GetExperiment(string expirementKey, [FromQuery] string deviceTekon) 
    {
        var experiment = _experimentRepository.GetExperiment(experimentKey, deviceToken);
        if (experiment == null)
        {
            // Create new experiment for the device token
            var newExperiment = _experimentRepository.CreateExperiment(experimentKey, deviceToken);
            return Ok(newExperiment);
        }
        else
        {
            return Ok(experiment);
        }
    }

}
