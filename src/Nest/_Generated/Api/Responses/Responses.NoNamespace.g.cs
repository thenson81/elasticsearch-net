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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class IndexResponse : WriteResponseBase
	{
	}

	public class PingResponse : ResponseBase
	{
	}

	public class SearchResponse<TDocument> : ResponseBase
	{
		[JsonPropertyName("took")]
		public long Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("hits")]
		public HitsMetadata<TDocument> Hits
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("aggregations")]
		public Dictionary<AggregateName, Aggregate>? Aggregations
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_clusters")]
		public ClusterStatistics? Clusters
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("documents")]
		public IReadOnlyCollection<TDocument>? Documents
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("num_reduce_phases")]
		public long? NumReducePhases
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("profile")]
		public Profile? Profile
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pit_id")]
		public Id? PitId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_scroll_id")]
		public ScrollId? ScrollId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("suggest")]
		public Dictionary<SuggestionName, IReadOnlyCollection<Suggest<TDocument>>>? Suggest
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("terminated_early")]
		public bool? TerminatedEarly
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}