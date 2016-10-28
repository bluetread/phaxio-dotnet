﻿using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phaxio.Entities
{
    public class Result
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string Id { get; set; }
    }
}
