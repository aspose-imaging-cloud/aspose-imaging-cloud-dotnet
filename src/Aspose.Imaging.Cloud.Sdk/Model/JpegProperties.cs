// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JpegProperties.cs">
//   Copyright (c) 2018 Aspose Pty Ltd. All rights reserved.
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

namespace Aspose.Imaging.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Represents information about image in JPEG format.
  /// </summary>  
  public class JpegProperties 
  {                       
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>  
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the JPEG EXIF data.
        /// </summary>  
        public JpegExifData JpegExifData { get; set; }

        /// <summary>
        /// Gets or sets the JPEG JFIF data.
        /// </summary>  
        public JfifData JpegJfifData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class JpegProperties {\n");
          sb.Append("  Comment: ").Append(this.Comment).Append("\n");
          sb.Append("  JpegExifData: ").Append(this.JpegExifData).Append("\n");
          sb.Append("  JpegJfifData: ").Append(this.JpegJfifData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}