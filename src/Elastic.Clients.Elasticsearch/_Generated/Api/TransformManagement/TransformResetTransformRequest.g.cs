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
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	public sealed class TransformResetTransformRequestParameters : RequestParameters<TransformResetTransformRequestParameters>
	{
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	public sealed partial class TransformResetTransformRequest : PlainRequestBase<TransformResetTransformRequestParameters>
	{
		public TransformResetTransformRequest(Elastic.Clients.Elasticsearch.Id transform_id) : base(r => r.Required("transform_id", transform_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementResetTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	public sealed partial class TransformResetTransformRequestDescriptor<TDocument> : RequestDescriptorBase<TransformResetTransformRequestDescriptor<TDocument>, TransformResetTransformRequestParameters>
	{
		internal TransformResetTransformRequestDescriptor(Action<TransformResetTransformRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public TransformResetTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Id transform_id) : base(r => r.Required("transform_id", transform_id))
		{
		}

		internal TransformResetTransformRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementResetTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public TransformResetTransformRequestDescriptor<TDocument> Force(bool? force = true) => Qs("force", force);
		public TransformResetTransformRequestDescriptor<TDocument> TransformId(Elastic.Clients.Elasticsearch.Id transform_id)
		{
			RouteValues.Required("transform_id", transform_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class TransformResetTransformRequestDescriptor : RequestDescriptorBase<TransformResetTransformRequestDescriptor, TransformResetTransformRequestParameters>
	{
		internal TransformResetTransformRequestDescriptor(Action<TransformResetTransformRequestDescriptor> configure) => configure.Invoke(this);
		public TransformResetTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Id transform_id) : base(r => r.Required("transform_id", transform_id))
		{
		}

		internal TransformResetTransformRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementResetTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public TransformResetTransformRequestDescriptor Force(bool? force = true) => Qs("force", force);
		public TransformResetTransformRequestDescriptor TransformId(Elastic.Clients.Elasticsearch.Id transform_id)
		{
			RouteValues.Required("transform_id", transform_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}