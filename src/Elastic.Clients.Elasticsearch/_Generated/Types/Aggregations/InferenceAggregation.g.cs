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

namespace Elastic.Clients.Elasticsearch.Aggregations;

internal sealed class InferenceAggregationConverter : JsonConverter<InferenceAggregation>
{
	public override InferenceAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "inference")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new InferenceAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("buckets_path"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.BucketsPath?>(ref reader, options);
					if (value is not null)
					{
						agg.BucketsPath = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("gap_policy"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GapPolicy?>(ref reader, options);
					if (value is not null)
					{
						agg.GapPolicy = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("inference_config"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.InferenceConfig?>(ref reader, options);
					if (value is not null)
					{
						agg.InferenceConfig = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("model_id"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Name>(ref reader, options);
					agg.ModelId = value;
					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, InferenceAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("inference");
		writer.WriteStartObject();
		if (value.BucketsPath is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, value.BucketsPath, options);
		}

		if (!string.IsNullOrEmpty(value.Format))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
		}

		if (value.GapPolicy is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, value.GapPolicy, options);
		}

		if (value.InferenceConfig is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, value.InferenceConfig, options);
		}

		writer.WritePropertyName("model_id");
		JsonSerializer.Serialize(writer, value.ModelId, options);
		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(InferenceAggregationConverter))]
public sealed partial class InferenceAggregation : SearchAggregation
{
	public InferenceAggregation(string name) => Name = name;

	internal InferenceAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPath { get; set; }
	public string? Format { get; set; }
	public Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicy { get; set; }

	/// <summary>
	/// <para>Contains the inference type and its options.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Aggregations.InferenceConfig? InferenceConfig { get; set; }
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>The ID or alias for the trained model.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Name ModelId { get; set; }
	override public string? Name { get; internal set; }
}

public sealed partial class InferenceAggregationDescriptor<TDocument> : SerializableDescriptor<InferenceAggregationDescriptor<TDocument>>
{
	internal InferenceAggregationDescriptor(Action<InferenceAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public InferenceAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.InferenceConfig? InferenceConfigValue { get; set; }
	private InferenceConfigDescriptor<TDocument> InferenceConfigDescriptor { get; set; }
	private Action<InferenceConfigDescriptor<TDocument>> InferenceConfigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name ModelIdValue { get; set; }

	/// <summary>
	/// <para>Contains the inference type and its options.</para>
	/// </summary>
	public InferenceAggregationDescriptor<TDocument> InferenceConfig(Elastic.Clients.Elasticsearch.Aggregations.InferenceConfig? inferenceConfig)
	{
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigValue = inferenceConfig;
		return Self;
	}

	public InferenceAggregationDescriptor<TDocument> InferenceConfig(InferenceConfigDescriptor<TDocument> descriptor)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigDescriptor = descriptor;
		return Self;
	}

	public InferenceAggregationDescriptor<TDocument> InferenceConfig(Action<InferenceConfigDescriptor<TDocument>> configure)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = configure;
		return Self;
	}

	public InferenceAggregationDescriptor<TDocument> BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	public InferenceAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public InferenceAggregationDescriptor<TDocument> GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public InferenceAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The ID or alias for the trained model.</para>
	/// </summary>
	public InferenceAggregationDescriptor<TDocument> ModelId(Elastic.Clients.Elasticsearch.Name modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("inference");
		writer.WriteStartObject();
		if (InferenceConfigDescriptor is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
		}
		else if (InferenceConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, new InferenceConfigDescriptor<TDocument>(InferenceConfigDescriptorAction), options);
		}
		else if (InferenceConfigValue is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigValue, options);
		}

		if (BucketsPathValue is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, BucketsPathValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		writer.WritePropertyName("model_id");
		JsonSerializer.Serialize(writer, ModelIdValue, options);
		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InferenceAggregationDescriptor : SerializableDescriptor<InferenceAggregationDescriptor>
{
	internal InferenceAggregationDescriptor(Action<InferenceAggregationDescriptor> configure) => configure.Invoke(this);

	public InferenceAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.InferenceConfig? InferenceConfigValue { get; set; }
	private InferenceConfigDescriptor InferenceConfigDescriptor { get; set; }
	private Action<InferenceConfigDescriptor> InferenceConfigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name ModelIdValue { get; set; }

	/// <summary>
	/// <para>Contains the inference type and its options.</para>
	/// </summary>
	public InferenceAggregationDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Aggregations.InferenceConfig? inferenceConfig)
	{
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigValue = inferenceConfig;
		return Self;
	}

	public InferenceAggregationDescriptor InferenceConfig(InferenceConfigDescriptor descriptor)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigDescriptor = descriptor;
		return Self;
	}

	public InferenceAggregationDescriptor InferenceConfig(Action<InferenceConfigDescriptor> configure)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = configure;
		return Self;
	}

	public InferenceAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	public InferenceAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public InferenceAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public InferenceAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The ID or alias for the trained model.</para>
	/// </summary>
	public InferenceAggregationDescriptor ModelId(Elastic.Clients.Elasticsearch.Name modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("inference");
		writer.WriteStartObject();
		if (InferenceConfigDescriptor is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
		}
		else if (InferenceConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, new InferenceConfigDescriptor(InferenceConfigDescriptorAction), options);
		}
		else if (InferenceConfigValue is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigValue, options);
		}

		if (BucketsPathValue is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, BucketsPathValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		writer.WritePropertyName("model_id");
		JsonSerializer.Serialize(writer, ModelIdValue, options);
		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}