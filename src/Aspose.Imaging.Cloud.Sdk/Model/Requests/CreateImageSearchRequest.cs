// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateImageSearchRequest.cs">
//   Copyright (c) 2019 Aspose Pty Ltd. All rights reserved.
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.CreateImageSearch" /> operation.
  /// </summary>  
  public class CreateImageSearchRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageSearchRequest"/> class.
        /// </summary>        
        public CreateImageSearchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageSearchRequest"/> class.
        /// </summary>
        /// <param name="detector">The image features detector.</param>
        /// <param name="matchingAlgorithm">The matching algorithm.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        public CreateImageSearchRequest(string detector = null, string matchingAlgorithm = null, string folder = null, string storage = null)             
        {
            this.detector = detector;
            this.matchingAlgorithm = matchingAlgorithm;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// The image features detector.
        /// </summary>  
        public string detector { get; set; }

        /// <summary>
        /// The matching algorithm.
        /// </summary>  
        public string matchingAlgorithm { get; set; }

        /// <summary>
        /// The folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// The storage.
        /// </summary>  
        public string storage { get; set; }
  }
}
