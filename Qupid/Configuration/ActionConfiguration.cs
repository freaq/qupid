﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qupid.Configuration
{
    public class ActionConfiguration
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; } = true;

        public string Template { get; set; }

        public ActionConfiguration()
        {

        }
    }
}
