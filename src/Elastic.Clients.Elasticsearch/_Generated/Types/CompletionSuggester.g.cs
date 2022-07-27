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
namespace Elastic.Clients.Elasticsearch
{
	public sealed partial class CompletionSuggester : IFieldSuggesterVariant
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("contexts")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>? Contexts { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy")]
		public Elastic.Clients.Elasticsearch.SuggestFuzziness? Fuzzy { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix")]
		public string? Prefix { get; set; }

		[JsonInclude]
		[JsonPropertyName("regex")]
		public string? Regex { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("skip_duplicates")]
		public bool? SkipDuplicates { get; set; }
	}

	public sealed partial class CompletionSuggesterDescriptor<TDocument> : SerializableDescriptorBase<CompletionSuggesterDescriptor<TDocument>>
	{
		internal CompletionSuggesterDescriptor(Action<CompletionSuggesterDescriptor<TDocument>> configure) => configure.Invoke(this);
		public CompletionSuggesterDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>? ContextsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.SuggestFuzziness? FuzzyValue { get; set; }

		private SuggestFuzzinessDescriptor FuzzyDescriptor { get; set; }

		private Action<SuggestFuzzinessDescriptor> FuzzyDescriptorAction { get; set; }

		private string? PrefixValue { get; set; }

		private string? RegexValue { get; set; }

		private int? SizeValue { get; set; }

		private bool? SkipDuplicatesValue { get; set; }

		public CompletionSuggesterDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Contexts(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>> selector)
		{
			ContextsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>());
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Fuzzy(Elastic.Clients.Elasticsearch.SuggestFuzziness? fuzzy)
		{
			FuzzyDescriptor = null;
			FuzzyDescriptorAction = null;
			FuzzyValue = fuzzy;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Fuzzy(SuggestFuzzinessDescriptor descriptor)
		{
			FuzzyValue = null;
			FuzzyDescriptorAction = null;
			FuzzyDescriptor = descriptor;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Fuzzy(Action<SuggestFuzzinessDescriptor> configure)
		{
			FuzzyValue = null;
			FuzzyDescriptor = null;
			FuzzyDescriptorAction = configure;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Prefix(string? prefix)
		{
			PrefixValue = prefix;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Regex(string? regex)
		{
			RegexValue = regex;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public CompletionSuggesterDescriptor<TDocument> SkipDuplicates(bool? skipDuplicates = true)
		{
			SkipDuplicatesValue = skipDuplicates;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (ContextsValue is not null)
			{
				writer.WritePropertyName("contexts");
				JsonSerializer.Serialize(writer, ContextsValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (FuzzyDescriptor is not null)
			{
				writer.WritePropertyName("fuzzy");
				JsonSerializer.Serialize(writer, FuzzyDescriptor, options);
			}
			else if (FuzzyDescriptorAction is not null)
			{
				writer.WritePropertyName("fuzzy");
				JsonSerializer.Serialize(writer, new SuggestFuzzinessDescriptor(FuzzyDescriptorAction), options);
			}
			else if (FuzzyValue is not null)
			{
				writer.WritePropertyName("fuzzy");
				JsonSerializer.Serialize(writer, FuzzyValue, options);
			}

			if (!string.IsNullOrEmpty(PrefixValue))
			{
				writer.WritePropertyName("prefix");
				writer.WriteStringValue(PrefixValue);
			}

			if (!string.IsNullOrEmpty(RegexValue))
			{
				writer.WritePropertyName("regex");
				writer.WriteStringValue(RegexValue);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SkipDuplicatesValue.HasValue)
			{
				writer.WritePropertyName("skip_duplicates");
				writer.WriteBooleanValue(SkipDuplicatesValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class CompletionSuggesterDescriptor : SerializableDescriptorBase<CompletionSuggesterDescriptor>
	{
		internal CompletionSuggesterDescriptor(Action<CompletionSuggesterDescriptor> configure) => configure.Invoke(this);
		public CompletionSuggesterDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>? ContextsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.SuggestFuzziness? FuzzyValue { get; set; }

		private SuggestFuzzinessDescriptor FuzzyDescriptor { get; set; }

		private Action<SuggestFuzzinessDescriptor> FuzzyDescriptorAction { get; set; }

		private string? PrefixValue { get; set; }

		private string? RegexValue { get; set; }

		private int? SizeValue { get; set; }

		private bool? SkipDuplicatesValue { get; set; }

		public CompletionSuggesterDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public CompletionSuggesterDescriptor Contexts(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>> selector)
		{
			ContextsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.CompletionContext>>());
			return Self;
		}

		public CompletionSuggesterDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public CompletionSuggesterDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public CompletionSuggesterDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public CompletionSuggesterDescriptor Fuzzy(Elastic.Clients.Elasticsearch.SuggestFuzziness? fuzzy)
		{
			FuzzyDescriptor = null;
			FuzzyDescriptorAction = null;
			FuzzyValue = fuzzy;
			return Self;
		}

		public CompletionSuggesterDescriptor Fuzzy(SuggestFuzzinessDescriptor descriptor)
		{
			FuzzyValue = null;
			FuzzyDescriptorAction = null;
			FuzzyDescriptor = descriptor;
			return Self;
		}

		public CompletionSuggesterDescriptor Fuzzy(Action<SuggestFuzzinessDescriptor> configure)
		{
			FuzzyValue = null;
			FuzzyDescriptor = null;
			FuzzyDescriptorAction = configure;
			return Self;
		}

		public CompletionSuggesterDescriptor Prefix(string? prefix)
		{
			PrefixValue = prefix;
			return Self;
		}

		public CompletionSuggesterDescriptor Regex(string? regex)
		{
			RegexValue = regex;
			return Self;
		}

		public CompletionSuggesterDescriptor Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public CompletionSuggesterDescriptor SkipDuplicates(bool? skipDuplicates = true)
		{
			SkipDuplicatesValue = skipDuplicates;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (ContextsValue is not null)
			{
				writer.WritePropertyName("contexts");
				JsonSerializer.Serialize(writer, ContextsValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (FuzzyDescriptor is not null)
			{
				writer.WritePropertyName("fuzzy");
				JsonSerializer.Serialize(writer, FuzzyDescriptor, options);
			}
			else if (FuzzyDescriptorAction is not null)
			{
				writer.WritePropertyName("fuzzy");
				JsonSerializer.Serialize(writer, new SuggestFuzzinessDescriptor(FuzzyDescriptorAction), options);
			}
			else if (FuzzyValue is not null)
			{
				writer.WritePropertyName("fuzzy");
				JsonSerializer.Serialize(writer, FuzzyValue, options);
			}

			if (!string.IsNullOrEmpty(PrefixValue))
			{
				writer.WritePropertyName("prefix");
				writer.WriteStringValue(PrefixValue);
			}

			if (!string.IsNullOrEmpty(RegexValue))
			{
				writer.WritePropertyName("regex");
				writer.WriteStringValue(RegexValue);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SkipDuplicatesValue.HasValue)
			{
				writer.WritePropertyName("skip_duplicates");
				writer.WriteBooleanValue(SkipDuplicatesValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}