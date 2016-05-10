using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phaxio.Entities
{
    public class Recipients
    {
        [DeserializeAs(Name = "number")]
        public string Number { get; set; }

        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        [DeserializeAs(Name = "completed_at")]
        public long CompletedAt { get; set; }
    }
}
