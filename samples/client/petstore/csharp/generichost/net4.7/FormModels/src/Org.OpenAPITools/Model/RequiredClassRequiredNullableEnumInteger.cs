// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines RequiredClass_required_nullable_enum_integer
    /// </summary>
    public enum RequiredClassRequiredNullableEnumInteger
    {
        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_MINUS_1 for value: -1
        /// </summary>
        NUMBER_MINUS_1 = -1
    }

    /// <summary>
    /// Converts <see cref="RequiredClassRequiredNullableEnumInteger"/> to and from the JSON value
    /// </summary>
    public static class RequiredClassRequiredNullableEnumIntegerValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="RequiredClassRequiredNullableEnumInteger"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RequiredClassRequiredNullableEnumInteger FromString(string value)
        {
            if (value.Equals((1).ToString()))
                return RequiredClassRequiredNullableEnumInteger.NUMBER_1;

            if (value.Equals((-1).ToString()))
                return RequiredClassRequiredNullableEnumInteger.NUMBER_MINUS_1;

            throw new NotImplementedException($"Could not convert value to type RequiredClassRequiredNullableEnumInteger: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="RequiredClassRequiredNullableEnumInteger"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RequiredClassRequiredNullableEnumInteger? FromStringOrDefault(string value)
        {
            if (value.Equals((1).ToString()))
                return RequiredClassRequiredNullableEnumInteger.NUMBER_1;

            if (value.Equals((-1).ToString()))
                return RequiredClassRequiredNullableEnumInteger.NUMBER_MINUS_1;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RequiredClassRequiredNullableEnumInteger"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int ToJsonValue(RequiredClassRequiredNullableEnumInteger value)
        {
            return (int) value;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="RequiredClassRequiredNullableEnumInteger"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class RequiredClassRequiredNullableEnumIntegerJsonConverter : JsonConverter<RequiredClassRequiredNullableEnumInteger>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override RequiredClassRequiredNullableEnumInteger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            RequiredClassRequiredNullableEnumInteger? result = rawValue == null
                ? null
                : RequiredClassRequiredNullableEnumIntegerValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the RequiredClassRequiredNullableEnumInteger to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="requiredClassRequiredNullableEnumInteger"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, RequiredClassRequiredNullableEnumInteger requiredClassRequiredNullableEnumInteger, JsonSerializerOptions options)
        {
            writer.WriteStringValue(requiredClassRequiredNullableEnumInteger.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="RequiredClassRequiredNullableEnumInteger"/>
    /// </summary>
    public class RequiredClassRequiredNullableEnumIntegerNullableJsonConverter : JsonConverter<RequiredClassRequiredNullableEnumInteger?>
    {
        /// <summary>
        /// Returns a RequiredClassRequiredNullableEnumInteger from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override RequiredClassRequiredNullableEnumInteger? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            RequiredClassRequiredNullableEnumInteger? result = rawValue == null
                ? null
                : RequiredClassRequiredNullableEnumIntegerValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="requiredClassRequiredNullableEnumInteger"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, RequiredClassRequiredNullableEnumInteger? requiredClassRequiredNullableEnumInteger, JsonSerializerOptions options)
        {
            writer.WriteStringValue(requiredClassRequiredNullableEnumInteger?.ToString() ?? "null");
        }
    }
}
