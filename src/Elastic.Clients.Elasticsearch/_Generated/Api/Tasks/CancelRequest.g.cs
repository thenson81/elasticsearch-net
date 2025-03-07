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

namespace Elastic.Clients.Elasticsearch.Tasks;

public sealed class CancelRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</para>
	/// </summary>
	public ICollection<string>? Actions { get => Q<ICollection<string>?>("actions"); set => Q("actions", value); }

	/// <summary>
	/// <para>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</para>
	/// </summary>
	public ICollection<string>? Nodes { get => Q<ICollection<string>?>("nodes"); set => Q("nodes", value); }

	/// <summary>
	/// <para>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</para>
	/// </summary>
	public string? ParentTaskId { get => Q<string?>("parent_task_id"); set => Q("parent_task_id", value); }

	/// <summary>
	/// <para>Should the request block until the cancellation of the task and its descendant tasks is completed. Defaults to false</para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// EXPERIMENTAL! May change in ways that are not backwards compatible or be removed entirely.
/// <para>Cancels a task, if it can be cancelled through an API.</para>
/// </summary>
public sealed partial class CancelRequest : PlainRequest<CancelRequestParameters>
{
	public CancelRequest()
	{
	}

	public CancelRequest(Elastic.Clients.Elasticsearch.TaskId? task_id) : base(r => r.Optional("task_id", task_id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TasksCancel;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "tasks.cancel";

	/// <summary>
	/// <para>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Actions { get => Q<ICollection<string>?>("actions"); set => Q("actions", value); }

	/// <summary>
	/// <para>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Nodes { get => Q<ICollection<string>?>("nodes"); set => Q("nodes", value); }

	/// <summary>
	/// <para>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</para>
	/// </summary>
	[JsonIgnore]
	public string? ParentTaskId { get => Q<string?>("parent_task_id"); set => Q("parent_task_id", value); }

	/// <summary>
	/// <para>Should the request block until the cancellation of the task and its descendant tasks is completed. Defaults to false</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// EXPERIMENTAL! May change in ways that are not backwards compatible or be removed entirely.
/// <para>Cancels a task, if it can be cancelled through an API.</para>
/// </summary>
public sealed partial class CancelRequestDescriptor : RequestDescriptor<CancelRequestDescriptor, CancelRequestParameters>
{
	internal CancelRequestDescriptor(Action<CancelRequestDescriptor> configure) => configure.Invoke(this);

	public CancelRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TasksCancel;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "tasks.cancel";

	public CancelRequestDescriptor Actions(ICollection<string>? actions) => Qs("actions", actions);
	public CancelRequestDescriptor Nodes(ICollection<string>? nodes) => Qs("nodes", nodes);
	public CancelRequestDescriptor ParentTaskId(string? parentTaskId) => Qs("parent_task_id", parentTaskId);
	public CancelRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public CancelRequestDescriptor TaskId(Elastic.Clients.Elasticsearch.TaskId? task_id)
	{
		RouteValues.Optional("task_id", task_id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}