using Newtonsoft.Json;

namespace Take.Bot.Safra.RotinaApi.Models
{
    public class CommandsRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
