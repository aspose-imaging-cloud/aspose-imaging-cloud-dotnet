// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Jpeg2000Properties.cs">
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
  /// Represents information about image in JPEG2000 format.
  /// </summary>  
  public class Jpeg2000Properties 
  {                       
        /// <summary>
        /// Gets or sets the JPEG2000 codec
        /// </summary>
        /// <value>Gets or sets the JPEG2000 codec</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Jpeg2000Codec
        { 
            /// <summary>
            /// Enum J2K for J2K
            /// </summary>            
            J2K,
            
            /// <summary>
            /// Enum Jp2 for Jp2
            /// </summary>            
            Jp2,
            
            /// <summary>
            /// Enum Jpt for Jpt
            /// </summary>            
            Jpt            
        }

        /// <summary>
        /// Gets or sets the JPEG2000 codec
        /// </summary>
        public Jpeg2000Codec? Codec { get; set; }

        /// <summary>
        /// Gets or sets the JPEG comment markers.
        /// </summary>  
        public List<string> Comments { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Jpeg2000Properties {\n");
          sb.Append("  Comments: ").Append(this.Comments).Append("\n");
          sb.Append("  Codec: ").Append(this.Codec).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}