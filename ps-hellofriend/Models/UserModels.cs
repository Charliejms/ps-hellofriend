﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace ps_hellofriend.Models
{
    public class UserModels
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsPremiunUser { get; set; }
    }
}