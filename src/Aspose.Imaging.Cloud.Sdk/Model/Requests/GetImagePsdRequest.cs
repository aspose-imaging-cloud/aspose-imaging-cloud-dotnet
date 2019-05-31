// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImagePsdRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.GetImagePsd" /> operation.
  /// </summary>  
  public class GetImagePsdRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImagePsdRequest"/> class.
        /// </summary>        
        public GetImagePsdRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImagePsdRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of image.</param>
        /// <param name="channelsCount">Count of color channels.</param>
        /// <param name="compressionMethod">Compression method (for now, raw and RLE are supported).</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public GetImagePsdRequest(string name, int? channelsCount = null, string compressionMethod = null, bool? fromScratch = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.channelsCount = channelsCount;
            this.compressionMethod = compressionMethod;
            this.fromScratch = fromScratch;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Count of color channels.
        /// </summary>  
        public int? channelsCount { get; set; }

        /// <summary>
        /// Compression method (for now, raw and RLE are supported).
        /// </summary>  
        public string compressionMethod { get; set; }

        /// <summary>
        /// Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.
        /// </summary>  
        public bool? fromScratch { get; set; }

        /// <summary>
        /// Folder with image to process.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }
  }
}
