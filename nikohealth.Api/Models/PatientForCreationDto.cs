using System.Text.Json.Serialization;
using nikoHealth.Api.Models;

namespace nikohealth.Api.Models
{
    public class PatientForCreationDto
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("DisplayId")]
        public string DisplayId { get; set; }

        [JsonPropertyName("General")] public General General { get; set; }

    }

}
