// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EpsProperties.cs">
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
  /// 
  /// </summary>  
  public class EpsProperties 
  {                       
        /// <summary>
        /// Gets the BoundingBox.
        /// </summary>  
        public string BoundingBoxString { get; set; }

        /// <summary>
        /// Gets the CreationDate.
        /// </summary>  
        public string CreationDateString { get; set; }

        /// <summary>
        /// Gets the Creator.
        /// </summary>  
        public string Creator { get; set; }

        /// <summary>
        /// Gets the PostScript version.
        /// </summary>  
        public string PostScriptVersion { get; set; }

        /// <summary>
        /// Gets the Title.
        /// </summary>  
        public string Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EpsProperties {\n");
          sb.Append("  BoundingBoxString: ").Append(this.BoundingBoxString).Append("\n");
          sb.Append("  CreationDateString: ").Append(this.CreationDateString).Append("\n");
          sb.Append("  Creator: ").Append(this.Creator).Append("\n");
          sb.Append("  PostScriptVersion: ").Append(this.PostScriptVersion).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
