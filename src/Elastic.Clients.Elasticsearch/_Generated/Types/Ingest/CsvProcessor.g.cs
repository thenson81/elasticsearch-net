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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class CsvProcessor
{
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>Value used to fill empty fields.<br/>Empty fields are skipped if this is not provided.<br/>An empty field is one with no value (2 consecutive separators) or empty quotes (`""`).</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("empty_value")]
	public object? EmptyValue { get; set; }

	/// <summary>
	/// <para>The field to extract data from.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Quote used in CSV, has to be single character string.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("quote")]
	public string? Quote { get; set; }

	/// <summary>
	/// <para>Separator used in CSV, has to be single character string.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("separator")]
	public string? Separator { get; set; }
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The array of fields to assign extracted values to.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_fields")]
	public Elastic.Clients.Elasticsearch.Fields TargetFields { get; set; }

	/// <summary>
	/// <para>Trim whitespaces in unquoted fields.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("trim")]
	public bool? Trim { get; set; }

	public static implicit operator Processor(CsvProcessor csvProcessor) => Ingest.Processor.Csv(csvProcessor);
}

public sealed partial class CsvProcessorDescriptor<TDocument> : SerializableDescriptor<CsvProcessorDescriptor<TDocument>>
{
	internal CsvProcessorDescriptor(Action<CsvProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public CsvProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? DescriptionValue { get; set; }
	private object? EmptyValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private string? QuoteValue { get; set; }
	private string? SeparatorValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields TargetFieldsValue { get; set; }
	private bool? TrimValue { get; set; }

	public CsvProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Value used to fill empty fields.<br/>Empty fields are skipped if this is not provided.<br/>An empty field is one with no value (2 consecutive separators) or empty quotes (`""`).</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> EmptyValue(object? emptyValue)
	{
		EmptyValueValue = emptyValue;
		return Self;
	}

	/// <summary>
	/// <para>The field to extract data from.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to extract data from.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>Quote used in CSV, has to be single character string.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> Quote(string? quote)
	{
		QuoteValue = quote;
		return Self;
	}

	/// <summary>
	/// <para>Separator used in CSV, has to be single character string.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> Separator(string? separator)
	{
		SeparatorValue = separator;
		return Self;
	}

	public CsvProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The array of fields to assign extracted values to.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> TargetFields(Elastic.Clients.Elasticsearch.Fields targetFields)
	{
		TargetFieldsValue = targetFields;
		return Self;
	}

	/// <summary>
	/// <para>Trim whitespaces in unquoted fields.</para>
	/// </summary>
	public CsvProcessorDescriptor<TDocument> Trim(bool? trim = true)
	{
		TrimValue = trim;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (EmptyValueValue is not null)
		{
			writer.WritePropertyName("empty_value");
			JsonSerializer.Serialize(writer, EmptyValueValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (!string.IsNullOrEmpty(QuoteValue))
		{
			writer.WritePropertyName("quote");
			writer.WriteStringValue(QuoteValue);
		}

		if (!string.IsNullOrEmpty(SeparatorValue))
		{
			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		writer.WritePropertyName("target_fields");
		JsonSerializer.Serialize(writer, TargetFieldsValue, options);
		if (TrimValue.HasValue)
		{
			writer.WritePropertyName("trim");
			writer.WriteBooleanValue(TrimValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class CsvProcessorDescriptor : SerializableDescriptor<CsvProcessorDescriptor>
{
	internal CsvProcessorDescriptor(Action<CsvProcessorDescriptor> configure) => configure.Invoke(this);

	public CsvProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? DescriptionValue { get; set; }
	private object? EmptyValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private string? QuoteValue { get; set; }
	private string? SeparatorValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields TargetFieldsValue { get; set; }
	private bool? TrimValue { get; set; }

	public CsvProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public CsvProcessorDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public CsvProcessorDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public CsvProcessorDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public CsvProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Value used to fill empty fields.<br/>Empty fields are skipped if this is not provided.<br/>An empty field is one with no value (2 consecutive separators) or empty quotes (`""`).</para>
	/// </summary>
	public CsvProcessorDescriptor EmptyValue(object? emptyValue)
	{
		EmptyValueValue = emptyValue;
		return Self;
	}

	/// <summary>
	/// <para>The field to extract data from.</para>
	/// </summary>
	public CsvProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to extract data from.</para>
	/// </summary>
	public CsvProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to extract data from.</para>
	/// </summary>
	public CsvProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public CsvProcessorDescriptor If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public CsvProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public CsvProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>Quote used in CSV, has to be single character string.</para>
	/// </summary>
	public CsvProcessorDescriptor Quote(string? quote)
	{
		QuoteValue = quote;
		return Self;
	}

	/// <summary>
	/// <para>Separator used in CSV, has to be single character string.</para>
	/// </summary>
	public CsvProcessorDescriptor Separator(string? separator)
	{
		SeparatorValue = separator;
		return Self;
	}

	public CsvProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The array of fields to assign extracted values to.</para>
	/// </summary>
	public CsvProcessorDescriptor TargetFields(Elastic.Clients.Elasticsearch.Fields targetFields)
	{
		TargetFieldsValue = targetFields;
		return Self;
	}

	/// <summary>
	/// <para>Trim whitespaces in unquoted fields.</para>
	/// </summary>
	public CsvProcessorDescriptor Trim(bool? trim = true)
	{
		TrimValue = trim;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (EmptyValueValue is not null)
		{
			writer.WritePropertyName("empty_value");
			JsonSerializer.Serialize(writer, EmptyValueValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (!string.IsNullOrEmpty(QuoteValue))
		{
			writer.WritePropertyName("quote");
			writer.WriteStringValue(QuoteValue);
		}

		if (!string.IsNullOrEmpty(SeparatorValue))
		{
			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		writer.WritePropertyName("target_fields");
		JsonSerializer.Serialize(writer, TargetFieldsValue, options);
		if (TrimValue.HasValue)
		{
			writer.WritePropertyName("trim");
			writer.WriteBooleanValue(TrimValue.Value);
		}

		writer.WriteEndObject();
	}
}