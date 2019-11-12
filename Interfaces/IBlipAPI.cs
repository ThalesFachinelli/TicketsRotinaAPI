using Microsoft.AspNetCore.Mvc;
using RestEase;
using System;
using System.Threading.Tasks;
using Take.Bot.Safra.RotinaApi.Models;

namespace Take.Bot.Safra.RotinaApi.Interfaces
{
    public interface IBlipAPI : IDisposable
    {
        [Header("Authorization")]
        string AuthorizationKey { get; set; }

        [Header("Content-Type")]
        string ContentType { get; set; }

        [Post("/commands")]
        Task<Ticket> GetTicketes([Body]CommandsRequest body);
    }
}
