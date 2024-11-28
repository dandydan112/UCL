using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Arvefordeleren_CleanArchitecture.Domain.Entities;
using Arvefordeleren_CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arvefordeleren_CleanArchitecture.Infrastructure.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly List<Game> _games = new()
        {
            new Game { Id = 1, Name = "The Legend of Zelda", Genre = "Adventure" },
            new Game { Id = 2, Name = "Halo", Genre = "Shooter" },
            new Game { Id = 3, Name = "Minecraft", Genre = "Sandbox" }
        };

        public Task<List<Game>> GetAllGamesAsync()
        {
            return Task.FromResult(_games);
        }
    }
}

