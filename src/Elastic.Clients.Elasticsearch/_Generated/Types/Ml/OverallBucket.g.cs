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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed partial class OverallBucket
	{
		[JsonInclude]
		[JsonPropertyName("bucket_span")]
		public long BucketSpan { get; init; }

		[JsonInclude]
		[JsonPropertyName("is_interim")]
		public bool IsInterim { get; init; }

		[JsonInclude]
		[JsonPropertyName("jobs")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ml.OverallBucketJob> Jobs { get; init; }

		[JsonInclude]
		[JsonPropertyName("overall_score")]
		public double OverallScore { get; init; }

		[JsonInclude]
		[JsonPropertyName("result_type")]
		public string ResultType { get; init; }

		[JsonInclude]
		[JsonPropertyName("timestamp")]
		public long Timestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("timestamp_string")]
		public DateTimeOffset TimestampString { get; init; }
	}
}