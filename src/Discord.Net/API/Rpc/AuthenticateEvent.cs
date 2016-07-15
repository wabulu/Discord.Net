﻿using Newtonsoft.Json;
using System;

namespace Discord.API.Rpc
{
    public class AuthenticateEvent
    {
        [JsonProperty("application")]
        public Application Application { get; set; }
        [JsonProperty("expires")]
        public DateTimeOffset Expires { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }
    }
}
