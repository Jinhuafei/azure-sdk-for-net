// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for NamespaceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NamespaceType
    {
        [EnumMember(Value = "Messaging")]
        Messaging,
        [EnumMember(Value = "NotificationHub")]
        NotificationHub
    }
    internal static class NamespaceTypeEnumExtension
    {
        internal static string ToSerializedValue(this NamespaceType? value)
        {
            return value == null ? null : ((NamespaceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this NamespaceType value)
        {
            switch( value )
            {
                case NamespaceType.Messaging:
                    return "Messaging";
                case NamespaceType.NotificationHub:
                    return "NotificationHub";
            }
            return null;
        }

        internal static NamespaceType? ParseNamespaceType(this string value)
        {
            switch( value )
            {
                case "Messaging":
                    return NamespaceType.Messaging;
                case "NotificationHub":
                    return NamespaceType.NotificationHub;
            }
            return null;
        }
    }
}
