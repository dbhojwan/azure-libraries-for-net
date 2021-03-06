// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Kubernetes add-on profile for a managed cluster.
    /// </summary>
    public partial class ManagedClusterAddonProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterAddonProfile class.
        /// </summary>
        public ManagedClusterAddonProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterAddonProfile class.
        /// </summary>
        /// <param name="enabled">Whether the add-on is enabled or not.</param>
        /// <param name="config">Key-value pairs for configuring an
        /// add-on.</param>
        public ManagedClusterAddonProfile(bool enabled, IDictionary<string, string> config = default(IDictionary<string, string>))
        {
            Enabled = enabled;
            Config = config;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the add-on is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs for configuring an add-on.
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public IDictionary<string, string> Config { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
