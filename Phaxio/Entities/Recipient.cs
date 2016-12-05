using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phaxio.Entities
{
    public class Recipient
    {
        [DeserializeAs(Name = "number")]
        public string Number { get; set; }

        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        [DeserializeAs(Name = "completed_at")]
        public long CompletedAt { get; set; }

        [DeserializeAs(Name = "error_code")]
        public string ErrorCode { get; set; }

        [DeserializeAs(Name = "error_type")]
        public string ErrorType { get; set; }
    }
}
