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

public sealed class MultiTermVectorsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>Specifies if document count, sum of document frequencies and sum of total term frequencies should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public bool? FieldStatistics { get => Q<bool?>("field_statistics"); set => Q("field_statistics", value); }

	/// <summary>
	/// <para>Specifies if term offsets should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public bool? Offsets { get => Q<bool?>("offsets"); set => Q("offsets", value); }

	/// <summary>
	/// <para>Specifies if term payloads should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public bool? Payloads { get => Q<bool?>("payloads"); set => Q("payloads", value); }

	/// <summary>
	/// <para>Specifies if term positions should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public bool? Positions { get => Q<bool?>("positions"); set => Q("positions", value); }

	/// <summary>
	/// <para>Specify the node or shard the operation should be performed on (default: random) .Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>Specifies if requests are real-time as opposed to near-real-time (default: true).</para>
	/// </summary>
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	/// <summary>
	/// <para>Specific routing value. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Specifies if total term frequency and document frequency should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	public bool? TermStatistics { get => Q<bool?>("term_statistics"); set => Q("term_statistics", value); }

	/// <summary>
	/// <para>Explicit version number for concurrency control</para>
	/// </summary>
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>Specific version type</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
}

/// <summary>
/// <para>Returns multiple termvectors in one request.</para>
/// </summary>
public sealed partial class MultiTermVectorsRequest : PlainRequest<MultiTermVectorsRequestParameters>
{
	public MultiTermVectorsRequest()
	{
	}

	public MultiTermVectorsRequest(Elastic.Clients.Elasticsearch.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMtermvectors;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "mtermvectors";

	/// <summary>
	/// <para>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>Specifies if document count, sum of document frequencies and sum of total term frequencies should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public bool? FieldStatistics { get => Q<bool?>("field_statistics"); set => Q("field_statistics", value); }

	/// <summary>
	/// <para>Specifies if term offsets should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public bool? Offsets { get => Q<bool?>("offsets"); set => Q("offsets", value); }

	/// <summary>
	/// <para>Specifies if term payloads should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public bool? Payloads { get => Q<bool?>("payloads"); set => Q("payloads", value); }

	/// <summary>
	/// <para>Specifies if term positions should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public bool? Positions { get => Q<bool?>("positions"); set => Q("positions", value); }

	/// <summary>
	/// <para>Specify the node or shard the operation should be performed on (default: random) .Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>Specifies if requests are real-time as opposed to near-real-time (default: true).</para>
	/// </summary>
	[JsonIgnore]
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	/// <summary>
	/// <para>Specific routing value. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Specifies if total term frequency and document frequency should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</para>
	/// </summary>
	[JsonIgnore]
	public bool? TermStatistics { get => Q<bool?>("term_statistics"); set => Q("term_statistics", value); }

	/// <summary>
	/// <para>Explicit version number for concurrency control</para>
	/// </summary>
	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>Specific version type</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
	[JsonInclude, JsonPropertyName("docs")]
	public ICollection<Elastic.Clients.Elasticsearch.Core.Mtermvectors.MultiTermVectorsOperation>? Docs { get; set; }
	[JsonInclude, JsonPropertyName("ids")]
	public ICollection<Elastic.Clients.Elasticsearch.Id>? Ids { get; set; }
}

/// <summary>
/// <para>Returns multiple termvectors in one request.</para>
/// </summary>
public sealed partial class MultiTermVectorsRequestDescriptor<TDocument> : RequestDescriptor<MultiTermVectorsRequestDescriptor<TDocument>, MultiTermVectorsRequestParameters>
{
	internal MultiTermVectorsRequestDescriptor(Action<MultiTermVectorsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiTermVectorsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMtermvectors;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "mtermvectors";

	public MultiTermVectorsRequestDescriptor<TDocument> FieldStatistics(bool? fieldStatistics = true) => Qs("field_statistics", fieldStatistics);
	public MultiTermVectorsRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public MultiTermVectorsRequestDescriptor<TDocument> Offsets(bool? offsets = true) => Qs("offsets", offsets);
	public MultiTermVectorsRequestDescriptor<TDocument> Payloads(bool? payloads = true) => Qs("payloads", payloads);
	public MultiTermVectorsRequestDescriptor<TDocument> Positions(bool? positions = true) => Qs("positions", positions);
	public MultiTermVectorsRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public MultiTermVectorsRequestDescriptor<TDocument> Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public MultiTermVectorsRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public MultiTermVectorsRequestDescriptor<TDocument> TermStatistics(bool? termStatistics = true) => Qs("term_statistics", termStatistics);
	public MultiTermVectorsRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
	public MultiTermVectorsRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);

