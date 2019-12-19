// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeskewImageRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.DeskewImage" /> operation.
  /// </summary>  
  public class DeskewImageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeskewImageRequest"/> class.
        /// </summary>        
        public DeskewImageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeskewImageRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of an image.</param>
        /// <param name="resizeProportionally">Resize proportionally</param>
        /// <param name="bkColor">Background color</param>
        /// <param name="folder">Folder</param>
        /// <param name="storage">Storage</param>
        public DeskewImageRequest(string name, bool? resizeProportionally, string bkColor = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.resizeProportionally = resizeProportionally;
            this.bkColor = bkColor;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Filename of an image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Resize proportionally
        /// </summary>  
        public bool? resizeProportionally { get; set; }

        /// <summary>
        /// Background color
        /// </summary>  
        public string bkColor { get; set; }

        /// <summary>
        /// Folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Storage
        /// </summary>  
        public string storage { get; set; }
  }
}
