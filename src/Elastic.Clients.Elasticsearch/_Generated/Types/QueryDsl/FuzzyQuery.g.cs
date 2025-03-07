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

internal sealed partial class FuzzyQueryConverter : JsonConverter<FuzzyQuery>
{
	public override FuzzyQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		var variant = new FuzzyQuery(fieldName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				if (property == "fuzziness")
				{
					variant.Fuzziness = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fuzziness?>(ref reader, options);
					continue;
				}

				if (property == "max_expansions")
				{
					variant.MaxExpansions = JsonSerializer.Deserialize<int?>(ref reader, options);
					continue;
				}

				if (property == "prefix_length")
				{
					variant.PrefixLength = JsonSerializer.Deserialize<int?>(ref reader, options);
					continue;
				}

				if (property == "rewrite")
				{
					variant.Rewrite = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "transpositions")
				{
					variant.Transpositions = JsonSerializer.Deserialize<bool?>(ref reader, options);
					continue;
				}

				if (property == "value")
				{
					variant.Value = JsonSerializer.Deserialize<object>(ref reader, options);
					continue;
				}
			}
		}

		reader.Read();
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, FuzzyQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize FuzzyQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (options.TryGetClientSettings(out var settings))
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(value.Field));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			if (value.Fuzziness is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, value.Fuzziness, options);
			}

			if (value.MaxExpansions.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(value.MaxExpansions.Value);
			}

			if (value.PrefixLength.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(value.PrefixLength.Value);
			}

			if (value.Rewrite is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, value.Rewrite, options);
			}

			if (value.Transpositions.HasValue)
			{
				writer.WritePropertyName("transpositions");
				writer.WriteBooleanValue(value.Transpositions.Value);
			}

			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, value.Value, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
			return;
		}

		throw new JsonException("Unable to retrieve client settings required to infer field.");
	}
}

