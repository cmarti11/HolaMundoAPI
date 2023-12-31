﻿using HolaMundoAPI.API.Data.Models;

namespace HolaMundoAPI.API.Data.Dto
{
    public class UserDto
    {
        public long Id { get; set; }

        public string UserName { get; set; }

        public virtual UserRole Role { get; set; }

        public string Token { get; set; }

    }
}
