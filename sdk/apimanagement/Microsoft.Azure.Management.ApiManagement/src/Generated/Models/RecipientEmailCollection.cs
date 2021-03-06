// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Paged Recipient User list representation.
    /// </summary>
    public partial class RecipientEmailCollection
    {
        /// <summary>
        /// Initializes a new instance of the RecipientEmailCollection class.
        /// </summary>
        public RecipientEmailCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecipientEmailCollection class.
        /// </summary>
        /// <param name="value">Page values.</param>
        /// <param name="nextLink">Next page link if any.</param>
        public RecipientEmailCollection(IList<RecipientEmailContract> value = default(IList<RecipientEmailContract>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets page values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<RecipientEmailContract> Value { get; set; }

        /// <summary>
        /// Gets or sets next page link if any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
