// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FilterEffectImageRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.FilterEffectImage" /> operation.
  /// </summary>  
  public class FilterEffectImageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterEffectImageRequest"/> class.
        /// </summary>        
        public FilterEffectImageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterEffectImageRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filterType"></param>
        /// <param name="filterProperties"></param>
        /// <param name="format"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        public FilterEffectImageRequest(string name, string filterType, FilterPropertiesBase filterProperties, string format = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.filterType = filterType;
            this.filterProperties = filterProperties;
            this.format = format;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Gets or sets filterType
        /// </summary>  
        public string filterType { get; set; }

        /// <summary>
        /// Gets or sets filterProperties
        /// </summary>  
        public FilterPropertiesBase filterProperties { get; set; }

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
