﻿using System;
using System.Linq;
using System.Reflection;

namespace APP_CONFIG.Common
{
    public enum DeviceType
    {
        [StringValue("Verifone Device")]
        Verifone = 1,
        [StringValue("IdTech Device")]
        IdTech = 2,
        [StringValue("Simulator Device")]
        Simulator = 3,
        [StringValue("Mock Device")]
        Mock = 4,
        [StringValue("NoDevice")]
        NoDevice = 5
    }

    public enum DeviceEvent
    {
        [StringValue("None")]
        None,
        [StringValue("Device plugged")]
        DevicePlugged,
        [StringValue("Device unplugged")]
        DeviceUnplugged,
        [StringValue("Cancel key pressed")]
        CancelKeyPressed,
        [StringValue("ZIP code entered")]
        ZIPCodeEntered,
        [StringValue("PIN entered")]
        PINEntered,
        [StringValue("Request timeout")]
        RequestTimeout,
        [StringValue("Cancellation request")]
        CancellationRequest
    }

    public enum DeviceDiscovery
    {
        [StringValue("Unable to get a device")]
        NoDeviceAvailable = 1
    }

    [System.AttributeUsage(System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class StringValueAttribute : Attribute
    {
        private readonly string _value;
        public StringValueAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        public static string GetStringValue(Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            Type type = value.GetType();
            FieldInfo fi = type.GetRuntimeField(value.ToString());
            return (fi.GetCustomAttributes(typeof(StringValueAttribute), false).FirstOrDefault() as StringValueAttribute).Value;
        }
    }
}
