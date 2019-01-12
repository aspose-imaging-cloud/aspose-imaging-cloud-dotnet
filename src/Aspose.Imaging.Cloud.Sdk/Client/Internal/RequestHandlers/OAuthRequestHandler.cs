// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OAuthRequestHandler.cs">
//   Copyright (c) 2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Cloud.Sdk.Client.Internal.RequestHandlers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Aspose.Imaging.Cloud.Sdk.Client;

    using Newtonsoft.Json;

    /// <summary>
    /// OAuth request hanlder.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Client.Internal.RequestHandlers.IRequestHandler" />
    internal class OAuthRequestHandler : IRequestHandler
    {
        #region Fields

        /// <summary>
        /// The configuration
        /// </summary>
        private readonly Configuration configuration;

        /// <summary>
        /// The API invoker
        /// </summary>
        private readonly ApiInvoker apiInvoker;

        /// <summary>
        /// The access token
        /// </summary>
        private string accessToken;

        /// <summary>
        /// The refresh token
        /// </summary>
        private string refreshToken;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRequestHandler"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public OAuthRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Processes the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// Processed URL.
        /// </returns>
        public string ProcessUrl(string url)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return url;
            }

            if (string.IsNullOrEmpty(this.accessToken))
            {
                this.RequestToken();
            }

            return url;
        }

        /// <summary>
        /// Processes parameters before sending.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="streamToSend">The stream to send.</param>
        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return;
            }

            request.Headers.Add("Authorization", "Bearer " + this.accessToken);
        }

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="resultStream">The result stream.</param>
        /// <exception cref="Aspose.Imaging.Cloud.Sdk.Client.Internal.NeedRepeatRequestException"></exception>
        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                this.RefreshToken();

                throw new NeedRepeatRequestException();
            }
        }

        /// <summary>
        /// Refreshes the token.
        /// </summary>
        private void RefreshToken()
        {
            var requestUrl = this.configuration.ApiBaseUrl + "/oauth2/token";

            var postData = "grant_type=refresh_token";
            postData += "&refresh_token=" + this.refreshToken;

            string responseString = string.Empty;
            using (StreamReader reader = new StreamReader(this.apiInvoker.InvokeApi(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded")))
            {
                responseString = reader.ReadToEnd();
            }

            var result =
                (GetAccessTokenResult)SerializationHelper.Deserialize<GetAccessTokenResult>(responseString);

            this.accessToken = result.AccessToken;
            this.refreshToken = result.RefreshToken;
        }

        /// <summary>
        /// Requests the token.
        /// </summary>
        private void RequestToken()
        {
            var requestUrl = this.configuration.ApiBaseUrl + "/oauth2/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + this.configuration.AppSid;
            postData += "&client_secret=" + this.configuration.AppKey;

            string responseString = string.Empty;
            using (StreamReader reader = new StreamReader(this.apiInvoker.InvokeApi(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded")))
            {
                responseString = reader.ReadToEnd();
            }

            var result =
                (GetAccessTokenResult)SerializationHelper.Deserialize<GetAccessTokenResult>(responseString);

            this.accessToken = result.AccessToken;
            this.refreshToken = result.RefreshToken;
        }

        #endregion

        /// <summary>
        /// Token access result class.
        /// </summary>
        private class GetAccessTokenResult
        {
            /// <summary>
            /// Gets or sets the access token.
            /// </summary>
            /// <value>
            /// The access token.
            /// </value>
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }

            /// <summary>
            /// Gets or sets the refresh token.
            /// </summary>
            /// <value>
            /// The refresh token.
            /// </value>
            [JsonProperty(PropertyName = "refresh_token")]
            public string RefreshToken { get; set; }
        }        
    }
}