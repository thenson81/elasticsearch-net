// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public sealed partial class DelimitedPayloadTokenFilter : ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("delimiter")]
		public string? Delimiter { get; set; }

		[JsonInclude]
		[JsonPropertyName("encoding")]
		public Elastic.Clients.Elasticsearch.Analysis.DelimitedPayloadEncoding? Encoding { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "delimited_payload";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; set; }
	}

	public sealed partial class DelimitedPayloadTokenFilterDescriptor : SerializableDescriptorBase<DelimitedPayloadTokenFilterDescriptor>, IBuildableDescriptor<DelimitedPayloadTokenFilter>
	{
		internal DelimitedPayloadTokenFilterDescriptor(Action<DelimitedPayloadTokenFilterDescriptor> configure) => configure.Invoke(this);
		public DelimitedPayloadTokenFilterDescriptor() : base()
		{
		}

		private string? DelimiterValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.DelimitedPayloadEncoding? EncodingValue { get; set; }

		private string? VersionValue { get; set; }

		public DelimitedPayloadTokenFilterDescriptor Delimiter(string? delimiter)
		{
			DelimiterValue = delimiter;
			return Self;
		}

		public DelimitedPayloadTokenFilterDescriptor Encoding(Elastic.Clients.Elasticsearch.Analysis.DelimitedPayloadEncoding? encoding)
		{
			EncodingValue = encoding;
			return Self;
		}

		public DelimitedPayloadTokenFilterDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(DelimiterValue))
			{
				writer.WritePropertyName("delimiter");
				writer.WriteStringValue(DelimiterValue);
			}

			if (EncodingValue is not null)
			{
				writer.WritePropertyName("encoding");
				JsonSerializer.Serialize(writer, EncodingValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("delimited_payload");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		DelimitedPayloadTokenFilter IBuildableDescriptor<DelimitedPayloadTokenFilter>.Build() => new()
		{ Delimiter = DelimiterValue, Encoding = EncodingValue, Version = VersionValue };
	}
}