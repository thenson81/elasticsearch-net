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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed partial class IndexSettingsLifecycle
	{
		[JsonInclude]
		[JsonPropertyName("indexing_complete")]
		public bool? IndexingComplete { get; set; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; set; }

		[JsonInclude]
		[JsonPropertyName("origination_date")]
		public long? OriginationDate { get; set; }

		[JsonInclude]
		[JsonPropertyName("parse_origination_date")]
		public bool? ParseOriginationDate { get; set; }

		[JsonInclude]
		[JsonPropertyName("rollover_alias")]
		public string? RolloverAlias { get; set; }

		[JsonInclude]
		[JsonPropertyName("step")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsLifecycleStep? Step { get; set; }
	}

	public sealed partial class IndexSettingsLifecycleDescriptor : SerializableDescriptorBase<IndexSettingsLifecycleDescriptor>
	{
		internal IndexSettingsLifecycleDescriptor(Action<IndexSettingsLifecycleDescriptor> configure) => configure.Invoke(this);
		public IndexSettingsLifecycleDescriptor() : base()
		{
		}

		private bool? IndexingCompleteValue { get; set; }

		private Elastic.Clients.Elasticsearch.Name NameValue { get; set; }

		private long? OriginationDateValue { get; set; }

		private bool? ParseOriginationDateValue { get; set; }

		private string? RolloverAliasValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsLifecycleStep? StepValue { get; set; }

		private IndexSettingsLifecycleStepDescriptor StepDescriptor { get; set; }

		private Action<IndexSettingsLifecycleStepDescriptor> StepDescriptorAction { get; set; }

		public IndexSettingsLifecycleDescriptor IndexingComplete(bool? indexingComplete = true)
		{
			IndexingCompleteValue = indexingComplete;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
		{
			NameValue = name;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor OriginationDate(long? originationDate)
		{
			OriginationDateValue = originationDate;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor ParseOriginationDate(bool? parseOriginationDate = true)
		{
			ParseOriginationDateValue = parseOriginationDate;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor RolloverAlias(string? rolloverAlias)
		{
			RolloverAliasValue = rolloverAlias;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor Step(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsLifecycleStep? step)
		{
			StepDescriptor = null;
			StepDescriptorAction = null;
			StepValue = step;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor Step(IndexSettingsLifecycleStepDescriptor descriptor)
		{
			StepValue = null;
			StepDescriptorAction = null;
			StepDescriptor = descriptor;
			return Self;
		}

		public IndexSettingsLifecycleDescriptor Step(Action<IndexSettingsLifecycleStepDescriptor> configure)
		{
			StepValue = null;
			StepDescriptor = null;
			StepDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IndexingCompleteValue.HasValue)
			{
				writer.WritePropertyName("indexing_complete");
				writer.WriteBooleanValue(IndexingCompleteValue.Value);
			}

			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
			if (OriginationDateValue.HasValue)
			{
				writer.WritePropertyName("origination_date");
				writer.WriteNumberValue(OriginationDateValue.Value);
			}

			if (ParseOriginationDateValue.HasValue)
			{
				writer.WritePropertyName("parse_origination_date");
				writer.WriteBooleanValue(ParseOriginationDateValue.Value);
			}

			if (!string.IsNullOrEmpty(RolloverAliasValue))
			{
				writer.WritePropertyName("rollover_alias");
				writer.WriteStringValue(RolloverAliasValue);
			}

			if (StepDescriptor is not null)
			{
				writer.WritePropertyName("step");
				JsonSerializer.Serialize(writer, StepDescriptor, options);
			}
			else if (StepDescriptorAction is not null)
			{
				writer.WritePropertyName("step");
				JsonSerializer.Serialize(writer, new IndexSettingsLifecycleStepDescriptor(StepDescriptorAction), options);
			}
			else if (StepValue is not null)
			{
				writer.WritePropertyName("step");
				JsonSerializer.Serialize(writer, StepValue, options);
			}

			writer.WriteEndObject();
		}
	}
}