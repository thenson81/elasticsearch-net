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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.TermVectors;

public sealed partial class Filter
{
	[JsonInclude, JsonPropertyName("max_doc_freq")]
	public int? MaxDocFreq { get; set; }
	[JsonInclude, JsonPropertyName("max_num_terms")]
	public int? MaxNumTerms { get; set; }
	[JsonInclude, JsonPropertyName("max_term_freq")]
	public int? MaxTermFreq { get; set; }
	[JsonInclude, JsonPropertyName("max_word_length")]
	public int? MaxWordLength { get; set; }
	[JsonInclude, JsonPropertyName("min_doc_freq")]
	public int? MinDocFreq { get; set; }
	[JsonInclude, JsonPropertyName("min_term_freq")]
	public int? MinTermFreq { get; set; }
	[JsonInclude, JsonPropertyName("min_word_length")]
	public int? MinWordLength { get; set; }
}

public sealed partial class FilterDescriptor : SerializableDescriptor<FilterDescriptor>
{
	internal FilterDescriptor(Action<FilterDescriptor> configure) => configure.Invoke(this);

	public FilterDescriptor() : base()
	{
	}

	private int? MaxDocFreqValue { get; set; }
	private int? MaxNumTermsValue { get; set; }
	private int? MaxTermFreqValue { get; set; }
	private int? MaxWordLengthValue { get; set; }
	private int? MinDocFreqValue { get; set; }
	private int? MinTermFreqValue { get; set; }
	private int? MinWordLengthValue { get; set; }

	public FilterDescriptor MaxDocFreq(int? maxDocFreq)
	{
		MaxDocFreqValue = maxDocFreq;
		return Self;
	}

	public FilterDescriptor MaxNumTerms(int? maxNumTerms)
	{
		MaxNumTermsValue = maxNumTerms;
		return Self;
	}

	public FilterDescriptor MaxTermFreq(int? maxTermFreq)
	{
		MaxTermFreqValue = maxTermFreq;
		return Self;
	}

	public FilterDescriptor MaxWordLength(int? maxWordLength)
	{
		MaxWordLengthValue = maxWordLength;
		return Self;
	}

	public FilterDescriptor MinDocFreq(int? minDocFreq)
	{
		MinDocFreqValue = minDocFreq;
		return Self;
	}

	public FilterDescriptor MinTermFreq(int? minTermFreq)
	{
		MinTermFreqValue = minTermFreq;
		return Self;
	}

	public FilterDescriptor MinWordLength(int? minWordLength)
	{
		MinWordLengthValue = minWordLength;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxDocFreqValue.HasValue)
		{
			writer.WritePropertyName("max_doc_freq");
			writer.WriteNumberValue(MaxDocFreqValue.Value);
		}

		if (MaxNumTermsValue.HasValue)
		{
			writer.WritePropertyName("max_num_terms");
			writer.WriteNumberValue(MaxNumTermsValue.Value);
		}

		if (MaxTermFreqValue.HasValue)
		{
			writer.WritePropertyName("max_term_freq");
			writer.WriteNumberValue(MaxTermFreqValue.Value);
		}

		if (MaxWordLengthValue.HasValue)
		{
			writer.WritePropertyName("max_word_length");
			writer.WriteNumberValue(MaxWordLengthValue.Value);
		}

		if (MinDocFreqValue.HasValue)
		{
			writer.WritePropertyName("min_doc_freq");
			writer.WriteNumberValue(MinDocFreqValue.Value);
		}

		if (MinTermFreqValue.HasValue)
		{
			writer.WritePropertyName("min_term_freq");
			writer.WriteNumberValue(MinTermFreqValue.Value);
		}

		if (MinWordLengthValue.HasValue)
		{
			writer.WritePropertyName("min_word_length");
			writer.WriteNumberValue(MinWordLengthValue.Value);
		}

		writer.WriteEndObject();
	}
}