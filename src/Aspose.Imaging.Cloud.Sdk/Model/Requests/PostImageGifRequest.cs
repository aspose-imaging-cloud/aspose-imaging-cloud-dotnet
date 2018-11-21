// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostImageGifRequest.cs">
//   Copyright (c) 2018 Aspose Pty Ltd. All rights reserved.
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.PostImageGif" /> operation.
  /// </summary>  
  public class PostImageGifRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageGifRequest"/> class.
        /// </summary>        
        public PostImageGifRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageGifRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="backgroundColorIndex">Index of the background color.</param>
        /// <param name="colorResolution">Color resolution.</param>
        /// <param name="hasTrailer">Specifies if image has trailer.</param>
        /// <param name="interlaced">Specifies if image is interlaced.</param>
        /// <param name="isPaletteSorted">Specifies if palette is sorted.</param>
        /// <param name="pixelAspectRatio">Pixel aspect ratio.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public PostImageGifRequest(System.IO.Stream imageData, int? backgroundColorIndex = null, int? colorResolution = null, bool? hasTrailer = null, bool? interlaced = null, bool? isPaletteSorted = null, int? pixelAspectRatio = null, bool? fromScratch = null, string outPath = null, string storage = null)             
        {
            this.imageData = imageData;
            this.backgroundColorIndex = backgroundColorIndex;
            this.colorResolution = colorResolution;
            this.hasTrailer = hasTrailer;
            this.interlaced = interlaced;
            this.isPaletteSorted = isPaletteSorted;
            this.pixelAspectRatio = pixelAspectRatio;
            this.fromScratch = fromScratch;
            this.outPath = outPath;
            this.storage = storage;
        }
		
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Index of the background color.
        /// </summary>  
        public int? backgroundColorIndex { get; set; }

        /// <summary>
        /// Color resolution.
        /// </summary>  
        public int? colorResolution { get; set; }

        /// <summary>
        /// Specifies if image has trailer.
        /// </summary>  
        public bool? hasTrailer { get; set; }

        /// <summary>
        /// Specifies if image is interlaced.
        /// </summary>  
        public bool? interlaced { get; set; }

        /// <summary>
        /// Specifies if palette is sorted.
        /// </summary>  
        public bool? isPaletteSorted { get; set; }

        /// <summary>
        /// Pixel aspect ratio.
        /// </summary>  
        public int? pixelAspectRatio { get; set; }

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
