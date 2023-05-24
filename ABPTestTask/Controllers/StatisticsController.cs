using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ABPTestTask.Controllers
{
    [Route("statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IExperimentRepository _experimentRepository;//TODO:Fix bugs

        public StatisticsController(IExperimentRepository experimentRepository)
        {
            _experimentRepository = experimentRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExperimentStatistics>> GetStatistics()
        {
            var statistics = _experimentRepository.GetExperimentStatistics();
            return Ok(statistics);
        }
    }
}
}
