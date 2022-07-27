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
namespace Elastic.Clients.Elasticsearch.Ccr
{
	public sealed partial class AutoFollowPatternSummary
	{
		[JsonInclude]
		[JsonPropertyName("active")]
		public bool Active { get; init; }

		[JsonInclude]
		[JsonPropertyName("follow_index_pattern")]
		public string? FollowIndexPattern { get; init; }

		[JsonInclude]
		[JsonPropertyName("leader_index_exclusion_patterns")]
		public IReadOnlyCollection<string> LeaderIndexExclusionPatterns { get; init; }

		[JsonInclude]
		[JsonPropertyName("leader_index_patterns")]
		public IReadOnlyCollection<string> LeaderIndexPatterns { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_outstanding_read_requests")]
		public int MaxOutstandingReadRequests { get; init; }

		[JsonInclude]
		[JsonPropertyName("remote_cluster")]
		public string RemoteCluster { get; init; }
	}
}