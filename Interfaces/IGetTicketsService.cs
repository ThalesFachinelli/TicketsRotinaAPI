using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Take.Bot.Safra.RotinaApi.Models;

namespace Take.Bot.Safra.RotinaApi.Interfaces
{
    public interface IGetTicketsService
    {
        Task<Ticket> GetTickets();
    }
}
