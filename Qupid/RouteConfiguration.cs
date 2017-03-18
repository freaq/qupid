﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qupid
{
    public class RouteConfiguration
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Prefix { get; set; }

        public string Controller { get; set; }

        public string Resource { get; set; }

        public string Schema { get; set; }

        public string Table { get; set; }

        public readonly List<ColumnConfiguration> Columns = new List<ColumnConfiguration>();

        public readonly List<ActionConfiguration> Actions = new List<ActionConfiguration>();

        public RouteConfiguration()
        {

        }
    }
}