// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ModifyTiffRequest.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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
        /// <param name="name">Filename of image.</param>
        /// <param name="bitDepth">Bit depth.</param>
        /// <param name="compression">Compression (none is default). Please, refer to https://apireference.aspose.com/net/imaging/aspose.imaging.fileformats.tiff.enums/tiffcompressions for all possible values.</param>
        /// <param name="resolutionUnit">New resolution unit (none - the default one, inch or centimeter).</param>
        /// <param name="horizontalResolution">New horizontal resolution.</param>
        /// <param name="verticalResolution">New vertical resolution.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
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
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Bit depth.
        /// </summary>  
        public int? bitDepth { get; set; }

        /// <summary>
        /// Compression (none is default). Please, refer to https://apireference.aspose.com/net/imaging/aspose.imaging.fileformats.tiff.enums/tiffcompressions for all possible values.
        /// </summary>  
        public string compression { get; set; }

        /// <summary>
        /// New resolution unit (none - the default one, inch or centimeter).
        /// </summary>  
        public string resolutionUnit { get; set; }

        /// <summary>
        /// New horizontal resolution.
        /// </summary>  
        public double? horizontalResolution { get; set; }

        /// <summary>
        /// New vertical resolution.
        /// </summary>  
        public double? verticalResolution { get; set; }

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
