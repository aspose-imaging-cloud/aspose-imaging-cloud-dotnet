// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateImageRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.UpdateImage" /> operation.
  /// </summary>  
  public class UpdateImageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateImageRequest"/> class.
        /// </summary>        
        public UpdateImageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateImageRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="rectWidth"></param>
        /// <param name="rectHeight"></param>
        /// <param name="rotateFlipMethod"></param>
        /// <param name="format"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        public UpdateImageRequest(string name, int? newWidth, int? newHeight, int? x, int? y, int? rectWidth, int? rectHeight, string rotateFlipMethod, string format = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.newWidth = newWidth;
            this.newHeight = newHeight;
            this.x = x;
            this.y = y;
            this.rectWidth = rectWidth;
            this.rectHeight = rectHeight;
            this.rotateFlipMethod = rotateFlipMethod;
            this.format = format;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Gets or sets newWidth
        /// </summary>  
        public int? newWidth { get; set; }

        /// <summary>
        /// Gets or sets newHeight
        /// </summary>  
        public int? newHeight { get; set; }

        /// <summary>
        /// Gets or sets x
        /// </summary>  
        public int? x { get; set; }

        /// <summary>
        /// Gets or sets y
        /// </summary>  
        public int? y { get; set; }

        /// <summary>
        /// Gets or sets rectWidth
        /// </summary>  
        public int? rectWidth { get; set; }

        /// <summary>
        /// Gets or sets rectHeight
        /// </summary>  
        public int? rectHeight { get; set; }

        /// <summary>
        /// Gets or sets rotateFlipMethod
        /// </summary>  
        public string rotateFlipMethod { get; set; }

        /// <summary>
        /// Gets or sets format
        /// </summary>  
        public string format { get; set; }

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
