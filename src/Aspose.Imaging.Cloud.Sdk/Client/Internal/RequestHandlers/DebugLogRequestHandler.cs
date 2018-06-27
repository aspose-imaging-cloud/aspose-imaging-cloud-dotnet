// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DebugLogRequestHandler.cs">
//   Copyright (c) 2018 Aspose Pty Ltd.
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
    using Aspose.Imaging.Cloud.Sdk.Client;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Text;

    /// <summary>
    /// Debug log request handler.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Client.Internal.RequestHandlers.IRequestHandler" />
    internal class DebugLogRequestHandler : IRequestHandler
    {
        #region Fields

        /// <summary>
        /// The configuration
        /// </summary>
        private readonly Configuration configuration;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugLogRequestHandler"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public DebugLogRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;
        }


        #endregion

        #region Methods

        /// <summary>
        /// Processes the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>Processed URL.</returns>
        public string ProcessUrl(string url)
        {
            return url;
        }

        /// <summary>
        /// Processes parameters before sending.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="streamToSend">The stream to send.</param>
        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (this.configuration.DebugMode)
            {
                this.LogRequest(request, streamToSend);
            }
        }

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="resultStream">The result stream.</param>
        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (this.configuration.DebugMode)
            {
                resultStream.Position = 0;
                this.LogResponse(response, resultStream);
            }
        }

        /// <summary>
        /// Logs the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="streamToSend">The stream to send.</param>
        private void LogRequest(WebRequest request, Stream streamToSend)
        {
            var header = string.Format("{0}: {1}", request.Method, request.RequestUri);
            var sb = new StringBuilder();

            this.FormatHeaders(sb, request.Headers);
            if (streamToSend != null)
            {
                streamToSend.Position = 0;
                StreamHelper.CopyStreamToStringBuilder(sb, streamToSend);
                streamToSend.Position = 0;
            }

            this.Log(header, sb);
        }

        /// <summary>
        /// Logs the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="resultStream">The result stream.</param>
        private void LogResponse(HttpWebResponse response, Stream resultStream)
        {
            var header = string.Format("\r\nResponse {0}: {1}", (int)response.StatusCode, response.StatusCode);
            var sb = new StringBuilder();

            this.FormatHeaders(sb, response.Headers);
            StreamHelper.CopyStreamToStringBuilder(sb, resultStream);
            this.Log(header, sb);
        }

        /// <summary>
        /// Formats the headers.
        /// </summary>
        /// <param name="sb">The string builder.</param>
        /// <param name="headerDictionary">The header dictionary.</param>
        private void FormatHeaders(StringBuilder sb, WebHeaderCollection headerDictionary)
        {
            foreach (var key in headerDictionary.AllKeys)
            {
                sb.Append(key);
                sb.Append(": ");
                sb.AppendLine(headerDictionary[key]);
            }
        }

        /// <summary>
        /// Logs the specified header and string builder.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="sb">The string builder.</param>
        private void Log(string header, StringBuilder sb)
        {
            Trace.WriteLine(header);
            Trace.WriteLine(sb.ToString());
        }

        #endregion
    }
}