[JsonConverter(typeof(FuzzyQueryConverter))]
public sealed partial class FuzzyQuery : SearchQuery
{
	public FuzzyQuery(Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	public string? QueryName { get; set; }
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Maximum edit distance allowed for matching.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

	/// <summary>
	/// <para>Maximum number of variations created.</para>
	/// </summary>
	public int? MaxExpansions { get; set; }

	/// <summary>
	/// <para>Number of beginning characters left unchanged when creating expansions.</para>
	/// </summary>
	public int? PrefixLength { get; set; }

	/// <summary>
	/// <para>Number of beginning characters left unchanged when creating expansions.</para>
	/// </summary>
	public string? Rewrite { get; set; }

	/// <summary>
	/// <para>Indicates whether edits include transpositions of two adjacent characters (for example `ab` to `ba`).</para>
	/// </summary>
	public bool? Transpositions { get; set; }

	/// <summary>
	/// <para>Term you wish to find in the provided field.</para>
	/// </summary>
	public object Value { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	public static implicit operator Query(FuzzyQuery fuzzyQuery) => QueryDsl.Query.Fuzzy(fuzzyQuery);

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("fuzzy", this);
}

public sealed partial class FuzzyQueryDescriptor<TDocument> : SerializableDescriptor<FuzzyQueryDescriptor<TDocument>>
{
	internal FuzzyQueryDescriptor(Action<FuzzyQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	internal FuzzyQueryDescriptor() : base()
	{
	}

	public FuzzyQueryDescriptor(Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		FieldValue = field;
	}

	public FuzzyQueryDescriptor(Expression<Func<TDocument, object>> field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		FieldValue = field;
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }
	private int? MaxExpansionsValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private string? RewriteValue { get; set; }
	private bool? TranspositionsValue { get; set; }
	private object ValueValue { get; set; }

	public FuzzyQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public FuzzyQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public FuzzyQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public FuzzyQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Maximum edit distance allowed for matching.</para>
	/// </summary>
	public FuzzyQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of variations created.</para>
	/// </summary>
	public FuzzyQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions)
	{
		MaxExpansionsValue = maxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>Number of beginning characters left unchanged when creating expansions.</para>
	/// </summary>
	public FuzzyQueryDescriptor<TDocument> PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	/// <summary>
	/// <para>Number of beginning characters left unchanged when creating expansions.</para>
	/// </summary>
	public FuzzyQueryDescriptor<TDocument> Rewrite(string? rewrite)
	{
		RewriteValue = rewrite;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether edits include transpositions of two adjacent characters (for example `ab` to `ba`).</para>
	/// </summary>
	public FuzzyQueryDescriptor<TDocument> Transpositions(bool? transpositions = true)
	{
		TranspositionsValue = transpositions;
		return Self;
	}

	/// <summary>
	/// <para>Term you wish to find in the provided field.</para>
	/// </summary>
	public FuzzyQueryDescriptor<TDocument> Value(object value)
	{
		ValueValue = value;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
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

		if (FuzzinessValue is not null)
		{
			writer.WritePropertyName("fuzziness");
			JsonSerializer.Serialize(writer, FuzzinessValue, options);
		}

		if (MaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("max_expansions");
			writer.WriteNumberValue(MaxExpansionsValue.Value);
		}

		if (PrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("prefix_length");
			writer.WriteNumberValue(PrefixLengthValue.Value);
		}

		if (RewriteValue is not null)
		{
			writer.WritePropertyName("rewrite");
			JsonSerializer.Serialize(writer, RewriteValue, options);
		}

		if (TranspositionsValue.HasValue)
		{
			writer.WritePropertyName("transpositions");
			writer.WriteBooleanValue(TranspositionsValue.Value);
		}

		writer.WritePropertyName("value");
		JsonSerializer.Serialize(writer, ValueValue, options);
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class FuzzyQueryDescriptor : SerializableDescriptor<FuzzyQueryDescriptor>
{
	internal FuzzyQueryDescriptor(Action<FuzzyQueryDescriptor> configure) => configure.Invoke(this);

	internal FuzzyQueryDescriptor() : base()
	{
	}

	public FuzzyQueryDescriptor(Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		FieldValue = field;
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }
	private int? MaxExpansionsValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private string? RewriteValue { get; set; }
	private bool? TranspositionsValue { get; set; }
	private object ValueValue { get; set; }

	public FuzzyQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public FuzzyQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public FuzzyQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public FuzzyQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public FuzzyQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Maximum edit distance allowed for matching.</para>
	/// </summary>
	public FuzzyQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of variations created.</para>
	/// </summary>
	public FuzzyQueryDescriptor MaxExpansions(int? maxExpansions)
	{
		MaxExpansionsValue = maxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>Number of beginning characters left unchanged when creating expansions.</para>
	/// </summary>
	public FuzzyQueryDescriptor PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	/// <summary>
	/// <para>Number of beginning characters left unchanged when creating expansions.</para>
	/// </summary>
	public FuzzyQueryDescriptor Rewrite(string? rewrite)
	{
		RewriteValue = rewrite;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether edits include transpositions of two adjacent characters (for example `ab` to `ba`).</para>
	/// </summary>
	public FuzzyQueryDescriptor Transpositions(bool? transpositions = true)
	{
		TranspositionsValue = transpositions;
		return Self;
	}

	/// <summary>
	/// <para>Term you wish to find in the provided field.</para>
	/// </summary>
	public FuzzyQueryDescriptor Value(object value)
	{
		ValueValue = value;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
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

		if (FuzzinessValue is not null)
		{
			writer.WritePropertyName("fuzziness");
			JsonSerializer.Serialize(writer, FuzzinessValue, options);
		}

		if (MaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("max_expansions");
			writer.WriteNumberValue(MaxExpansionsValue.Value);
		}

		if (PrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("prefix_length");
			writer.WriteNumberValue(PrefixLengthValue.Value);
		}

		if (RewriteValue is not null)
		{
			writer.WritePropertyName("rewrite");
			JsonSerializer.Serialize(writer, RewriteValue, options);
		}

		if (TranspositionsValue.HasValue)
		{
			writer.WritePropertyName("transpositions");
			writer.WriteBooleanValue(TranspositionsValue.Value);
		}

		writer.WritePropertyName("value");
		JsonSerializer.Serialize(writer, ValueValue, options);
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}