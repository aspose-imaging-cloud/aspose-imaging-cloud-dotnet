// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetObjectBoundsRequest.cs">
//   Copyright (c) 2018-2020 Aspose Pty Ltd. All rights reserved.
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

namespace Aspose.Imaging.Cloud.Sdk.Model.Requests 
{
  using Aspose.Imaging.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.GetObjectBounds" /> operation.
  /// </summary>  
  public class GetObjectBoundsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectBoundsRequest"/> class.
        /// </summary>        
        public GetObjectBoundsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectBoundsRequest"/> class.
        /// </summary>
        /// <param name="name">Image file name.</param>
        /// <param name="method">Object detection method</param>
        /// <param name="threshold">Object detection probability threshold in percents</param>
        /// <param name="includeLabel">Return detected objects labels</param>
        /// <param name="includeScore">Return detected objects score</param>
        /// <param name="allowedLabels">Comma-separated list of allowed labels</param>
        /// <param name="blockedLabels">Comma-separated list of blocked labels</param>
        /// <param name="folder">Folder</param>
        /// <param name="storage">Storage</param>
        public GetObjectBoundsRequest(string name, string method = null, int? threshold = null, bool? includeLabel = null, bool? includeScore = null, string allowedLabels = null, string blockedLabels = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.method = method;
            this.threshold = threshold;
            this.includeLabel = includeLabel;
            this.includeScore = includeScore;
            this.allowedLabels = allowedLabels;
            this.blockedLabels = blockedLabels;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Image file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object detection method
        /// </summary>  
        public string method { get; set; }

        /// <summary>
        /// Object detection probability threshold in percents
        /// </summary>  
        public int? threshold { get; set; }

        /// <summary>
        /// Return detected objects labels
        /// </summary>  
        public bool? includeLabel { get; set; }

        /// <summary>
        /// Return detected objects score
        /// </summary>  
        public bool? includeScore { get; set; }

        /// <summary>
        /// Comma-separated list of allowed labels
        /// </summary>  
        public string allowedLabels { get; set; }

        /// <summary>
        /// Comma-separated list of blocked labels
        /// </summary>  
        public string blockedLabels { get; set; }

        /// <summary>
        /// Folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Storage
        /// </summary>  
        public string storage { get; set; }
  }
}
