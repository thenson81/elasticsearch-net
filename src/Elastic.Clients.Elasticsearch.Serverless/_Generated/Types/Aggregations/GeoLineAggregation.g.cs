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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

internal sealed class GeoLineAggregationConverter : JsonConverter<GeoLineAggregation>
{
	public override GeoLineAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "geo_line")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new GeoLineAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("include_sort"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
					if (value is not null)
					{
						agg.IncludeSort = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("point"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLinePoint>(ref reader, options);
					agg.Point = value;
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

				if (reader.ValueTextEquals("sort"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLineSort>(ref reader, options);
					agg.Sort = value;
					continue;
				}

				if (reader.ValueTextEquals("sort_order"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.SortOrder?>(ref reader, options);
					if (value is not null)
					{
						agg.SortOrder = value;
					}

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

	public override void Write(Utf8JsonWriter writer, GeoLineAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geo_line");
		writer.WriteStartObject();
		if (value.IncludeSort.HasValue)
		{
			writer.WritePropertyName("include_sort");
			writer.WriteBooleanValue(value.IncludeSort.Value);
		}

		writer.WritePropertyName("point");
		JsonSerializer.Serialize(writer, value.Point, options);
		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		writer.WritePropertyName("sort");
		JsonSerializer.Serialize(writer, value.Sort, options);
		if (value.SortOrder is not null)
		{
			writer.WritePropertyName("sort_order");
			JsonSerializer.Serialize(writer, value.SortOrder, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GeoLineAggregationConverter))]
public sealed partial class GeoLineAggregation : SearchAggregation
{
	public GeoLineAggregation(string name) => Name = name;

	internal GeoLineAggregation()
	{
	}

	/// <summary>
	/// <para>When `true`, returns an additional array of the sort values in the feature properties.</para>
	/// </summary>
	public bool? IncludeSort { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>The name of the geo_point field.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLinePoint Point { get; set; }

	/// <summary>
	/// <para>The maximum length of the line represented in the aggregation.<br/>Valid sizes are between 1 and 10000.</para>
	/// </summary>
	public int? Size { get; set; }

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.<br/>When the `geo_line` aggregation is nested inside a `time_series` aggregation, this field defaults to `@timestamp`, and any other value will result in error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLineSort Sort { get; set; }

	/// <summary>
	/// <para>The order in which the line is sorted (ascending or descending).</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.SortOrder? SortOrder { get; set; }
}

public sealed partial class GeoLineAggregationDescriptor<TDocument> : SerializableDescriptor<GeoLineAggregationDescriptor<TDocument>>
{
	internal GeoLineAggregationDescriptor(Action<GeoLineAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoLineAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLinePoint PointValue { get; set; }
	private GeoLinePointDescriptor<TDocument> PointDescriptor { get; set; }
	private Action<GeoLinePointDescriptor<TDocument>> PointDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLineSort SortValue { get; set; }
	private GeoLineSortDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<GeoLineSortDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private bool? IncludeSortValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? SizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOrder? SortOrderValue { get; set; }

	/// <summary>
	/// <para>The name of the geo_point field.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> Point(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLinePoint point)
	{
		PointDescriptor = null;
		PointDescriptorAction = null;
		PointValue = point;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Point(GeoLinePointDescriptor<TDocument> descriptor)
	{
		PointValue = null;
		PointDescriptorAction = null;
		PointDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Point(Action<GeoLinePointDescriptor<TDocument>> configure)
	{
		PointValue = null;
		PointDescriptor = null;
		PointDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.<br/>When the `geo_line` aggregation is nested inside a `time_series` aggregation, this field defaults to `@timestamp`, and any other value will result in error.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLineSort sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortValue = sort;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Sort(GeoLineSortDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Sort(Action<GeoLineSortDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>When `true`, returns an additional array of the sort values in the feature properties.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> IncludeSort(bool? includeSort = true)
	{
		IncludeSortValue = includeSort;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The maximum length of the line represented in the aggregation.<br/>Valid sizes are between 1 and 10000.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>The order in which the line is sorted (ascending or descending).</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> SortOrder(Elastic.Clients.Elasticsearch.Serverless.SortOrder? sortOrder)
	{
		SortOrderValue = sortOrder;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geo_line");
		writer.WriteStartObject();
		if (PointDescriptor is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointDescriptor, options);
		}
		else if (PointDescriptorAction is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, new GeoLinePointDescriptor<TDocument>(PointDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointValue, options);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new GeoLineSortDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortValue, options);
		}

		if (IncludeSortValue.HasValue)
		{
			writer.WritePropertyName("include_sort");
			writer.WriteBooleanValue(IncludeSortValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortOrderValue is not null)
		{
			writer.WritePropertyName("sort_order");
			JsonSerializer.Serialize(writer, SortOrderValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoLineAggregationDescriptor : SerializableDescriptor<GeoLineAggregationDescriptor>
{
	internal GeoLineAggregationDescriptor(Action<GeoLineAggregationDescriptor> configure) => configure.Invoke(this);

	public GeoLineAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLinePoint PointValue { get; set; }
	private GeoLinePointDescriptor PointDescriptor { get; set; }
	private Action<GeoLinePointDescriptor> PointDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLineSort SortValue { get; set; }
	private GeoLineSortDescriptor SortDescriptor { get; set; }
	private Action<GeoLineSortDescriptor> SortDescriptorAction { get; set; }
	private bool? IncludeSortValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? SizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOrder? SortOrderValue { get; set; }

	/// <summary>
	/// <para>The name of the geo_point field.</para>
	/// </summary>
	public GeoLineAggregationDescriptor Point(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLinePoint point)
	{
		PointDescriptor = null;
		PointDescriptorAction = null;
		PointValue = point;
		return Self;
	}

	public GeoLineAggregationDescriptor Point(GeoLinePointDescriptor descriptor)
	{
		PointValue = null;
		PointDescriptorAction = null;
		PointDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor Point(Action<GeoLinePointDescriptor> configure)
	{
		PointValue = null;
		PointDescriptor = null;
		PointDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.<br/>When the `geo_line` aggregation is nested inside a `time_series` aggregation, this field defaults to `@timestamp`, and any other value will result in error.</para>
	/// </summary>
	public GeoLineAggregationDescriptor Sort(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GeoLineSort sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortValue = sort;
		return Self;
	}

	public GeoLineAggregationDescriptor Sort(GeoLineSortDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor Sort(Action<GeoLineSortDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>When `true`, returns an additional array of the sort values in the feature properties.</para>
	/// </summary>
	public GeoLineAggregationDescriptor IncludeSort(bool? includeSort = true)
	{
		IncludeSortValue = includeSort;
		return Self;
	}

	public GeoLineAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The maximum length of the line represented in the aggregation.<br/>Valid sizes are between 1 and 10000.</para>
	/// </summary>
	public GeoLineAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>The order in which the line is sorted (ascending or descending).</para>
	/// </summary>
	public GeoLineAggregationDescriptor SortOrder(Elastic.Clients.Elasticsearch.Serverless.SortOrder? sortOrder)
	{
		SortOrderValue = sortOrder;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geo_line");
		writer.WriteStartObject();
		if (PointDescriptor is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointDescriptor, options);
		}
		else if (PointDescriptorAction is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, new GeoLinePointDescriptor(PointDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointValue, options);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new GeoLineSortDescriptor(SortDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortValue, options);
		}

		if (IncludeSortValue.HasValue)
		{
			writer.WritePropertyName("include_sort");
			writer.WriteBooleanValue(IncludeSortValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortOrderValue is not null)
		{
			writer.WritePropertyName("sort_order");
			JsonSerializer.Serialize(writer, SortOrderValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}