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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public sealed class ClusterStateRequestParameters : RequestParameters<ClusterStateRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public long? WaitForMetadataVersion { get => Q<long?>("wait_for_metadata_version"); set => Q("wait_for_metadata_version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? WaitForTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("wait_for_timeout"); set => Q("wait_for_timeout", value); }
	}

	public partial class ClusterStateRequest : PlainRequestBase<ClusterStateRequestParameters>
	{
		public ClusterStateRequest()
		{
		}

		public ClusterStateRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public ClusterStateRequest(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("metric", metric).Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public long? WaitForMetadataVersion { get => Q<long?>("wait_for_metadata_version"); set => Q("wait_for_metadata_version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? WaitForTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("wait_for_timeout"); set => Q("wait_for_timeout", value); }
	}

	public sealed partial class ClusterStateRequestDescriptor<TDocument> : RequestDescriptorBase<ClusterStateRequestDescriptor<TDocument>, ClusterStateRequestParameters>
	{
		internal ClusterStateRequestDescriptor(Action<ClusterStateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ClusterStateRequestDescriptor()
		{
		}

		public ClusterStateRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("metric", metric).Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public ClusterStateRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public ClusterStateRequestDescriptor<TDocument> ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public ClusterStateRequestDescriptor<TDocument> FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public ClusterStateRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public ClusterStateRequestDescriptor<TDocument> Local(bool? local = true) => Qs("local", local);
		public ClusterStateRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterStateRequestDescriptor<TDocument> WaitForMetadataVersion(long? waitForMetadataVersion) => Qs("wait_for_metadata_version", waitForMetadataVersion);
		public ClusterStateRequestDescriptor<TDocument> WaitForTimeout(Elastic.Clients.Elasticsearch.Duration? waitForTimeout) => Qs("wait_for_timeout", waitForTimeout);
		public ClusterStateRequestDescriptor<TDocument> Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
		{
			RouteValues.Optional("metric", metric);
			return Self;
		}

		public ClusterStateRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class ClusterStateRequestDescriptor : RequestDescriptorBase<ClusterStateRequestDescriptor, ClusterStateRequestParameters>
	{
		internal ClusterStateRequestDescriptor(Action<ClusterStateRequestDescriptor> configure) => configure.Invoke(this);
		public ClusterStateRequestDescriptor()
		{
		}

		public ClusterStateRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("metric", metric).Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public ClusterStateRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public ClusterStateRequestDescriptor ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public ClusterStateRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public ClusterStateRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public ClusterStateRequestDescriptor Local(bool? local = true) => Qs("local", local);
		public ClusterStateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterStateRequestDescriptor WaitForMetadataVersion(long? waitForMetadataVersion) => Qs("wait_for_metadata_version", waitForMetadataVersion);
		public ClusterStateRequestDescriptor WaitForTimeout(Elastic.Clients.Elasticsearch.Duration? waitForTimeout) => Qs("wait_for_timeout", waitForTimeout);
		public ClusterStateRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
		{
			RouteValues.Optional("metric", metric);
			return Self;
		}

		public ClusterStateRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}