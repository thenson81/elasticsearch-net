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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed class UpdateByQueryRethrottleRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>The throttle to set on this request in floating sub-requests per second. -1 means set no throttle.</para>
	/// </summary>
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }
}

/// <summary>
/// <para>Changes the number of requests per second for a particular Update By Query operation.</para>
/// </summary>
public sealed partial class UpdateByQueryRethrottleRequest : PlainRequest<UpdateByQueryRethrottleRequestParameters>
{
	public UpdateByQueryRethrottleRequest(Elastic.Clients.Elasticsearch.Id task_id) : base(r => r.Required("task_id", task_id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceUpdateByQueryRethrottle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "update_by_query_rethrottle";

	/// <summary>
	/// <para>The throttle to set on this request in floating sub-requests per second. -1 means set no throttle.</para>
	/// </summary>
	[JsonIgnore]
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }
}

/// <summary>
/// <para>Changes the number of requests per second for a particular Update By Query operation.</para>
/// </summary>
public sealed partial class UpdateByQueryRethrottleRequestDescriptor : RequestDescriptor<UpdateByQueryRethrottleRequestDescriptor, UpdateByQueryRethrottleRequestParameters>
{
	internal UpdateByQueryRethrottleRequestDescriptor(Action<UpdateByQueryRethrottleRequestDescriptor> configure) => configure.Invoke(this);

	public UpdateByQueryRethrottleRequestDescriptor(Elastic.Clients.Elasticsearch.Id task_id) : base(r => r.Required("task_id", task_id))
	{
	}

	internal UpdateByQueryRethrottleRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceUpdateByQueryRethrottle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "update_by_query_rethrottle";

	public UpdateByQueryRethrottleRequestDescriptor RequestsPerSecond(float? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);

	public UpdateByQueryRethrottleRequestDescriptor TaskId(Elastic.Clients.Elasticsearch.Id task_id)
	{
		RouteValues.Required("task_id", task_id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}