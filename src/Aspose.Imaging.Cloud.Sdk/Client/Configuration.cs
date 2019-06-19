// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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


namespace Aspose.Imaging.Cloud.Sdk.Client
{
    using System;

    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        #region Consts

        /// <summary>
        /// The default base URL
        /// </summary>
        public const string DefaultBaseUrl = "https://api.aspose.cloud/";

        /// <summary>
        /// The default API version
        /// </summary>
        public const string DefaultApiVersion = "v3.0";

        #endregion

        #region Fields

        /// <summary>
        /// The API base URL
        /// </summary>
        private string apiBaseUrl = DefaultBaseUrl;

        #endregion

        #region Properties

        /// <summary>
        /// Aspose Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl
        {
            get => this.apiBaseUrl;

            set
            {
                if (value.StartsWith("v1") || value.StartsWith("v2"))
                {
                    throw new Exception("This SDK is intended to be used only with API v3 and higher due to breaking changes!");
                }

                this.apiBaseUrl = value;
                if (!this.apiBaseUrl.EndsWith("/"))
                {
                    this.apiBaseUrl += "/";
                }
            }
        }

        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        /// <value>
        /// The API version.
        /// </value>
        public string ApiVersion { get; set; } = DefaultApiVersion;

        /// <summary>
        /// Gets or sets the app key.
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// Gets or sets the app sid.
        /// </summary>
        public string AppSid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether debug mode.
        /// </summary>
        public bool DebugMode { get; set; } = false;

        #endregion

        #region Methods

        /// <summary>
        /// Gets the API root URL.
        /// </summary>
        /// <returns></returns>
        internal string GetApiRootUrl()
        {
            return this.ApiBaseUrl + this.ApiVersion;
        }

        #endregion
    }
}