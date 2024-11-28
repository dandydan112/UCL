using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Arvefordeleren_CleanArchitecture.Domain.Entities;
using Arvefordeleren_CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arvefordeleren_CleanArchitecture.Application.UseCases
{
    public class GetGamesUseCase
    {
        private readonly IGameRepository _repository;

        public GetGamesUseCase(IGameRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Game>> ExecuteAsync()
        {
            return await _repository.GetAllGamesAsync();
        }
    }
}

