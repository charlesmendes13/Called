﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Application.Dto
{
    public class UpdateUserDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
