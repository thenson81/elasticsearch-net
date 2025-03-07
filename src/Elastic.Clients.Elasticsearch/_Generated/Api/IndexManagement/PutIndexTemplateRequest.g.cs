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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed class PutIndexTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `true`, this request cannot replace or update existing index templates.</para>
	/// </summary>
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }
}

/// <summary>
/// <para>Creates or updates an index template.<br/>Index templates define settings, mappings, and aliases that can be applied automatically to new indices.</para>
/// </summary>
public sealed partial class PutIndexTemplateRequest : PlainRequest<PutIndexTemplateRequestParameters>
{
	public PutIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_index_template";

	/// <summary>
	/// <para>If `true`, this request cannot replace or update existing index templates.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>Name of the index template to create.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_patterns")]
	public Elastic.Clients.Elasticsearch.Indices? IndexPatterns { get; set; }

	/// <summary>
	/// <para>An ordered list of component template names.<br/>Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("composed_of")]
	public ICollection<Elastic.Clients.Elasticsearch.Name>? ComposedOf { get; set; }

	/// <summary>
	/// <para>Template to be applied.<br/>It may optionally include an `aliases`, `mappings`, or `settings` configuration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("template")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? Template { get; set; }

	/// <summary>
	/// <para>If this object is included, the template is used to create data streams and their backing indices.<br/>Supports an empty object.<br/>Data streams require a matching index template with a `data_stream` object.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("data_stream")]
	public Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStream { get; set; }

	/// <summary>
	/// <para>Priority to determine index template precedence when a new data stream or index is created.<br/>The index template with the highest priority is chosen.<br/>If no priority is specified the template is treated as though it is of priority 0 (lowest priority).<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// <para>Version number used to manage index templates externally.<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }

	/// <summary>
	/// <para>Optional user metadata about the index template.<br/>May have any contents.<br/>This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_meta")]
	public IDictionary<string, object>? Meta { get; set; }
}

