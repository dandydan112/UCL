using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using Arvefordeleren_CleanArchitecture.Domain.Entities;

namespace Arvefordeleren_CleanArchitecture.Domain.Interfaces
{
    public interface IGameRepository
    {
        Task<List<Game>> GetAllGamesAsync();
    }
}
