namespace ABPTestTask.Controllers
{
    public interface IExperimentRepository
    {
        Experiment GetExperiment(string experimentKey, string deviceToken);
        Experiment CreateExperiment(string experimentKey, string deviceToken);
        IEnumerable<ExperimentStatistics> GetExperimentStatistics();
    }
}
