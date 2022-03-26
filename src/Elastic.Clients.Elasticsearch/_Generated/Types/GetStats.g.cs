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
namespace Elastic.Clients.Elasticsearch
{
	public partial class GetStats
	{
		[JsonInclude]
		[JsonPropertyName("current")]
		public long Current { get; init; }

		[JsonInclude]
		[JsonPropertyName("exists_time")]
		public string? ExistsTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("exists_time_in_millis")]
		public long ExistsTimeInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("exists_total")]
		public long ExistsTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("missing_time")]
		public string? MissingTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("missing_time_in_millis")]
		public long MissingTimeInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("missing_total")]
		public long MissingTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("time")]
		public string? Time { get; init; }

		[JsonInclude]
		[JsonPropertyName("time_in_millis")]
		public long TimeInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public long Total { get; init; }
	}
}