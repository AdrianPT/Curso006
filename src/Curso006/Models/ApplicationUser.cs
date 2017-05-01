﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso006.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
