// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace.SaaS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubscriberPlan
    {
        /// <summary>
        /// Initializes a new instance of the SubscriberPlan class.
        /// </summary>
        public SubscriberPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriberPlan class.
        /// </summary>
        public SubscriberPlan(string planId = default(string), long? quantity = default(long?))
        {
            PlanId = planId;
            Quantity = quantity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }

    }
}