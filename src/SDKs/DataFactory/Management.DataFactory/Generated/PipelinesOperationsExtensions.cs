// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PipelinesOperations.
    /// </summary>
    public static partial class PipelinesOperationsExtensions
    {
            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            public static IPage<PipelineResource> ListByFactory(this IPipelinesOperations operations, string resourceGroupName, string factoryName)
            {
                return operations.ListByFactoryAsync(resourceGroupName, factoryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineResource>> ListByFactoryAsync(this IPipelinesOperations operations, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='pipeline'>
            /// Pipeline resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the pipeline entity.  Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            public static PipelineResource CreateOrUpdate(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName, PipelineResource pipeline, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, factoryName, pipelineName, pipeline, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='pipeline'>
            /// Pipeline resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the pipeline entity.  Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineResource> CreateOrUpdateAsync(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName, PipelineResource pipeline, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, factoryName, pipelineName, pipeline, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            public static PipelineResource Get(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName)
            {
                return operations.GetAsync(resourceGroupName, factoryName, pipelineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineResource> GetAsync(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, factoryName, pipelineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            public static void Delete(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName)
            {
                operations.DeleteAsync(resourceGroupName, factoryName, pipelineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, factoryName, pipelineName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a run of a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters of the pipeline run.
            /// </param>
            public static CreateRunResponse CreateRun(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName, IDictionary<string, object> parameters = default(IDictionary<string, object>))
            {
                return operations.CreateRunAsync(resourceGroupName, factoryName, pipelineName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a run of a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters of the pipeline run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateRunResponse> CreateRunAsync(this IPipelinesOperations operations, string resourceGroupName, string factoryName, string pipelineName, IDictionary<string, object> parameters = default(IDictionary<string, object>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateRunWithHttpMessagesAsync(resourceGroupName, factoryName, pipelineName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PipelineResource> ListByFactoryNext(this IPipelinesOperations operations, string nextPageLink)
            {
                return operations.ListByFactoryNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineResource>> ListByFactoryNextAsync(this IPipelinesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFactoryNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}