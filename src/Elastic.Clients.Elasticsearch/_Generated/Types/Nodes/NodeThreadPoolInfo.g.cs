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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public sealed partial class NodeThreadPoolInfo
	{
		[JsonInclude]
		[JsonPropertyName("core")]
		public int? Core { get; init; }

		[JsonInclude]
		[JsonPropertyName("keep_alive")]
		public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get; init; }

		[JsonInclude]
		[JsonPropertyName("max")]
		public int? Max { get; init; }

		[JsonInclude]
		[JsonPropertyName("queue_size")]
		public int QueueSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type { get; init; }
	}
}