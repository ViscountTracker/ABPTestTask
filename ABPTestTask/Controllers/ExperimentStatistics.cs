namespace ABPTestTask.Controllers
{
    public class ExperimentStatistics
    {
        public string ExperimentKey { get; set; }
        public int TotalDevices { get; set; }
        public Dictionary<string, int> OptionDistribution { get; set; }
    }
}
