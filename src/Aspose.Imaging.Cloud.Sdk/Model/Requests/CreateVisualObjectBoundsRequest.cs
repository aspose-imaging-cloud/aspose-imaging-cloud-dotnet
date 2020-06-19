// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateVisualObjectBoundsRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.CreateVisualObjectBounds" /> operation.
  /// </summary>  
  public class CreateVisualObjectBoundsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVisualObjectBoundsRequest"/> class.
        /// </summary>        
        public CreateVisualObjectBoundsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVisualObjectBoundsRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="method">Object detection method</param>
        /// <param name="threshold">Object detection probability threshold in percents</param>
        /// <param name="includeLabel">Draw detected objects classes</param>
        /// <param name="includeScore">Draw detected objects scores</param>
        /// <param name="allowedLabels">Comma-separated list of allowed labels</param>
        /// <param name="blockedLabels">Comma-separated list of blocked labels</param>
        /// <param name="color">Bounds, labels, and scores text color</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image)</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public CreateVisualObjectBoundsRequest(System.IO.Stream imageData, string method = null, int? threshold = null, bool? includeLabel = null, bool? includeScore = null, string allowedLabels = null, string blockedLabels = null, string color = null, string outPath = null, string storage = null)             
        {
            this.imageData = imageData;
            this.method = method;
            this.threshold = threshold;
            this.includeLabel = includeLabel;
            this.includeScore = includeScore;
            this.allowedLabels = allowedLabels;
            this.blockedLabels = blockedLabels;
            this.color = color;
            this.outPath = outPath;
            this.storage = storage;
        }
        
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Object detection method
        /// </summary>  
        public string method { get; set; }

        /// <summary>
        /// Object detection probability threshold in percents
        /// </summary>  
        public int? threshold { get; set; }

        /// <summary>
        /// Draw detected objects classes
        /// </summary>  
        public bool? includeLabel { get; set; }

        /// <summary>
        /// Draw detected objects scores
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
        /// Bounds, labels, and scores text color
        /// </summary>  
        public string color { get; set; }

        /// <summary>
        /// Path to updated file (if this is empty, response contains streamed image)
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }
  }
}
