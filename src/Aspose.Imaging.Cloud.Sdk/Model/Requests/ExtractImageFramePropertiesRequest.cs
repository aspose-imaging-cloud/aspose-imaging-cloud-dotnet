// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExtractImageFramePropertiesRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.ExtractImageFrameProperties" /> operation.
  /// </summary>  
  public class ExtractImageFramePropertiesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractImageFramePropertiesRequest"/> class.
        /// </summary>        
        public ExtractImageFramePropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractImageFramePropertiesRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="frameId">Number of a frame.</param>
        public ExtractImageFramePropertiesRequest(System.IO.Stream imageData, int? frameId)             
        {
            this.imageData = imageData;
            this.frameId = frameId;
        }
        
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Number of a frame.
        /// </summary>  
        public int? frameId { get; set; }
  }
}
