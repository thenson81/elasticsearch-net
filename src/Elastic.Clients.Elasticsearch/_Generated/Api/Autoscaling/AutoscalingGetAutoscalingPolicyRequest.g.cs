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
namespace Elastic.Clients.Elasticsearch.Autoscaling
{
	public sealed class AutoscalingGetAutoscalingPolicyRequestParameters : RequestParameters<AutoscalingGetAutoscalingPolicyRequestParameters>
	{
	}

	public sealed partial class AutoscalingGetAutoscalingPolicyRequest : PlainRequestBase<AutoscalingGetAutoscalingPolicyRequestParameters>
	{
		public AutoscalingGetAutoscalingPolicyRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public sealed partial class AutoscalingGetAutoscalingPolicyRequestDescriptor : RequestDescriptorBase<AutoscalingGetAutoscalingPolicyRequestDescriptor, AutoscalingGetAutoscalingPolicyRequestParameters>
	{
		internal AutoscalingGetAutoscalingPolicyRequestDescriptor(Action<AutoscalingGetAutoscalingPolicyRequestDescriptor> configure) => configure.Invoke(this);
		public AutoscalingGetAutoscalingPolicyRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal AutoscalingGetAutoscalingPolicyRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public AutoscalingGetAutoscalingPolicyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}