/// <summary>
/// <para>Creates or updates an index template.<br/>Index templates define settings, mappings, and aliases that can be applied automatically to new indices.</para>
/// </summary>
public sealed partial class PutIndexTemplateRequestDescriptor<TDocument> : RequestDescriptor<PutIndexTemplateRequestDescriptor<TDocument>, PutIndexTemplateRequestParameters>
{
	internal PutIndexTemplateRequestDescriptor(Action<PutIndexTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal PutIndexTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_index_template";

	public PutIndexTemplateRequestDescriptor<TDocument> Create(bool? create = true) => Qs("create", create);

	public PutIndexTemplateRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }
	private IndexTemplateMappingDescriptor<TDocument> TemplateDescriptor { get; set; }
	private Action<IndexTemplateMappingDescriptor<TDocument>> TemplateDescriptorAction { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStreamValue { get; set; }
	private DataStreamVisibilityDescriptor DataStreamDescriptor { get; set; }
	private Action<DataStreamVisibilityDescriptor> DataStreamDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }
	private int? PriorityValue { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Template to be applied.<br/>It may optionally include an `aliases`, `mappings`, or `settings` configuration.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
	{
		TemplateDescriptor = null;
		TemplateDescriptorAction = null;
		TemplateValue = template;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor<TDocument> Template(IndexTemplateMappingDescriptor<TDocument> descriptor)
	{
		TemplateValue = null;
		TemplateDescriptorAction = null;
		TemplateDescriptor = descriptor;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor<TDocument> Template(Action<IndexTemplateMappingDescriptor<TDocument>> configure)
	{
		TemplateValue = null;
		TemplateDescriptor = null;
		TemplateDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Optional user metadata about the index template.<br/>May have any contents.<br/>This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>An ordered list of component template names.<br/>Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> ComposedOf(ICollection<Elastic.Clients.Elasticsearch.Name>? composedOf)
	{
		ComposedOfValue = composedOf;
		return Self;
	}

	/// <summary>
	/// <para>If this object is included, the template is used to create data streams and their backing indices.<br/>Supports an empty object.<br/>Data streams require a matching index template with a `data_stream` object.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? dataStream)
	{
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = null;
		DataStreamValue = dataStream;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor<TDocument> DataStream(DataStreamVisibilityDescriptor descriptor)
	{
		DataStreamValue = null;
		DataStreamDescriptorAction = null;
		DataStreamDescriptor = descriptor;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor<TDocument> DataStream(Action<DataStreamVisibilityDescriptor> configure)
	{
		DataStreamValue = null;
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Name of the index template to create.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>Priority to determine index template precedence when a new data stream or index is created.<br/>The index template with the highest priority is chosen.<br/>If no priority is specified the template is treated as though it is of priority 0 (lowest priority).<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> Priority(int? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	/// <summary>
	/// <para>Version number used to manage index templates externally.<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (TemplateDescriptor is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateDescriptor, options);
		}
		else if (TemplateDescriptorAction is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, new IndexTemplateMappingDescriptor<TDocument>(TemplateDescriptorAction), options);
		}
		else if (TemplateValue is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (ComposedOfValue is not null)
		{
			writer.WritePropertyName("composed_of");
			JsonSerializer.Serialize(writer, ComposedOfValue, options);
		}

		if (DataStreamDescriptor is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
		}
		else if (DataStreamDescriptorAction is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, new DataStreamVisibilityDescriptor(DataStreamDescriptorAction), options);
		}
		else if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			JsonSerializer.Serialize(writer, IndexPatternsValue, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Creates or updates an index template.<br/>Index templates define settings, mappings, and aliases that can be applied automatically to new indices.</para>
/// </summary>
public sealed partial class PutIndexTemplateRequestDescriptor : RequestDescriptor<PutIndexTemplateRequestDescriptor, PutIndexTemplateRequestParameters>
{
	internal PutIndexTemplateRequestDescriptor(Action<PutIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public PutIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal PutIndexTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_index_template";

	public PutIndexTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);

	public PutIndexTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }
	private IndexTemplateMappingDescriptor TemplateDescriptor { get; set; }
	private Action<IndexTemplateMappingDescriptor> TemplateDescriptorAction { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStreamValue { get; set; }
	private DataStreamVisibilityDescriptor DataStreamDescriptor { get; set; }
	private Action<DataStreamVisibilityDescriptor> DataStreamDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }
	private int? PriorityValue { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Template to be applied.<br/>It may optionally include an `aliases`, `mappings`, or `settings` configuration.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
	{
		TemplateDescriptor = null;
		TemplateDescriptorAction = null;
		TemplateValue = template;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor Template(IndexTemplateMappingDescriptor descriptor)
	{
		TemplateValue = null;
		TemplateDescriptorAction = null;
		TemplateDescriptor = descriptor;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor Template(Action<IndexTemplateMappingDescriptor> configure)
	{
		TemplateValue = null;
		TemplateDescriptor = null;
		TemplateDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Optional user metadata about the index template.<br/>May have any contents.<br/>This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>An ordered list of component template names.<br/>Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor ComposedOf(ICollection<Elastic.Clients.Elasticsearch.Name>? composedOf)
	{
		ComposedOfValue = composedOf;
		return Self;
	}

	/// <summary>
	/// <para>If this object is included, the template is used to create data streams and their backing indices.<br/>Supports an empty object.<br/>Data streams require a matching index template with a `data_stream` object.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? dataStream)
	{
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = null;
		DataStreamValue = dataStream;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor DataStream(DataStreamVisibilityDescriptor descriptor)
	{
		DataStreamValue = null;
		DataStreamDescriptorAction = null;
		DataStreamDescriptor = descriptor;
		return Self;
	}

	public PutIndexTemplateRequestDescriptor DataStream(Action<DataStreamVisibilityDescriptor> configure)
	{
		DataStreamValue = null;
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Name of the index template to create.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>Priority to determine index template precedence when a new data stream or index is created.<br/>The index template with the highest priority is chosen.<br/>If no priority is specified the template is treated as though it is of priority 0 (lowest priority).<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor Priority(int? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	/// <summary>
	/// <para>Version number used to manage index templates externally.<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PutIndexTemplateRequestDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (TemplateDescriptor is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateDescriptor, options);
		}
		else if (TemplateDescriptorAction is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, new IndexTemplateMappingDescriptor(TemplateDescriptorAction), options);
		}
		else if (TemplateValue is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (ComposedOfValue is not null)
		{
			writer.WritePropertyName("composed_of");
			JsonSerializer.Serialize(writer, ComposedOfValue, options);
		}

		if (DataStreamDescriptor is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
		}
		else if (DataStreamDescriptorAction is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, new DataStreamVisibilityDescriptor(DataStreamDescriptorAction), options);
		}
		else if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			JsonSerializer.Serialize(writer, IndexPatternsValue, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}