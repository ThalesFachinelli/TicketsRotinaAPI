using Microsoft.AspNetCore.Mvc;
using RestEase;
using System;
using System.Threading.Tasks;
using Take.Bot.Safra.RotinaApi.Interfaces;
using Take.Bot.Safra.RotinaApi.Models;

namespace Take.Bot.Safra.RotinaApi.Services
{
    public class GetTicketsService : IGetTicketsService
    {
        private string BaseUri = "https://msging.net";

        public async Task<Ticket> GetTickets()
        {
            Ticket response = new Ticket();
            try
            {
                using (var client = RestClient.For<IBlipAPI>(BaseUri))
                {
                    client.ContentType = "application/json";
                    client.AuthorizationKey = "Key c2FmcmFwYXl2cG8xOkQwV2hFUlFubUVBd1BpMndOUGth";
                    var body = new CommandsRequest();
                    body.Id = Guid.NewGuid().ToString();
                    body.To = "postmaster@desk.msging.net";
                    body.Method = "get";
                    body.Uri = "/tickets?$take=2";
                    response = await client.GetTicketes(body);
                }
            }
            catch (Exception ex)
            {
                var x = 0;
            }

            return response;
        }
    }
}
