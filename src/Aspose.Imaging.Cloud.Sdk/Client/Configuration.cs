// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
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

namespace Aspose.Imaging.Cloud.Sdk.Client
{
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
        public const string DefaultApiVersion = "v2.0";

        #endregion

        #region Fields

        /// <summary>
        /// The API base URL
        /// </summary>
        private string apiBaseUrl = DefaultBaseUrl;

        /// <summary>
        /// The API version
        /// </summary>
        private string apiVersion = DefaultApiVersion;

        /// <summary>
        /// The debug mode
        /// </summary>
        private bool debugMode = false;

        /// <summary>
        /// Authentication type.
        /// Default is URL signing.
        /// </summary>
        private AuthType authType = AuthType.OAuth2;

        #endregion

        #region Properties

        /// <summary>
        /// Aspose Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl
        {
            get
            {
                return this.apiBaseUrl;
            }

            set
            {
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
        public string ApiVersion
        {
            get
            {
                return this.apiVersion;
            }

            set
            {
                this.apiVersion = value;
            }
        }

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
        public bool DebugMode
        {
            get
            {
                return this.debugMode;
            }

            set
            {
                this.debugMode = value;
            }
        }

        /// <summary>
        /// Authentication type.
        /// Default is URL signing.
        /// </summary>
        public AuthType AuthType
        {
            get
            {
                return this.authType;
            }

            set
            {
                this.authType = value;
            }
        }

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