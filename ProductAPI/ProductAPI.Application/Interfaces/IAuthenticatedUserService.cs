using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAPI.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
