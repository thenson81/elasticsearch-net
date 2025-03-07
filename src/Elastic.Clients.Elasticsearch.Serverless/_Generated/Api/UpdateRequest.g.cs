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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed class UpdateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Only perform the operation if the document has this primary term.</para>
	/// </summary>
	public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

	/// <summary>
	/// <para>Only perform the operation if the document has this sequence number.</para>
	/// </summary>
	public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

	/// <summary>
	/// <para>The script language.</para>
	/// </summary>
	public string? Lang { get => Q<string?>("lang"); set => Q("lang", value); }

	/// <summary>
	/// <para>If 'true', Elasticsearch refreshes the affected shards to make this operation<br/>visible to search, if 'wait_for' then wait for a refresh to make this operation<br/>visible to search, if 'false' do nothing with refreshes.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Serverless.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>If true, the destination must be an index alias.</para>
	/// </summary>
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }

	/// <summary>
	/// <para>Specify how many times should the operation be retried when a conflict occurs.</para>
	/// </summary>
	public int? RetryOnConflict { get => Q<int?>("retry_on_conflict"); set => Q("retry_on_conflict", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Period to wait for dynamic mapping updates and active shards.<br/>This guarantees Elasticsearch waits for at least the timeout before failing.<br/>The actual wait time could be longer, particularly when multiple waits occur.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>The number of shard copies that must be active before proceeding with the operations.<br/>Set to 'all' or any positive integer up to the total number of shards in the index<br/>(number_of_replicas+1). Defaults to 1 meaning the primary shard.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>Specify the source fields you want to exclude.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>Specify the source fields you want to retrieve.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_includes"); set => Q("_source_includes", value); }
}

/// <summary>
/// <para>Updates a document with a script or partial document.</para>
/// </summary>
public sealed partial class UpdateRequest<TDocument, TPartialDocument> : PlainRequest<UpdateRequestParameters>
{
	public UpdateRequest(Elastic.Clients.Elasticsearch.Serverless.IndexName index, Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceUpdate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "update";

	/// <summary>
	/// <para>Only perform the operation if the document has this primary term.</para>
	/// </summary>
	[JsonIgnore]
	public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

	/// <summary>
	/// <para>Only perform the operation if the document has this sequence number.</para>
	/// </summary>
	[JsonIgnore]
	public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

	/// <summary>
	/// <para>The script language.</para>
	/// </summary>
	[JsonIgnore]
	public string? Lang { get => Q<string?>("lang"); set => Q("lang", value); }

	/// <summary>
	/// <para>If 'true', Elasticsearch refreshes the affected shards to make this operation<br/>visible to search, if 'wait_for' then wait for a refresh to make this operation<br/>visible to search, if 'false' do nothing with refreshes.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Serverless.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>If true, the destination must be an index alias.</para>
	/// </summary>
	[JsonIgnore]
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }

	/// <summary>
	/// <para>Specify how many times should the operation be retried when a conflict occurs.</para>
	/// </summary>
	[JsonIgnore]
	public int? RetryOnConflict { get => Q<int?>("retry_on_conflict"); set => Q("retry_on_conflict", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Period to wait for dynamic mapping updates and active shards.<br/>This guarantees Elasticsearch waits for at least the timeout before failing.<br/>The actual wait time could be longer, particularly when multiple waits occur.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>The number of shard copies that must be active before proceeding with the operations.<br/>Set to 'all' or any positive integer up to the total number of shards in the index<br/>(number_of_replicas+1). Defaults to 1 meaning the primary shard.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>Specify the source fields you want to exclude.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>Specify the source fields you want to retrieve.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>Set to false to disable setting 'result' in the response<br/>to 'noop' if no change to the document occurred.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("detect_noop")]
	public bool? DetectNoop { get; set; }

	/// <summary>
	/// <para>A partial update to an existing document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("doc")]
	[SourceConverter]
	public TPartialDocument? Doc { get; set; }

	/// <summary>
	/// <para>Set to true to use the contents of 'doc' as the value of 'upsert'</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("doc_as_upsert")]
	public bool? DocAsUpsert { get; set; }

	/// <summary>
	/// <para>Script to execute to update the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }

	/// <summary>
	/// <para>Set to true to execute the script whether or not the document exists.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("scripted_upsert")]
	public bool? ScriptedUpsert { get; set; }

	/// <summary>
	/// <para>Set to false to disable source retrieval. You can also specify a comma-separated<br/>list of the fields you want to retrieve.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_source")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? Source { get; set; }

	/// <summary>
	/// <para>If the document does not already exist, the contents of 'upsert' are inserted as a<br/>new document. If the document exists, the 'script' is executed.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("upsert")]
	[SourceConverter]
	public TDocument? Upsert { get; set; }
}

/// <summary>
/// <para>Updates a document with a script or partial document.</para>
/// </summary>
public sealed partial class UpdateRequestDescriptor<TDocument, TPartialDocument> : RequestDescriptor<UpdateRequestDescriptor<TDocument, TPartialDocument>, UpdateRequestParameters>
{
	internal UpdateRequestDescriptor(Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configure) => configure.Invoke(this);

	public UpdateRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.IndexName index, Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	public UpdateRequestDescriptor(TDocument document) : this(typeof(TDocument), Serverless.Id.From(document))
	{
	}

	public UpdateRequestDescriptor(TDocument document, IndexName index, Id id) : this(index, id)
	{
	}

	public UpdateRequestDescriptor(TDocument document, IndexName index) : this(index, Serverless.Id.From(document))
	{
	}

	public UpdateRequestDescriptor(TDocument document, Id id) : this(typeof(TDocument), id)
	{
	}

	public UpdateRequestDescriptor(Id id) : this(typeof(TDocument), id)
	{
	}

	internal UpdateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceUpdate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "update";

	public UpdateRequestDescriptor<TDocument, TPartialDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> IfSeqNo(long? ifSeqNo) => Qs("if_seq_no", ifSeqNo);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Lang(string? lang) => Qs("lang", lang);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Refresh(Elastic.Clients.Elasticsearch.Serverless.Refresh? refresh) => Qs("refresh", refresh);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> RetryOnConflict(int? retryOnConflict) => Qs("retry_on_conflict", retryOnConflict);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public UpdateRequestDescriptor<TDocument, TPartialDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public UpdateRequestDescriptor<TDocument, TPartialDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? SourceValue { get; set; }
	private bool? DetectNoopValue { get; set; }
	private TPartialDocument? DocValue { get; set; }
	private bool? DocAsUpsertValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private bool? ScriptedUpsertValue { get; set; }
	private TDocument? UpsertValue { get; set; }

	/// <summary>
	/// <para>Set to false to disable source retrieval. You can also specify a comma-separated<br/>list of the fields you want to retrieve.</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	/// <summary>
	/// <para>Set to false to disable setting 'result' in the response<br/>to 'noop' if no change to the document occurred.</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> DetectNoop(bool? detectNoop = true)
	{
		DetectNoopValue = detectNoop;
		return Self;
	}

	/// <summary>
	/// <para>A partial update to an existing document.</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Doc(TPartialDocument? doc)
	{
		DocValue = doc;
		return Self;
	}

	/// <summary>
	/// <para>Set to true to use the contents of 'doc' as the value of 'upsert'</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> DocAsUpsert(bool? docAsUpsert = true)
	{
		DocAsUpsertValue = docAsUpsert;
		return Self;
	}

	/// <summary>
	/// <para>Script to execute to update the document.</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Set to true to execute the script whether or not the document exists.</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> ScriptedUpsert(bool? scriptedUpsert = true)
	{
		ScriptedUpsertValue = scriptedUpsert;
		return Self;
	}

	/// <summary>
	/// <para>If the document does not already exist, the contents of 'upsert' are inserted as a<br/>new document. If the document exists, the 'script' is executed.</para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Upsert(TDocument? upsert)
	{
		UpsertValue = upsert;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SourceValue is not null)
		{
			writer.WritePropertyName("_source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (DetectNoopValue.HasValue)
		{
			writer.WritePropertyName("detect_noop");
			writer.WriteBooleanValue(DetectNoopValue.Value);
		}

		if (DocValue is not null)
		{
			writer.WritePropertyName("doc");
			SourceSerialization.Serialize(DocValue, writer, settings);
		}

		if (DocAsUpsertValue.HasValue)
		{
			writer.WritePropertyName("doc_as_upsert");
			writer.WriteBooleanValue(DocAsUpsertValue.Value);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ScriptedUpsertValue.HasValue)
		{
			writer.WritePropertyName("scripted_upsert");
			writer.WriteBooleanValue(ScriptedUpsertValue.Value);
		}

		if (UpsertValue is not null)
		{
			writer.WritePropertyName("upsert");
			SourceSerialization.Serialize(UpsertValue, writer, settings);
		}

		writer.WriteEndObject();
	}
}