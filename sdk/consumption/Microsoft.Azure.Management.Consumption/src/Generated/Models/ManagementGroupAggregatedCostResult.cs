// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A management group aggregated cost resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagementGroupAggregatedCostResult : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagementGroupAggregatedCostResult class.
        /// </summary>
        public ManagementGroupAggregatedCostResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagementGroupAggregatedCostResult class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="billingPeriodId">The id of the billing period resource
        /// that the aggregated cost belongs to.</param>
        /// <param name="usageStart">The start of the date time range covered
        /// by aggregated cost.</param>
        /// <param name="usageEnd">The end of the date time range covered by
        /// the aggregated cost.</param>
        /// <param name="azureCharges">Azure Charges.</param>
        /// <param name="marketplaceCharges">Marketplace Charges.</param>
        /// <param name="chargesBilledSeparately">Charges Billed
        /// Separately.</param>
        /// <param name="currency">The ISO currency in which the meter is
        /// charged, for example, USD.</param>
        /// <param name="children">Children of a management group</param>
        /// <param name="includedSubscriptions">List of subscription Guids
        /// included in the calculation of aggregated cost</param>
        /// <param name="excludedSubscriptions">List of subscription Guids
        /// excluded from the calculation of aggregated cost</param>
        public ManagementGroupAggregatedCostResult(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string billingPeriodId = default(string), System.DateTime? usageStart = default(System.DateTime?), System.DateTime? usageEnd = default(System.DateTime?), decimal? azureCharges = default(decimal?), decimal? marketplaceCharges = default(decimal?), decimal? chargesBilledSeparately = default(decimal?), string currency = default(string), IList<ManagementGroupAggregatedCostResult> children = default(IList<ManagementGroupAggregatedCostResult>), IList<string> includedSubscriptions = default(IList<string>), IList<string> excludedSubscriptions = default(IList<string>))
            : base(id, name, type, tags)
        {
            BillingPeriodId = billingPeriodId;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            AzureCharges = azureCharges;
            MarketplaceCharges = marketplaceCharges;
            ChargesBilledSeparately = chargesBilledSeparately;
            Currency = currency;
            Children = children;
            IncludedSubscriptions = includedSubscriptions;
            ExcludedSubscriptions = excludedSubscriptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the billing period resource that the aggregated cost
        /// belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodId")]
        public string BillingPeriodId { get; private set; }

        /// <summary>
        /// Gets the start of the date time range covered by aggregated cost.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStart")]
        public System.DateTime? UsageStart { get; private set; }

        /// <summary>
        /// Gets the end of the date time range covered by the aggregated cost.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEnd")]
        public System.DateTime? UsageEnd { get; private set; }

        /// <summary>
        /// Gets azure Charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureCharges")]
        public decimal? AzureCharges { get; private set; }

        /// <summary>
        /// Gets marketplace Charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplaceCharges")]
        public decimal? MarketplaceCharges { get; private set; }

        /// <summary>
        /// Gets charges Billed Separately.
        /// </summary>
        [JsonProperty(PropertyName = "properties.chargesBilledSeparately")]
        public decimal? ChargesBilledSeparately { get; private set; }

        /// <summary>
        /// Gets the ISO currency in which the meter is charged, for example,
        /// USD.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets or sets children of a management group
        /// </summary>
        [JsonProperty(PropertyName = "properties.children")]
        public IList<ManagementGroupAggregatedCostResult> Children { get; set; }

        /// <summary>
        /// Gets or sets list of subscription Guids included in the calculation
        /// of aggregated cost
        /// </summary>
        [JsonProperty(PropertyName = "properties.includedSubscriptions")]
        public IList<string> IncludedSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets list of subscription Guids excluded from the
        /// calculation of aggregated cost
        /// </summary>
        [JsonProperty(PropertyName = "properties.excludedSubscriptions")]
        public IList<string> ExcludedSubscriptions { get; set; }

    }
}
