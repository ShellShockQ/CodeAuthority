using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.BusinessLogic.Helpers
{
    using Newtonsoft.Json;

    public class CaptchaResponse
    {
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public IList<string> ErrorCodes { get; set; }
    }
}
