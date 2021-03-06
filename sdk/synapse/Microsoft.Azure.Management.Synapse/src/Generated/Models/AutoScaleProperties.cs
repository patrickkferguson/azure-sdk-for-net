// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Spark pool auto-scaling properties
    /// </summary>
    /// <remarks>
    /// Auto-scaling properties of a Big Data pool powered by Apache Spark
    /// </remarks>
    public partial class AutoScaleProperties
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleProperties class.
        /// </summary>
        public AutoScaleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaleProperties class.
        /// </summary>
        /// <param name="minNodeCount">The minimum number of nodes the Big Data
        /// pool can support.</param>
        /// <param name="enabled">Whether automatic scaling is enabled for the
        /// Big Data pool.</param>
        /// <param name="maxNodeCount">The maximum number of nodes the Big Data
        /// pool can support.</param>
        public AutoScaleProperties(int? minNodeCount = default(int?), bool? enabled = default(bool?), int? maxNodeCount = default(int?))
        {
            MinNodeCount = minNodeCount;
            Enabled = enabled;
            MaxNodeCount = maxNodeCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum number of nodes the Big Data pool can
        /// support.
        /// </summary>
        [JsonProperty(PropertyName = "minNodeCount")]
        public int? MinNodeCount { get; set; }

        /// <summary>
        /// Gets or sets whether automatic scaling is enabled for the Big Data
        /// pool.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of nodes the Big Data pool can
        /// support.
        /// </summary>
        [JsonProperty(PropertyName = "maxNodeCount")]
        public int? MaxNodeCount { get; set; }

    }
}
