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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.Search;

public sealed partial class DirectGenerator
{
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }
	[JsonInclude, JsonPropertyName("max_edits")]
	public int? MaxEdits { get; set; }
	[JsonInclude, JsonPropertyName("max_inspections")]
	public float? MaxInspections { get; set; }
	[JsonInclude, JsonPropertyName("max_term_freq")]
	public float? MaxTermFreq { get; set; }
	[JsonInclude, JsonPropertyName("min_doc_freq")]
	public float? MinDocFreq { get; set; }
	[JsonInclude, JsonPropertyName("min_word_length")]
	public int? MinWordLength { get; set; }
	[JsonInclude, JsonPropertyName("post_filter")]
	public string? PostFilter { get; set; }
	[JsonInclude, JsonPropertyName("pre_filter")]
	public string? PreFilter { get; set; }
	[JsonInclude, JsonPropertyName("prefix_length")]
	public int? PrefixLength { get; set; }
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }
	[JsonInclude, JsonPropertyName("suggest_mode")]
	public Elastic.Clients.Elasticsearch.Serverless.SuggestMode? SuggestMode { get; set; }
}

public sealed partial class DirectGeneratorDescriptor<TDocument> : SerializableDescriptor<DirectGeneratorDescriptor<TDocument>>
{
	internal DirectGeneratorDescriptor(Action<DirectGeneratorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DirectGeneratorDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private int? MaxEditsValue { get; set; }
	private float? MaxInspectionsValue { get; set; }
	private float? MaxTermFreqValue { get; set; }
	private float? MinDocFreqValue { get; set; }
	private int? MinWordLengthValue { get; set; }
	private string? PostFilterValue { get; set; }
	private string? PreFilterValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private int? SizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SuggestMode? SuggestModeValue { get; set; }

	public DirectGeneratorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> MaxEdits(int? maxEdits)
	{
		MaxEditsValue = maxEdits;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> MaxInspections(float? maxInspections)
	{
		MaxInspectionsValue = maxInspections;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> MaxTermFreq(float? maxTermFreq)
	{
		MaxTermFreqValue = maxTermFreq;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> MinDocFreq(float? minDocFreq)
	{
		MinDocFreqValue = minDocFreq;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> MinWordLength(int? minWordLength)
	{
		MinWordLengthValue = minWordLength;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> PostFilter(string? postFilter)
	{
		PostFilterValue = postFilter;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> PreFilter(string? preFilter)
	{
		PreFilterValue = preFilter;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	public DirectGeneratorDescriptor<TDocument> SuggestMode(Elastic.Clients.Elasticsearch.Serverless.SuggestMode? suggestMode)
	{
		SuggestModeValue = suggestMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (MaxEditsValue.HasValue)
		{
			writer.WritePropertyName("max_edits");
			writer.WriteNumberValue(MaxEditsValue.Value);
		}

		if (MaxInspectionsValue.HasValue)
		{
			writer.WritePropertyName("max_inspections");
			writer.WriteNumberValue(MaxInspectionsValue.Value);
		}

		if (MaxTermFreqValue.HasValue)
		{
			writer.WritePropertyName("max_term_freq");
			writer.WriteNumberValue(MaxTermFreqValue.Value);
		}

		if (MinDocFreqValue.HasValue)
		{
			writer.WritePropertyName("min_doc_freq");
			writer.WriteNumberValue(MinDocFreqValue.Value);
		}

		if (MinWordLengthValue.HasValue)
		{
			writer.WritePropertyName("min_word_length");
			writer.WriteNumberValue(MinWordLengthValue.Value);
		}

		if (!string.IsNullOrEmpty(PostFilterValue))
		{
			writer.WritePropertyName("post_filter");
			writer.WriteStringValue(PostFilterValue);
		}

		if (!string.IsNullOrEmpty(PreFilterValue))
		{
			writer.WritePropertyName("pre_filter");
			writer.WriteStringValue(PreFilterValue);
		}

		if (PrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("prefix_length");
			writer.WriteNumberValue(PrefixLengthValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SuggestModeValue is not null)
		{
			writer.WritePropertyName("suggest_mode");
			JsonSerializer.Serialize(writer, SuggestModeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DirectGeneratorDescriptor : SerializableDescriptor<DirectGeneratorDescriptor>
{
	internal DirectGeneratorDescriptor(Action<DirectGeneratorDescriptor> configure) => configure.Invoke(this);

	public DirectGeneratorDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private int? MaxEditsValue { get; set; }
	private float? MaxInspectionsValue { get; set; }
	private float? MaxTermFreqValue { get; set; }
	private float? MinDocFreqValue { get; set; }
	private int? MinWordLengthValue { get; set; }
	private string? PostFilterValue { get; set; }
	private string? PreFilterValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private int? SizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SuggestMode? SuggestModeValue { get; set; }

	public DirectGeneratorDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public DirectGeneratorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public DirectGeneratorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public DirectGeneratorDescriptor MaxEdits(int? maxEdits)
	{
		MaxEditsValue = maxEdits;
		return Self;
	}

	public DirectGeneratorDescriptor MaxInspections(float? maxInspections)
	{
		MaxInspectionsValue = maxInspections;
		return Self;
	}

	public DirectGeneratorDescriptor MaxTermFreq(float? maxTermFreq)
	{
		MaxTermFreqValue = maxTermFreq;
		return Self;
	}

	public DirectGeneratorDescriptor MinDocFreq(float? minDocFreq)
	{
		MinDocFreqValue = minDocFreq;
		return Self;
	}

	public DirectGeneratorDescriptor MinWordLength(int? minWordLength)
	{
		MinWordLengthValue = minWordLength;
		return Self;
	}

	public DirectGeneratorDescriptor PostFilter(string? postFilter)
	{
		PostFilterValue = postFilter;
		return Self;
	}

	public DirectGeneratorDescriptor PreFilter(string? preFilter)
	{
		PreFilterValue = preFilter;
		return Self;
	}

	public DirectGeneratorDescriptor PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	public DirectGeneratorDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	public DirectGeneratorDescriptor SuggestMode(Elastic.Clients.Elasticsearch.Serverless.SuggestMode? suggestMode)
	{
		SuggestModeValue = suggestMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (MaxEditsValue.HasValue)
		{
			writer.WritePropertyName("max_edits");
			writer.WriteNumberValue(MaxEditsValue.Value);
		}

		if (MaxInspectionsValue.HasValue)
		{
			writer.WritePropertyName("max_inspections");
			writer.WriteNumberValue(MaxInspectionsValue.Value);
		}

		if (MaxTermFreqValue.HasValue)
		{
			writer.WritePropertyName("max_term_freq");
			writer.WriteNumberValue(MaxTermFreqValue.Value);
		}

		if (MinDocFreqValue.HasValue)
		{
			writer.WritePropertyName("min_doc_freq");
			writer.WriteNumberValue(MinDocFreqValue.Value);
		}

		if (MinWordLengthValue.HasValue)
		{
			writer.WritePropertyName("min_word_length");
			writer.WriteNumberValue(MinWordLengthValue.Value);
		}

		if (!string.IsNullOrEmpty(PostFilterValue))
		{
			writer.WritePropertyName("post_filter");
			writer.WriteStringValue(PostFilterValue);
		}

		if (!string.IsNullOrEmpty(PreFilterValue))
		{
			writer.WritePropertyName("pre_filter");
			writer.WriteStringValue(PreFilterValue);
		}

		if (PrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("prefix_length");
			writer.WriteNumberValue(PrefixLengthValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SuggestModeValue is not null)
		{
			writer.WritePropertyName("suggest_mode");
			JsonSerializer.Serialize(writer, SuggestModeValue, options);
		}

		writer.WriteEndObject();
	}
}