﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCSoft.WX.Framework.Models.ApiResponses
{
    public class DatacubeGetStreamMsgResponse : ApiResponse
    {
        [JsonProperty("list")]
        public IEnumerable<DatacubeMsg> List { get; set; }
    }
}
