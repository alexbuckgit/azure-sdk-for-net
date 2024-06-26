// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.OpenAI
{
    // Data plane generated client.
    /// <summary> The OpenAI service client. </summary>
    public partial class OpenAIClient
    {
        private const string AuthorizationHeader = "api-key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://cognitiveservices.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of OpenAIClient for mocking. </summary>
        protected OpenAIClient()
        {
        }

        /// <summary>
        /// [Protocol Method] Gets transcribed text and associated metadata from provided spoken audio data. Audio will be transcribed in the
        /// written language corresponding to the language it was spoken in.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetAudioTranscriptionAsPlainTextAsync(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranscriptionAsPlainText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranscriptionAsPlainTextRequest(deploymentId, content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets transcribed text and associated metadata from provided spoken audio data. Audio will be transcribed in the
        /// written language corresponding to the language it was spoken in.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetAudioTranscriptionAsPlainText(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranscriptionAsPlainText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranscriptionAsPlainTextRequest(deploymentId, content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets transcribed text and associated metadata from provided spoken audio data. Audio will be transcribed in the
        /// written language corresponding to the language it was spoken in.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetAudioTranscriptionAsResponseObjectAsync(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranscriptionAsResponseObject");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranscriptionAsResponseObjectRequest(deploymentId, content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets transcribed text and associated metadata from provided spoken audio data. Audio will be transcribed in the
        /// written language corresponding to the language it was spoken in.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetAudioTranscriptionAsResponseObject(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranscriptionAsResponseObject");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranscriptionAsResponseObjectRequest(deploymentId, content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets English language transcribed text and associated metadata from provided spoken audio data.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetAudioTranslationAsPlainTextAsync(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranslationAsPlainText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranslationAsPlainTextRequest(deploymentId, content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets English language transcribed text and associated metadata from provided spoken audio data.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetAudioTranslationAsPlainText(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranslationAsPlainText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranslationAsPlainTextRequest(deploymentId, content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets English language transcribed text and associated metadata from provided spoken audio data.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetAudioTranslationAsResponseObjectAsync(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranslationAsResponseObject");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranslationAsResponseObjectRequest(deploymentId, content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets English language transcribed text and associated metadata from provided spoken audio data.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The content type for the operation. Always multipart/form-data for this operation. Allowed values: "multipart/form-data". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetAudioTranslationAsResponseObject(string deploymentId, RequestContent content, string contentType, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("OpenAIClient.GetAudioTranslationAsResponseObject");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAudioTranslationAsResponseObjectRequest(deploymentId, content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAudioTranscriptionAsPlainTextRequest(string deploymentId, RequestContent content, string contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/openai", false);
            uri.AppendPath("/deployments/", false);
            uri.AppendPath(deploymentId, true);
            uri.AppendPath("/audio/transcriptions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "text/plain");
            request.Headers.Add("content-type", contentType);
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAudioTranscriptionAsResponseObjectRequest(string deploymentId, RequestContent content, string contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/openai", false);
            uri.AppendPath("/deployments/", false);
            uri.AppendPath(deploymentId, true);
            uri.AppendPath("/audio/transcriptions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", contentType);
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAudioTranslationAsPlainTextRequest(string deploymentId, RequestContent content, string contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/openai", false);
            uri.AppendPath("/deployments/", false);
            uri.AppendPath(deploymentId, true);
            uri.AppendPath("/audio/translations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "text/plain");
            request.Headers.Add("content-type", contentType);
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAudioTranslationAsResponseObjectRequest(string deploymentId, RequestContent content, string contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/openai", false);
            uri.AppendPath("/deployments/", false);
            uri.AppendPath(deploymentId, true);
            uri.AppendPath("/audio/translations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", contentType);
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
