// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ModifySvgRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.ModifySvg" /> operation.
  /// </summary>  
  public class ModifySvgRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifySvgRequest"/> class.
        /// </summary>        
        public ModifySvgRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifySvgRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of image.</param>
        /// <param name="colorType">Color type for SVG image.</param>
        /// <param name="textAsShapes">Whether text must be converted as shapes. true if all text is turned into SVG shapes in the convertion; otherwise, false</param>
        /// <param name="scaleX">Scale X.</param>
        /// <param name="scaleY">Scale Y.</param>
        /// <param name="pageWidth">Width of the page.</param>
        /// <param name="pageHeight">Height of the page.</param>
        /// <param name="borderX">Border width.</param>
        /// <param name="borderY">Border height.</param>
        /// <param name="bkColor">Background color (Default is white).</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        /// <param name="format">Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases.</param>
        public ModifySvgRequest(string name, string colorType = null, bool? textAsShapes = null, double? scaleX = null, double? scaleY = null, int? pageWidth = null, int? pageHeight = null, int? borderX = null, int? borderY = null, string bkColor = null, bool? fromScratch = null, string folder = null, string storage = null, string format = null)             
        {
            this.name = name;
            this.colorType = colorType;
            this.textAsShapes = textAsShapes;
            this.scaleX = scaleX;
            this.scaleY = scaleY;
            this.pageWidth = pageWidth;
            this.pageHeight = pageHeight;
            this.borderX = borderX;
            this.borderY = borderY;
            this.bkColor = bkColor;
            this.fromScratch = fromScratch;
            this.folder = folder;
            this.storage = storage;
            this.format = format;
        }
        
        /// <summary>
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Color type for SVG image.
        /// </summary>  
        public string colorType { get; set; }

        /// <summary>
        /// Whether text must be converted as shapes. true if all text is turned into SVG shapes in the convertion; otherwise, false
        /// </summary>  
        public bool? textAsShapes { get; set; }

        /// <summary>
        /// Scale X.
        /// </summary>  
        public double? scaleX { get; set; }

        /// <summary>
        /// Scale Y.
        /// </summary>  
        public double? scaleY { get; set; }

        /// <summary>
        /// Width of the page.
        /// </summary>  
        public int? pageWidth { get; set; }

        /// <summary>
        /// Height of the page.
        /// </summary>  
        public int? pageHeight { get; set; }

        /// <summary>
        /// Border width.
        /// </summary>  
        public int? borderX { get; set; }

        /// <summary>
        /// Border height.
        /// </summary>  
        public int? borderY { get; set; }

        /// <summary>
        /// Background color (Default is white).
        /// </summary>  
        public string bkColor { get; set; }

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

        /// <summary>
        /// Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases.
        /// </summary>  
        public string format { get; set; }
  }
}
