// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed identity generic object. </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        public ManagedServiceIdentity()
        {
            Type = "UserAssigned";
        }

        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="type"> Type of the managed identity. </param>
        /// <param name="userAssignedIdentities"> The list of user-assigned managed identities associated with the resource. Key is the Azure resource Id of the managed identity. </param>
        internal ManagedServiceIdentity(string type, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> Type of the managed identity. </summary>
        public string Type { get; set; }
        /// <summary> The list of user-assigned managed identities associated with the resource. Key is the Azure resource Id of the managed identity. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; set; }
    }
}
