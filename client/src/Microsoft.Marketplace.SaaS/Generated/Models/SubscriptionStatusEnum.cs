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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SubscriptionStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionStatusEnum
    {
        [EnumMember(Value = "NotStarted")]
        NotStarted,
        [EnumMember(Value = "PendingFulfillmentStart")]
        PendingFulfillmentStart,
        [EnumMember(Value = "Subscribed")]
        Subscribed,
        [EnumMember(Value = "Suspended")]
        Suspended,
        [EnumMember(Value = "Unsubscribed")]
        Unsubscribed
    }
    internal static class SubscriptionStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this SubscriptionStatusEnum? value)
        {
            return value == null ? null : ((SubscriptionStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SubscriptionStatusEnum value)
        {
            switch( value )
            {
                case SubscriptionStatusEnum.NotStarted:
                    return "NotStarted";
                case SubscriptionStatusEnum.PendingFulfillmentStart:
                    return "PendingFulfillmentStart";
                case SubscriptionStatusEnum.Subscribed:
                    return "Subscribed";
                case SubscriptionStatusEnum.Suspended:
                    return "Suspended";
                case SubscriptionStatusEnum.Unsubscribed:
                    return "Unsubscribed";
            }
            return null;
        }

        internal static SubscriptionStatusEnum? ParseSubscriptionStatusEnum(this string value)
        {
            switch( value )
            {
                case "NotStarted":
                    return SubscriptionStatusEnum.NotStarted;
                case "PendingFulfillmentStart":
                    return SubscriptionStatusEnum.PendingFulfillmentStart;
                case "Subscribed":
                    return SubscriptionStatusEnum.Subscribed;
                case "Suspended":
                    return SubscriptionStatusEnum.Suspended;
                case "Unsubscribed":
                    return SubscriptionStatusEnum.Unsubscribed;
            }
            return null;
        }
    }
}
