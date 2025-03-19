// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ModifyWmfRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.ModifyWmf" /> operation.
  /// </summary>  
  public class ModifyWmfRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyWmfRequest"/> class.
        /// </summary>        
        public ModifyWmfRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyWmfRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bkColor"></param>
        /// <param name="pageWidth"></param>
        /// <param name="pageHeight"></param>
        /// <param name="borderX"></param>
        /// <param name="borderY"></param>
        /// <param name="fromScratch"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        /// <param name="format"></param>
        public ModifyWmfRequest(string name, string bkColor, int? pageWidth, int? pageHeight, int? borderX, int? borderY, bool? fromScratch = null, string folder = null, string storage = null, string format = null)             
        {
            this.name = name;
            this.bkColor = bkColor;
            this.pageWidth = pageWidth;
            this.pageHeight = pageHeight;
            this.borderX = borderX;
            this.borderY = borderY;
            this.fromScratch = fromScratch;
            this.folder = folder;
            this.storage = storage;
            this.format = format;
        }
        
        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Gets or sets bkColor
        /// </summary>  
        public string bkColor { get; set; }

        /// <summary>
        /// Gets or sets pageWidth
        /// </summary>  
        public int? pageWidth { get; set; }

        /// <summary>
        /// Gets or sets pageHeight
        /// </summary>  
        public int? pageHeight { get; set; }

        /// <summary>
        /// Gets or sets borderX
        /// </summary>  
        public int? borderX { get; set; }

        /// <summary>
        /// Gets or sets borderY
        /// </summary>  
        public int? borderY { get; set; }

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

        /// <summary>
        /// Gets or sets format
        /// </summary>  
        public string format { get; set; }
  }
}
