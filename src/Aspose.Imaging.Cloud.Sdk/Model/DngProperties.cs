// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DngProperties.cs">
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
  /// Represents information about image in DNG format.
  /// </summary>  
  public class DngProperties 
  {                       
        /// <summary>
        /// Gets or sets the DNG version.
        /// </summary>  
        public long? DngVersion { get; set; }

        /// <summary>
        /// Gets or sets the description of colors (RGBG, RGBE, GMCY or GBTG).
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the camera model.
        /// </summary>  
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the camera manufacturer.
        /// </summary>  
        public string CameraManufacturer { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether it's a Foveon matrix.
        /// </summary>  
        public long? IsFoveon { get; set; }

        /// <summary>
        /// Gets or sets the software.
        /// </summary>  
        public string Software { get; set; }

        /// <summary>
        /// Gets or sets the number of RAW images in file (0 means that the file has not been recognized).
        /// </summary>  
        public long? RawCount { get; set; }

        /// <summary>
        /// Gets or sets the bit mask describing the order of color pixels in the matrix.
        /// </summary>  
        public long? Filters { get; set; }

        /// <summary>
        /// Gets or sets the colors count.
        /// </summary>  
        public int? ColorsCount { get; set; }

        /// <summary>
        /// Gets or sets the XMP data.
        /// </summary>  
        public string XmpData { get; set; }

        /// <summary>
        /// Gets or sets the translation array for CFA mosaic of DNG format.
        /// </summary>  
        public List<string> TranslationCfaDng { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DngProperties {\n");
          sb.Append("  DngVersion: ").Append(this.DngVersion).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  Model: ").Append(this.Model).Append("\n");
          sb.Append("  CameraManufacturer: ").Append(this.CameraManufacturer).Append("\n");
          sb.Append("  IsFoveon: ").Append(this.IsFoveon).Append("\n");
          sb.Append("  Software: ").Append(this.Software).Append("\n");
          sb.Append("  RawCount: ").Append(this.RawCount).Append("\n");
          sb.Append("  Filters: ").Append(this.Filters).Append("\n");
          sb.Append("  ColorsCount: ").Append(this.ColorsCount).Append("\n");
          sb.Append("  XmpData: ").Append(this.XmpData).Append("\n");
          sb.Append("  TranslationCfaDng: ").Append(this.TranslationCfaDng).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}