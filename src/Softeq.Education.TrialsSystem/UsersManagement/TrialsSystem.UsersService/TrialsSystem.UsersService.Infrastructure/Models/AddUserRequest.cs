﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialsSystem.UsersService.Infrastructure.Models
{
    public class AddUserRequest
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDateTime { get; set; }

        public decimal Weight { get; set; }

        public decimal Height { get; set; }

    }
}