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
namespace Elastic.Clients.Elasticsearch.Ilm
{
	public sealed partial class Phases
	{
		[JsonInclude]
		[JsonPropertyName("cold")]
		public Elastic.Clients.Elasticsearch.Ilm.Phase? Cold { get; init; }

		[JsonInclude]
		[JsonPropertyName("delete")]
		public Elastic.Clients.Elasticsearch.Ilm.Phase? Delete { get; init; }

		[JsonInclude]
		[JsonPropertyName("hot")]
		public Elastic.Clients.Elasticsearch.Ilm.Phase? Hot { get; init; }

		[JsonInclude]
		[JsonPropertyName("warm")]
		public Elastic.Clients.Elasticsearch.Ilm.Phase? Warm { get; init; }
	}
}