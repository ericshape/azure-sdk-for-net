// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class DeviceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DeviceVendor != null)
            {
                writer.WritePropertyName("deviceVendor");
                writer.WriteStringValue(DeviceVendor);
            }
            if (DeviceModel != null)
            {
                writer.WritePropertyName("deviceModel");
                writer.WriteStringValue(DeviceModel);
            }
            if (LinkSpeedInMbps != null)
            {
                writer.WritePropertyName("linkSpeedInMbps");
                writer.WriteNumberValue(LinkSpeedInMbps.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeviceProperties DeserializeDeviceProperties(JsonElement element)
        {
            string deviceVendor = default;
            string deviceModel = default;
            int? linkSpeedInMbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceVendor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceModel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeedInMbps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkSpeedInMbps = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeviceProperties(deviceVendor, deviceModel, linkSpeedInMbps);
        }
    }
}