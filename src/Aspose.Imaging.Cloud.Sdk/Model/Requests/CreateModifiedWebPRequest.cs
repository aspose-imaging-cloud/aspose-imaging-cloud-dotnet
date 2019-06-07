// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateModifiedWebPRequest.cs">
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

namespace Aspose.Imaging.Cloud.Sdk.Model.Requests 
{
  using Aspose.Imaging.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.CreateModifiedWebP" /> operation.
  /// </summary>  
  public class CreateModifiedWebPRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModifiedWebPRequest"/> class.
        /// </summary>        
        public CreateModifiedWebPRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModifiedWebPRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="lossLess">If WEBP should be in lossless format.</param>
        /// <param name="quality">Quality (0-100).</param>
        /// <param name="animLoopCount">The animation loop count.</param>
        /// <param name="animBackgroundColor">Color of the animation background.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public CreateModifiedWebPRequest(System.IO.Stream imageData, bool? lossLess, int? quality, int? animLoopCount, string animBackgroundColor, bool? fromScratch = null, string outPath = null, string storage = null)             
        {
            this.imageData = imageData;
            this.lossLess = lossLess;
            this.quality = quality;
            this.animLoopCount = animLoopCount;
            this.animBackgroundColor = animBackgroundColor;
            this.fromScratch = fromScratch;
            this.outPath = outPath;
            this.storage = storage;
        }
        
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// If WEBP should be in lossless format.
        /// </summary>  
        public bool? lossLess { get; set; }

        /// <summary>
        /// Quality (0-100).
        /// </summary>  
        public int? quality { get; set; }

        /// <summary>
        /// The animation loop count.
        /// </summary>  
        public int? animLoopCount { get; set; }

        /// <summary>
        /// Color of the animation background.
        /// </summary>  
        public string animBackgroundColor { get; set; }

        /// <summary>
        /// Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.
        /// </summary>  
        public bool? fromScratch { get; set; }

        /// <summary>
        /// Path to updated file (if this is empty, response contains streamed image).
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }
  }
}
