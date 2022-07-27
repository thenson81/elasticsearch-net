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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlEvaluateDataFrameRequestParameters : RequestParameters<MlEvaluateDataFrameRequestParameters>
	{
	}

	public sealed partial class MlEvaluateDataFrameRequest : PlainRequestBase<MlEvaluateDataFrameRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningEvaluateDataFrame;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("evaluation")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationContainer Evaluation { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }
	}

	public sealed partial class MlEvaluateDataFrameRequestDescriptor<TDocument> : RequestDescriptorBase<MlEvaluateDataFrameRequestDescriptor<TDocument>, MlEvaluateDataFrameRequestParameters>
	{
		internal MlEvaluateDataFrameRequestDescriptor(Action<MlEvaluateDataFrameRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlEvaluateDataFrameRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningEvaluateDataFrame;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationContainer EvaluationValue { get; set; }

		private DataframeEvaluationContainerDescriptor<TDocument> EvaluationDescriptor { get; set; }

		private Action<DataframeEvaluationContainerDescriptor<TDocument>> EvaluationDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName IndexValue { get; set; }

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Evaluation(Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationContainer evaluation)
		{
			EvaluationDescriptor = null;
			EvaluationDescriptorAction = null;
			EvaluationValue = evaluation;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Evaluation(DataframeEvaluationContainerDescriptor<TDocument> descriptor)
		{
			EvaluationValue = null;
			EvaluationDescriptorAction = null;
			EvaluationDescriptor = descriptor;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Evaluation(Action<DataframeEvaluationContainerDescriptor<TDocument>> configure)
		{
			EvaluationValue = null;
			EvaluationDescriptor = null;
			EvaluationDescriptorAction = configure;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			IndexValue = index;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (EvaluationDescriptor is not null)
			{
				writer.WritePropertyName("evaluation");
				JsonSerializer.Serialize(writer, EvaluationDescriptor, options);
			}
			else if (EvaluationDescriptorAction is not null)
			{
				writer.WritePropertyName("evaluation");
				JsonSerializer.Serialize(writer, new DataframeEvaluationContainerDescriptor<TDocument>(EvaluationDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("evaluation");
				JsonSerializer.Serialize(writer, EvaluationValue, options);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class MlEvaluateDataFrameRequestDescriptor : RequestDescriptorBase<MlEvaluateDataFrameRequestDescriptor, MlEvaluateDataFrameRequestParameters>
	{
		internal MlEvaluateDataFrameRequestDescriptor(Action<MlEvaluateDataFrameRequestDescriptor> configure) => configure.Invoke(this);
		public MlEvaluateDataFrameRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningEvaluateDataFrame;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationContainer EvaluationValue { get; set; }

		private DataframeEvaluationContainerDescriptor EvaluationDescriptor { get; set; }

		private Action<DataframeEvaluationContainerDescriptor> EvaluationDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> QueryDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName IndexValue { get; set; }

		public MlEvaluateDataFrameRequestDescriptor Evaluation(Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationContainer evaluation)
		{
			EvaluationDescriptor = null;
			EvaluationDescriptorAction = null;
			EvaluationValue = evaluation;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor Evaluation(DataframeEvaluationContainerDescriptor descriptor)
		{
			EvaluationValue = null;
			EvaluationDescriptorAction = null;
			EvaluationDescriptor = descriptor;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor Evaluation(Action<DataframeEvaluationContainerDescriptor> configure)
		{
			EvaluationValue = null;
			EvaluationDescriptor = null;
			EvaluationDescriptorAction = configure;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor Query(QueryDsl.QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor Query(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public MlEvaluateDataFrameRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			IndexValue = index;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (EvaluationDescriptor is not null)
			{
				writer.WritePropertyName("evaluation");
				JsonSerializer.Serialize(writer, EvaluationDescriptor, options);
			}
			else if (EvaluationDescriptorAction is not null)
			{
				writer.WritePropertyName("evaluation");
				JsonSerializer.Serialize(writer, new DataframeEvaluationContainerDescriptor(EvaluationDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("evaluation");
				JsonSerializer.Serialize(writer, EvaluationValue, options);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WriteEndObject();
		}
	}
}