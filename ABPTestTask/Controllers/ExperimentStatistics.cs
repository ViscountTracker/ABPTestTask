namespace ABPTestTask.Controllers
{
    public class ExperimentStatistics
    {
        public string ExperimentKey { get; set; }
        public int TotalDevices { get; set; }
        public Dictionary<string, int> OptionDistribution { get; set; }
    }
    public class Experiment
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string DeviceToken { get; set; }
    }
}
