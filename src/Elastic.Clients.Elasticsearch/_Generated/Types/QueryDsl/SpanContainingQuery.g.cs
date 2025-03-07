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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryDsl;

public sealed partial class SpanContainingQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>Can be any span query.<br/>Matching spans from `big` that contain matches from `little` are returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("big")]
	public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Big { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Can be any span query.<br/>Matching spans from `big` that contain matches from `little` are returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("little")]
	public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Little { get; set; }

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("span_containing", this);
}

public sealed partial class SpanContainingQueryDescriptor<TDocument> : SerializableDescriptor<SpanContainingQueryDescriptor<TDocument>>
{
	internal SpanContainingQueryDescriptor(Action<SpanContainingQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SpanContainingQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery BigValue { get; set; }
	private SpanQueryDescriptor<TDocument> BigDescriptor { get; set; }
	private Action<SpanQueryDescriptor<TDocument>> BigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery LittleValue { get; set; }
	private SpanQueryDescriptor<TDocument> LittleDescriptor { get; set; }
	private Action<SpanQueryDescriptor<TDocument>> LittleDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }

	/// <summary>
	/// <para>Can be any span query.<br/>Matching spans from `big` that contain matches from `little` are returned.</para>
	/// </summary>
	public SpanContainingQueryDescriptor<TDocument> Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery big)
	{
		BigDescriptor = null;
		BigDescriptorAction = null;
		BigValue = big;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Big(SpanQueryDescriptor<TDocument> descriptor)
	{
		BigValue = null;
		BigDescriptorAction = null;
		BigDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Big(Action<SpanQueryDescriptor<TDocument>> configure)
	{
		BigValue = null;
		BigDescriptor = null;
		BigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Can be any span query.<br/>Matching spans from `big` that contain matches from `little` are returned.</para>
	/// </summary>
	public SpanContainingQueryDescriptor<TDocument> Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery little)
	{
		LittleDescriptor = null;
		LittleDescriptorAction = null;
		LittleValue = little;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Little(SpanQueryDescriptor<TDocument> descriptor)
	{
		LittleValue = null;
		LittleDescriptorAction = null;
		LittleDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Little(Action<SpanQueryDescriptor<TDocument>> configure)
	{
		LittleValue = null;
		LittleDescriptor = null;
		LittleDescriptorAction = configure;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public SpanContainingQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BigDescriptor is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigDescriptor, options);
		}
		else if (BigDescriptorAction is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor<TDocument>(BigDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigValue, options);
		}

		if (LittleDescriptor is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleDescriptor, options);
		}
		else if (LittleDescriptorAction is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor<TDocument>(LittleDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleValue, options);
		}

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

		writer.WriteEndObject();
	}
}

public sealed partial class SpanContainingQueryDescriptor : SerializableDescriptor<SpanContainingQueryDescriptor>
{
	internal SpanContainingQueryDescriptor(Action<SpanContainingQueryDescriptor> configure) => configure.Invoke(this);

	public SpanContainingQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery BigValue { get; set; }
	private SpanQueryDescriptor BigDescriptor { get; set; }
	private Action<SpanQueryDescriptor> BigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery LittleValue { get; set; }
	private SpanQueryDescriptor LittleDescriptor { get; set; }
	private Action<SpanQueryDescriptor> LittleDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }

	/// <summary>
	/// <para>Can be any span query.<br/>Matching spans from `big` that contain matches from `little` are returned.</para>
	/// </summary>
	public SpanContainingQueryDescriptor Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery big)
	{
		BigDescriptor = null;
		BigDescriptorAction = null;
		BigValue = big;
		return Self;
	}

	public SpanContainingQueryDescriptor Big(SpanQueryDescriptor descriptor)
	{
		BigValue = null;
		BigDescriptorAction = null;
		BigDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor Big(Action<SpanQueryDescriptor> configure)
	{
		BigValue = null;
		BigDescriptor = null;
		BigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Can be any span query.<br/>Matching spans from `big` that contain matches from `little` are returned.</para>
	/// </summary>
	public SpanContainingQueryDescriptor Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery little)
	{
		LittleDescriptor = null;
		LittleDescriptorAction = null;
		LittleValue = little;
		return Self;
	}

	public SpanContainingQueryDescriptor Little(SpanQueryDescriptor descriptor)
	{
		LittleValue = null;
		LittleDescriptorAction = null;
		LittleDescriptor = descriptor;
		return Self;
	}

	public SpanContainingQueryDescriptor Little(Action<SpanQueryDescriptor> configure)
	{
		LittleValue = null;
		LittleDescriptor = null;
		LittleDescriptorAction = configure;
		return Self;
	}

	public SpanContainingQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public SpanContainingQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BigDescriptor is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigDescriptor, options);
		}
		else if (BigDescriptorAction is not null)
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor(BigDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("big");
			JsonSerializer.Serialize(writer, BigValue, options);
		}

		if (LittleDescriptor is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleDescriptor, options);
		}
		else if (LittleDescriptorAction is not null)
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor(LittleDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("little");
			JsonSerializer.Serialize(writer, LittleValue, options);
		}

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

		writer.WriteEndObject();
	}
}