	public MultiTermVectorsRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Core.Mtermvectors.MultiTermVectorsOperation>? DocsValue { get; set; }
	private Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument> DocsDescriptor { get; set; }
	private Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument>> DocsDescriptorAction { get; set; }
	private Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument>>[] DocsDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Id>? IdsValue { get; set; }

	public MultiTermVectorsRequestDescriptor<TDocument> Docs(ICollection<Elastic.Clients.Elasticsearch.Core.Mtermvectors.MultiTermVectorsOperation>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor<TDocument> Docs(Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument> descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor<TDocument> Docs(Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument>> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor<TDocument> Docs(params Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument>>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor<TDocument> Ids(ICollection<Elastic.Clients.Elasticsearch.Id>? ids)
	{
		IdsValue = ids;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument>(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Core.Mtermvectors.MultiTermVectorsOperationDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (IdsValue is not null)
		{
			writer.WritePropertyName("ids");
			JsonSerializer.Serialize(writer, IdsValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Returns multiple termvectors in one request.</para>
/// </summary>
public sealed partial class MultiTermVectorsRequestDescriptor : RequestDescriptor<MultiTermVectorsRequestDescriptor, MultiTermVectorsRequestParameters>
{
	internal MultiTermVectorsRequestDescriptor(Action<MultiTermVectorsRequestDescriptor> configure) => configure.Invoke(this);

	public MultiTermVectorsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMtermvectors;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "mtermvectors";

	public MultiTermVectorsRequestDescriptor FieldStatistics(bool? fieldStatistics = true) => Qs("field_statistics", fieldStatistics);
	public MultiTermVectorsRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public MultiTermVectorsRequestDescriptor Offsets(bool? offsets = true) => Qs("offsets", offsets);
	public MultiTermVectorsRequestDescriptor Payloads(bool? payloads = true) => Qs("payloads", payloads);
	public MultiTermVectorsRequestDescriptor Positions(bool? positions = true) => Qs("positions", positions);
	public MultiTermVectorsRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public MultiTermVectorsRequestDescriptor Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public MultiTermVectorsRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public MultiTermVectorsRequestDescriptor TermStatistics(bool? termStatistics = true) => Qs("term_statistics", termStatistics);
	public MultiTermVectorsRequestDescriptor Version(long? version) => Qs("version", version);
	public MultiTermVectorsRequestDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);

	public MultiTermVectorsRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Core.Mtermvectors.MultiTermVectorsOperation>? DocsValue { get; set; }
	private Core.Mtermvectors.MultiTermVectorsOperationDescriptor DocsDescriptor { get; set; }
	private Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor> DocsDescriptorAction { get; set; }
	private Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor>[] DocsDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Id>? IdsValue { get; set; }

	public MultiTermVectorsRequestDescriptor Docs(ICollection<Elastic.Clients.Elasticsearch.Core.Mtermvectors.MultiTermVectorsOperation>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor Docs(Core.Mtermvectors.MultiTermVectorsOperationDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor Docs(Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor Docs(params Action<Core.Mtermvectors.MultiTermVectorsOperationDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	public MultiTermVectorsRequestDescriptor Ids(ICollection<Elastic.Clients.Elasticsearch.Id>? ids)
	{
		IdsValue = ids;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Core.Mtermvectors.MultiTermVectorsOperationDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Core.Mtermvectors.MultiTermVectorsOperationDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (IdsValue is not null)
		{
			writer.WritePropertyName("ids");
			JsonSerializer.Serialize(writer, IdsValue, options);
		}

		writer.WriteEndObject();
	}
}