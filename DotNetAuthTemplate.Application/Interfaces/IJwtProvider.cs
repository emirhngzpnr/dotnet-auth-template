using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAuthTemplate.Domain.Entities;

namespace DotNetAuthTemplate.Application.Interfaces
{
    public interface IJwtProvider
    {
        string GenerateToken(User user
            );
    }
}
