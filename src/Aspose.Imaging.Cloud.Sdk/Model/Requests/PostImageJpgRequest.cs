// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostImageJpgRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.PostImageJpg" /> operation.
  /// </summary>  
  public class PostImageJpgRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageJpgRequest"/> class.
        /// </summary>        
        public PostImageJpgRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageJpgRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="quality">Quality of an image from 0 to 100. Default is 75.</param>
        /// <param name="compressionType">Compression type.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public PostImageJpgRequest(System.IO.Stream imageData, int? quality = null, string compressionType = null, bool? fromScratch = null, string outPath = null, string storage = null)             
        {
            this.imageData = imageData;
            this.quality = quality;
            this.compressionType = compressionType;
            this.fromScratch = fromScratch;
            this.outPath = outPath;
            this.storage = storage;
        }
		
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Quality of an image from 0 to 100. Default is 75.
        /// </summary>  
        public int? quality { get; set; }

        /// <summary>
        /// Compression type.
        /// </summary>  
        public string compressionType { get; set; }

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
