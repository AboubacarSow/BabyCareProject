using System.Text.Json.Serialization;

namespace BabyCareProject.Areas.Admin.Data
{
    public class SendEmailModel
    {
        [JsonPropertyName("Body")]
        public string Body { get; set; }
        [JsonPropertyName("Subject")]
        public string Subject { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
    }
}
