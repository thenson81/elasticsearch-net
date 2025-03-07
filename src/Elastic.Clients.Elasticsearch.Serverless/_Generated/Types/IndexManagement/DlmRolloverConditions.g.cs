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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class DlmRolloverConditions
{
	[JsonInclude, JsonPropertyName("max_age")]
	public string? MaxAge { get; init; }
	[JsonInclude, JsonPropertyName("max_docs")]
	public long? MaxDocs { get; init; }
	[JsonInclude, JsonPropertyName("max_primary_shard_docs")]
	public long? MaxPrimaryShardDocs { get; init; }
	[JsonInclude, JsonPropertyName("max_primary_shard_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MaxPrimaryShardSize { get; init; }
	[JsonInclude, JsonPropertyName("max_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MaxSize { get; init; }
	[JsonInclude, JsonPropertyName("min_age")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MinAge { get; init; }
	[JsonInclude, JsonPropertyName("min_docs")]
	public long? MinDocs { get; init; }
	[JsonInclude, JsonPropertyName("min_primary_shard_docs")]
	public long? MinPrimaryShardDocs { get; init; }
	[JsonInclude, JsonPropertyName("min_primary_shard_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MinPrimaryShardSize { get; init; }
	[JsonInclude, JsonPropertyName("min_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MinSize { get; init; }
}