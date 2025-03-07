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

internal sealed class MultiTermsAggregationConverter : JsonConverter<MultiTermsAggregation>
{
	public override MultiTermsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "multi_terms")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new MultiTermsAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("collect_mode"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode?>(ref reader, options);
					if (value is not null)
					{
						agg.CollectMode = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("min_doc_count"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<long?>(ref reader, options);
					if (value is not null)
					{
						agg.MinDocCount = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("order"))
				{
					reader.Read();
					var value = SingleOrManySerializationHelper.Deserialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(ref reader, options);
					if (value is not null)
					{
						agg.Order = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("shard_min_doc_count"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<long?>(ref reader, options);
					if (value is not null)
					{
						agg.ShardMinDocCount = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("shard_size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.ShardSize = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("show_term_doc_count_error"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
					if (value is not null)
					{
						agg.ShowTermDocCountError = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.Size = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("terms"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<ICollection<Elastic.Clients.Elasticsearch.Aggregations.MultiTermLookup>>(ref reader, options);
					agg.Terms = value;
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

				if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
				{
					var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
					if (value is not null)
					{
						agg.Aggregations = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, MultiTermsAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("multi_terms");
		writer.WriteStartObject();
		if (value.CollectMode is not null)
		{
			writer.WritePropertyName("collect_mode");
			JsonSerializer.Serialize(writer, value.CollectMode, options);
		}

		if (value.MinDocCount.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(value.MinDocCount.Value);
		}

		if (value.Order is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(value.Order, writer, options);
		}

		if (value.ShardMinDocCount.HasValue)
		{
			writer.WritePropertyName("shard_min_doc_count");
			writer.WriteNumberValue(value.ShardMinDocCount.Value);
		}

		if (value.ShardSize.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(value.ShardSize.Value);
		}

		if (value.ShowTermDocCountError.HasValue)
		{
			writer.WritePropertyName("show_term_doc_count_error");
			writer.WriteBooleanValue(value.ShowTermDocCountError.Value);
		}

		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		writer.WritePropertyName("terms");
		JsonSerializer.Serialize(writer, value.Terms, options);
		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		if (value.Aggregations is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, value.Aggregations, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(MultiTermsAggregationConverter))]
public sealed partial class MultiTermsAggregation : SearchAggregation
{
	public MultiTermsAggregation(string name) => Name = name;

	internal MultiTermsAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? Aggregations { get; set; }

	/// <summary>
	/// <para>Specifies the strategy for data collection.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? CollectMode { get; set; }
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>The minimum number of documents in a bucket for it to be returned.</para>
	/// </summary>
	public long? MinDocCount { get; set; }
	override public string? Name { get; internal set; }
	[JsonConverter(typeof(AggregateOrderConverter))]
	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? Order { get; set; }

	/// <summary>
	/// <para>The minimum number of documents in a bucket on each shard for it to be returned.</para>
	/// </summary>
	public long? ShardMinDocCount { get; set; }

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	public int? ShardSize { get; set; }

	/// <summary>
	/// <para>Calculates the doc count error on per term basis.</para>
	/// </summary>
	public bool? ShowTermDocCountError { get; set; }

	/// <summary>
	/// <para>The number of term buckets should be returned out of the overall terms list.</para>
	/// </summary>
	public int? Size { get; set; }

	/// <summary>
	/// <para>The field from which to generate sets of terms.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Aggregations.MultiTermLookup> Terms { get; set; }
}

public sealed partial class MultiTermsAggregationDescriptor<TDocument> : SerializableDescriptor<MultiTermsAggregationDescriptor<TDocument>>
{
	internal MultiTermsAggregationDescriptor(Action<MultiTermsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiTermsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument> AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.MultiTermLookup> TermsValue { get; set; }
	private MultiTermLookupDescriptor<TDocument> TermsDescriptor { get; set; }
	private Action<MultiTermLookupDescriptor<TDocument>> TermsDescriptorAction { get; set; }
	private Action<MultiTermLookupDescriptor<TDocument>>[] TermsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? CollectModeValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private long? MinDocCountValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? OrderValue { get; set; }
	private long? ShardMinDocCountValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private bool? ShowTermDocCountErrorValue { get; set; }
	private int? SizeValue { get; set; }

	public MultiTermsAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public MultiTermsAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument> descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public MultiTermsAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to generate sets of terms.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> Terms(ICollection<Elastic.Clients.Elasticsearch.Aggregations.MultiTermLookup> terms)
	{
		TermsDescriptor = null;
		TermsDescriptorAction = null;
		TermsDescriptorActions = null;
		TermsValue = terms;
		return Self;
	}

	public MultiTermsAggregationDescriptor<TDocument> Terms(MultiTermLookupDescriptor<TDocument> descriptor)
	{
		TermsValue = null;
		TermsDescriptorAction = null;
		TermsDescriptorActions = null;
		TermsDescriptor = descriptor;
		return Self;
	}

	public MultiTermsAggregationDescriptor<TDocument> Terms(Action<MultiTermLookupDescriptor<TDocument>> configure)
	{
		TermsValue = null;
		TermsDescriptor = null;
		TermsDescriptorActions = null;
		TermsDescriptorAction = configure;
		return Self;
	}

	public MultiTermsAggregationDescriptor<TDocument> Terms(params Action<MultiTermLookupDescriptor<TDocument>>[] configure)
	{
		TermsValue = null;
		TermsDescriptor = null;
		TermsDescriptorAction = null;
		TermsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the strategy for data collection.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> CollectMode(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? collectMode)
	{
		CollectModeValue = collectMode;
		return Self;
	}

	public MultiTermsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The minimum number of documents in a bucket for it to be returned.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> MinDocCount(long? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>The minimum number of documents in a bucket on each shard for it to be returned.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> ShardMinDocCount(long? shardMinDocCount)
	{
		ShardMinDocCountValue = shardMinDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>Calculates the doc count error on per term basis.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> ShowTermDocCountError(bool? showTermDocCountError = true)
	{
		ShowTermDocCountErrorValue = showTermDocCountError;
		return Self;
	}

	/// <summary>
	/// <para>The number of term buckets should be returned out of the overall terms list.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("multi_terms");
		writer.WriteStartObject();
		if (TermsDescriptor is not null)
		{
			writer.WritePropertyName("terms");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, TermsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (TermsDescriptorAction is not null)
		{
			writer.WritePropertyName("terms");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new MultiTermLookupDescriptor<TDocument>(TermsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (TermsDescriptorActions is not null)
		{
			writer.WritePropertyName("terms");
			writer.WriteStartArray();
			foreach (var action in TermsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new MultiTermLookupDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, TermsValue, options);
		}

		if (CollectModeValue is not null)
		{
			writer.WritePropertyName("collect_mode");
			JsonSerializer.Serialize(writer, CollectModeValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(OrderValue, writer, options);
		}

		if (ShardMinDocCountValue.HasValue)
		{
			writer.WritePropertyName("shard_min_doc_count");
			writer.WriteNumberValue(ShardMinDocCountValue.Value);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (ShowTermDocCountErrorValue.HasValue)
		{
			writer.WritePropertyName("show_term_doc_count_error");
			writer.WriteBooleanValue(ShowTermDocCountErrorValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AggregationsDescriptor is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
		}
		else if (AggregationsDescriptorAction is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, new AggregationDescriptor<TDocument>(AggregationsDescriptorAction), options);
		}
		else if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class MultiTermsAggregationDescriptor : SerializableDescriptor<MultiTermsAggregationDescriptor>
{
	internal MultiTermsAggregationDescriptor(Action<MultiTermsAggregationDescriptor> configure) => configure.Invoke(this);

	public MultiTermsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> AggregationsDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.MultiTermLookup> TermsValue { get; set; }
	private MultiTermLookupDescriptor TermsDescriptor { get; set; }
	private Action<MultiTermLookupDescriptor> TermsDescriptorAction { get; set; }
	private Action<MultiTermLookupDescriptor>[] TermsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? CollectModeValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private long? MinDocCountValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? OrderValue { get; set; }
	private long? ShardMinDocCountValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private bool? ShowTermDocCountErrorValue { get; set; }
	private int? SizeValue { get; set; }

	public MultiTermsAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public MultiTermsAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public MultiTermsAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to generate sets of terms.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor Terms(ICollection<Elastic.Clients.Elasticsearch.Aggregations.MultiTermLookup> terms)
	{
		TermsDescriptor = null;
		TermsDescriptorAction = null;
		TermsDescriptorActions = null;
		TermsValue = terms;
		return Self;
	}

	public MultiTermsAggregationDescriptor Terms(MultiTermLookupDescriptor descriptor)
	{
		TermsValue = null;
		TermsDescriptorAction = null;
		TermsDescriptorActions = null;
		TermsDescriptor = descriptor;
		return Self;
	}

	public MultiTermsAggregationDescriptor Terms(Action<MultiTermLookupDescriptor> configure)
	{
		TermsValue = null;
		TermsDescriptor = null;
		TermsDescriptorActions = null;
		TermsDescriptorAction = configure;
		return Self;
	}

	public MultiTermsAggregationDescriptor Terms(params Action<MultiTermLookupDescriptor>[] configure)
	{
		TermsValue = null;
		TermsDescriptor = null;
		TermsDescriptorAction = null;
		TermsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the strategy for data collection.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor CollectMode(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? collectMode)
	{
		CollectModeValue = collectMode;
		return Self;
	}

	public MultiTermsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The minimum number of documents in a bucket for it to be returned.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor MinDocCount(long? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>The minimum number of documents in a bucket on each shard for it to be returned.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor ShardMinDocCount(long? shardMinDocCount)
	{
		ShardMinDocCountValue = shardMinDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>Calculates the doc count error on per term basis.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor ShowTermDocCountError(bool? showTermDocCountError = true)
	{
		ShowTermDocCountErrorValue = showTermDocCountError;
		return Self;
	}

	/// <summary>
	/// <para>The number of term buckets should be returned out of the overall terms list.</para>
	/// </summary>
	public MultiTermsAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("multi_terms");
		writer.WriteStartObject();
		if (TermsDescriptor is not null)
		{
			writer.WritePropertyName("terms");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, TermsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (TermsDescriptorAction is not null)
		{
			writer.WritePropertyName("terms");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new MultiTermLookupDescriptor(TermsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (TermsDescriptorActions is not null)
		{
			writer.WritePropertyName("terms");
			writer.WriteStartArray();
			foreach (var action in TermsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new MultiTermLookupDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, TermsValue, options);
		}

		if (CollectModeValue is not null)
		{
			writer.WritePropertyName("collect_mode");
			JsonSerializer.Serialize(writer, CollectModeValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(OrderValue, writer, options);
		}

		if (ShardMinDocCountValue.HasValue)
		{
			writer.WritePropertyName("shard_min_doc_count");
			writer.WriteNumberValue(ShardMinDocCountValue.Value);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (ShowTermDocCountErrorValue.HasValue)
		{
			writer.WritePropertyName("show_term_doc_count_error");
			writer.WriteBooleanValue(ShowTermDocCountErrorValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AggregationsDescriptor is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
		}
		else if (AggregationsDescriptorAction is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, new AggregationDescriptor(AggregationsDescriptorAction), options);
		}
		else if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
		}

		writer.WriteEndObject();
	}
}