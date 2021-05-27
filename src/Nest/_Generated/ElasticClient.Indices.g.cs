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

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest
{
	public class IndicesNamespace : NamespacedClientProxy
	{
		internal IndicesNamespace(ElasticClient client) : base(client)
		{
		}

		public IndicesCreateResponse Create(IIndicesCreateRequest request)
		{
			return DoRequest<IIndicesCreateRequest, IndicesCreateResponse>(request, request.RequestParameters);
		}

		public Task<IndicesCreateResponse> CreateAsync(IIndicesCreateRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IIndicesCreateRequest, IndicesCreateResponse>(request, request.RequestParameters, cancellationToken);
		}

		public IndicesCreateResponse Create(IndexName index, Func<IndicesCreateDescriptor, IIndicesCreateRequest> selector = null)
		{
			return Create(selector.InvokeOrDefault(new IndicesCreateDescriptor(index)));
		}

		public Task<IndicesCreateResponse> CreateAsync(IndexName index, Func<IndicesCreateDescriptor, IIndicesCreateRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return CreateAsync(selector.InvokeOrDefault(new IndicesCreateDescriptor(index)), cancellationToken);
		}

		public DeleteIndicesResponse Delete(IDeleteIndicesRequest request)
		{
			return DoRequest<IDeleteIndicesRequest, DeleteIndicesResponse>(request, request.RequestParameters);
		}

		public Task<DeleteIndicesResponse> DeleteAsync(IDeleteIndicesRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteIndicesRequest, DeleteIndicesResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeleteIndicesResponse Delete(Indices index, Func<DeleteIndicesDescriptor, IDeleteIndicesRequest> selector = null)
		{
			return Delete(selector.InvokeOrDefault(new DeleteIndicesDescriptor(index)));
		}

		public Task<DeleteIndicesResponse> DeleteAsync(Indices index, Func<DeleteIndicesDescriptor, IDeleteIndicesRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return DeleteAsync(selector.InvokeOrDefault(new DeleteIndicesDescriptor(index)), cancellationToken);
		}
	}
}