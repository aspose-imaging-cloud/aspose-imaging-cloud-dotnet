// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ModifyTiffRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.ModifyTiff" /> operation.
  /// </summary>  
  public class ModifyTiffRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyTiffRequest"/> class.
        /// </summary>        
        public ModifyTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyTiffRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bitDepth"></param>
        /// <param name="compression"></param>
        /// <param name="resolutionUnit"></param>
        /// <param name="horizontalResolution"></param>
        /// <param name="verticalResolution"></param>
        /// <param name="fromScratch"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        public ModifyTiffRequest(string name, int? bitDepth, string compression = null, string resolutionUnit = null, double? horizontalResolution = null, double? verticalResolution = null, bool? fromScratch = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.bitDepth = bitDepth;
            this.compression = compression;
            this.resolutionUnit = resolutionUnit;
            this.horizontalResolution = horizontalResolution;
            this.verticalResolution = verticalResolution;
            this.fromScratch = fromScratch;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Gets or sets bitDepth
        /// </summary>  
        public int? bitDepth { get; set; }

        /// <summary>
        /// Gets or sets compression
        /// </summary>  
        public string compression { get; set; }

        /// <summary>
        /// Gets or sets resolutionUnit
        /// </summary>  
        public string resolutionUnit { get; set; }

        /// <summary>
        /// Gets or sets horizontalResolution
        /// </summary>  
        public double? horizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets verticalResolution
        /// </summary>  
        public double? verticalResolution { get; set; }

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
