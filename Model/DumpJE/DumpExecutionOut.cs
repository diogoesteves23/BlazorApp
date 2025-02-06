using System.Text.Json.Serialization;

namespace BlazorApp.Model.DumpJE
{
    public class DumpExecutionOut()
    {
        [JsonPropertyName("data")]
        public List<JobExecutionInfo> JobExecutionList { get; set; } = new();
    }
}
