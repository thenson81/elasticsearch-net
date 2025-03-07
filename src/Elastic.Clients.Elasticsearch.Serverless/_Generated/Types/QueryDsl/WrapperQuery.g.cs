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

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class WrapperQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>A base64 encoded query.<br/>The binary data format can be any of JSON, YAML, CBOR or SMILE encodings</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }

	public static implicit operator Query(WrapperQuery wrapperQuery) => QueryDsl.Query.Wrapper(wrapperQuery);

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("wrapper", this);
}

public sealed partial class WrapperQueryDescriptor : SerializableDescriptor<WrapperQueryDescriptor>
{
	internal WrapperQueryDescriptor(Action<WrapperQueryDescriptor> configure) => configure.Invoke(this);

	public WrapperQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private string QueryValue { get; set; }

	public WrapperQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public WrapperQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>A base64 encoded query.<br/>The binary data format can be any of JSON, YAML, CBOR or SMILE encodings</para>
	/// </summary>
	public WrapperQueryDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		writer.WriteEndObject();
	}
}