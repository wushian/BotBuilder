// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Object of schema.org types
    /// </summary>
    public partial class Entity
    {
        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Entity() { }

        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Entity(string type = default(string))
        {
            Type = type;
        }

        /// <summary>
        /// Entity Type (typically from schema.org types)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
