using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Models;

namespace api.Repositories
{
    public class AppFileRepository : IAppFileRepository
    {
        public Task<AppFile> CreateAsync(AppFile file)
        {
            throw new NotImplementedException();
        }
    }
}