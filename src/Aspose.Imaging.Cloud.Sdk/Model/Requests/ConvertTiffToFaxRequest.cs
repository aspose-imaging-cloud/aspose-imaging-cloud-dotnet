// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertTiffToFaxRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.ConvertTiffToFax" /> operation.
  /// </summary>  
  public class ConvertTiffToFaxRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTiffToFaxRequest"/> class.
        /// </summary>        
        public ConvertTiffToFaxRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTiffToFaxRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of image.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        /// <param name="folder">Folder with image to process.</param>
        public ConvertTiffToFaxRequest(string name, string storage = null, string folder = null)             
        {
            this.name = name;
            this.storage = storage;
            this.folder = folder;
        }
        
        /// <summary>
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Folder with image to process.
        /// </summary>  
        public string folder { get; set; }
  }
}
