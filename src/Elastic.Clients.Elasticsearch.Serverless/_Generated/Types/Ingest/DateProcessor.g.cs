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

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class DateProcessor
{
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>The field to get the date from.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>An array of the expected date formats.<br/>Can be a java time pattern or one of the following formats: ISO8601, UNIX, UNIX_MS, or TAI64N.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("formats")]
	public ICollection<string> Formats { get; set; }
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>The locale to use when parsing the date, relevant when parsing month names or week days.<br/>Supports template snippets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("locale")]
	public string? Locale { get; set; }
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailure { get; set; }
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The field that will hold the parsed date.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? TargetField { get; set; }

	/// <summary>
	/// <para>The timezone to use when parsing the date.<br/>Supports template snippets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timezone")]
	public string? Timezone { get; set; }

	public static implicit operator Processor(DateProcessor dateProcessor) => Ingest.Processor.Date(dateProcessor);
}

public sealed partial class DateProcessorDescriptor<TDocument> : SerializableDescriptor<DateProcessorDescriptor<TDocument>>
{
	internal DateProcessorDescriptor(Action<DateProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DateProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private ICollection<string> FormatsValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private string? LocaleValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }
	private string? TimezoneValue { get; set; }

	public DateProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the date from.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the date from.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>An array of the expected date formats.<br/>Can be a java time pattern or one of the following formats: ISO8601, UNIX, UNIX_MS, or TAI64N.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> Formats(ICollection<string> formats)
	{
		FormatsValue = formats;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>The locale to use when parsing the date, relevant when parsing month names or week days.<br/>Supports template snippets.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public DateProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the parsed date.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the parsed date.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The timezone to use when parsing the date.<br/>Supports template snippets.</para>
	/// </summary>
	public DateProcessorDescriptor<TDocument> Timezone(string? timezone)
	{
		TimezoneValue = timezone;
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

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("formats");
		JsonSerializer.Serialize(writer, FormatsValue, options);
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

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TimezoneValue))
		{
			writer.WritePropertyName("timezone");
			writer.WriteStringValue(TimezoneValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DateProcessorDescriptor : SerializableDescriptor<DateProcessorDescriptor>
{
	internal DateProcessorDescriptor(Action<DateProcessorDescriptor> configure) => configure.Invoke(this);

	public DateProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private ICollection<string> FormatsValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private string? LocaleValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }
	private string? TimezoneValue { get; set; }

	public DateProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public DateProcessorDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public DateProcessorDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public DateProcessorDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public DateProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the date from.</para>
	/// </summary>
	public DateProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the date from.</para>
	/// </summary>
	public DateProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the date from.</para>
	/// </summary>
	public DateProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>An array of the expected date formats.<br/>Can be a java time pattern or one of the following formats: ISO8601, UNIX, UNIX_MS, or TAI64N.</para>
	/// </summary>
	public DateProcessorDescriptor Formats(ICollection<string> formats)
	{
		FormatsValue = formats;
		return Self;
	}

	public DateProcessorDescriptor If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public DateProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>The locale to use when parsing the date, relevant when parsing month names or week days.<br/>Supports template snippets.</para>
	/// </summary>
	public DateProcessorDescriptor Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public DateProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the parsed date.</para>
	/// </summary>
	public DateProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the parsed date.</para>
	/// </summary>
	public DateProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the parsed date.</para>
	/// </summary>
	public DateProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The timezone to use when parsing the date.<br/>Supports template snippets.</para>
	/// </summary>
	public DateProcessorDescriptor Timezone(string? timezone)
	{
		TimezoneValue = timezone;
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

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("formats");
		JsonSerializer.Serialize(writer, FormatsValue, options);
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

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TimezoneValue))
		{
			writer.WritePropertyName("timezone");
			writer.WriteStringValue(TimezoneValue);
		}

		writer.WriteEndObject();
	}
}