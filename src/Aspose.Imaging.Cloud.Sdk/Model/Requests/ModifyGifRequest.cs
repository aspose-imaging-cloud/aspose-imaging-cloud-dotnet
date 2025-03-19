// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ModifyGifRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.ModifyGif" /> operation.
  /// </summary>  
  public class ModifyGifRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyGifRequest"/> class.
        /// </summary>        
        public ModifyGifRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyGifRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="backgroundColorIndex"></param>
        /// <param name="colorResolution"></param>
        /// <param name="hasTrailer"></param>
        /// <param name="interlaced"></param>
        /// <param name="isPaletteSorted"></param>
        /// <param name="pixelAspectRatio"></param>
        /// <param name="fromScratch"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        public ModifyGifRequest(string name, int? backgroundColorIndex = null, int? colorResolution = null, bool? hasTrailer = null, bool? interlaced = null, bool? isPaletteSorted = null, int? pixelAspectRatio = null, bool? fromScratch = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.backgroundColorIndex = backgroundColorIndex;
            this.colorResolution = colorResolution;
            this.hasTrailer = hasTrailer;
            this.interlaced = interlaced;
            this.isPaletteSorted = isPaletteSorted;
            this.pixelAspectRatio = pixelAspectRatio;
            this.fromScratch = fromScratch;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Gets or sets backgroundColorIndex
        /// </summary>  
        public int? backgroundColorIndex { get; set; }

        /// <summary>
        /// Gets or sets colorResolution
        /// </summary>  
        public int? colorResolution { get; set; }

        /// <summary>
        /// Gets or sets hasTrailer
        /// </summary>  
        public bool? hasTrailer { get; set; }

        /// <summary>
        /// Gets or sets interlaced
        /// </summary>  
        public bool? interlaced { get; set; }

        /// <summary>
        /// Gets or sets isPaletteSorted
        /// </summary>  
        public bool? isPaletteSorted { get; set; }

        /// <summary>
        /// Gets or sets pixelAspectRatio
        /// </summary>  
        public int? pixelAspectRatio { get; set; }

        /// <summary>
        /// Gets or sets fromScratch
        /// </summary>  
        public bool? fromScratch { get; set; }

        /// <summary>
        /// Gets or sets folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }
  }
}
