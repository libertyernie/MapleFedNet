﻿using Newtonsoft.Json;

namespace MapleFedNet.Model
{
    public class Mention
    {
        /// <summary>
        ///     Account ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        ///     URL of user's profile (can be remote)
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        ///     The username of the account
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        ///     Equals username for local users, includes @domain for remote ones
        /// </summary>
        [JsonProperty("acct")]
        public string AccountName { get; set; }
    }
}