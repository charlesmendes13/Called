﻿using Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Interfaces.Services
{
    public interface IUserService
    {       
        Task<AcessToken> GetAcessTokenByLoginAsync(User user);
    }
}
