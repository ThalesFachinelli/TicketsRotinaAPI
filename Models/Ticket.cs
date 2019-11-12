using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Take.Bot.Safra.RotinaApi.Models
{

    public class Item
    {
        public string id { get; set; }
        public int sequentialId { get; set; }
        public string ownerIdentity { get; set; }
        public string customerIdentity { get; set; }
        public string customerDomain { get; set; }
        public string agentIdentity { get; set; }
        public string provider { get; set; }
        public string status { get; set; }
        public DateTime storageDate { get; set; }
        public DateTime openDate { get; set; }
        public DateTime statusDate { get; set; }
        public string externalId { get; set; }
        public int rating { get; set; }
        public string team { get; set; }
        public int unreadMessages { get; set; }
        public bool closed { get; set; }
        public DateTime? closeDate { get; set; }
        public string closedBy { get; set; }
        public List<string> tags { get; set; }
        public DateTime? firstResponseDate { get; set; }
    }

    public class Resource
    {
        public int total { get; set; }
        public string itemType { get; set; }
        public List<Item> items { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("#command.uri")]
        public string command_uri { get; set; }
    }

    public class Ticket
    {
        public string type { get; set; }
        public Resource resource { get; set; }
        public string method { get; set; }
        public string status { get; set; }
        public string id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public Metadata metadata { get; set; }
    }
}

