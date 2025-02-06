using System.Text.Json.Serialization;

namespace BlazorApp.Model.DumpJE
{
    public class JobExecutionInfo()
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("jobId")]
        public long JobId { get; set; }

        [JsonPropertyName("schedulledDate")]
        public DateTime SchedulledDate { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("businessDate")]
        public DateTime BusinessDate { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("jobStatus")]
        public int JobStatus { get; set; }

        [JsonPropertyName("lastExecution")]
        public DateTime? LastExecution { get; set; }

        [JsonPropertyName("jobSequence")]
        public long JobSequence { get; set; }
    }
}
