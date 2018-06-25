// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSearchContextFindByTagsRequest.cs">
//   Copyright (c) 2018 Aspose.Imaging for Cloud
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.PostSearchContextFindByTags" /> operation.
  /// </summary>  
  public class PostSearchContextFindByTagsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSearchContextFindByTagsRequest"/> class.
        /// </summary>        
        public PostSearchContextFindByTagsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSearchContextFindByTagsRequest"/> class.
        /// </summary>
        /// <param name="searchContextId">The search context identifier.</param>
        /// <param name="similarityThreshold">The similarity threshold.</param>
        /// <param name="maxCount">The maximum count.</param>
        public PostSearchContextFindByTagsRequest(string searchContextId, double? similarityThreshold, int? maxCount)             
        {
            this.searchContextId = searchContextId;
            this.similarityThreshold = similarityThreshold;
            this.maxCount = maxCount;
        }
		
        /// <summary>
        /// The search context identifier.
        /// </summary>  
        public string searchContextId { get; set; }

        /// <summary>
        /// The similarity threshold.
        /// </summary>  
        public double? similarityThreshold { get; set; }

        /// <summary>
        /// The maximum count.
        /// </summary>  
        public int? maxCount { get; set; }
  }
}
