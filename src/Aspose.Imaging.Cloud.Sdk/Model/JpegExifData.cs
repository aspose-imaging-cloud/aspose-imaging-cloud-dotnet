// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JpegExifData.cs">
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
  /// Represents EXIF data for JPEG
  /// </summary>  
  public class JpegExifData : ExifData 
  {                       
        /// <summary>
        /// Gets or sets the artist.
        /// </summary>  
        public string Artist { get; set; }

        /// <summary>
        /// Gets or sets the copyright info.
        /// </summary>  
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the date and time.
        /// </summary>  
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets the image description.
        /// </summary>  
        public string ImageDescription { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>  
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>  
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>  
        public string Orientation { get; set; }

        /// <summary>
        /// Gets or sets the primary chromaticities.
        /// </summary>  
        public List<double?> PrimaryChromaticities { get; set; }

        /// <summary>
        /// Gets or sets the reference black and white.
        /// </summary>  
        public List<double?> ReferenceBlackWhite { get; set; }

        /// <summary>
        /// Gets or sets the resolution unit.
        /// </summary>  
        public string ResolutionUnit { get; set; }

        /// <summary>
        /// Gets or sets the software.
        /// </summary>  
        public string Software { get; set; }

        /// <summary>
        /// Gets or sets the transfer function.
        /// </summary>  
        public List<int?> TransferFunction { get; set; }

        /// <summary>
        /// Gets or sets the X resolution.
        /// </summary>  
        public double? XResolution { get; set; }

        /// <summary>
        /// Gets or sets the YCbCr coefficients.
        /// </summary>  
        public List<double?> YCbCrCoefficients { get; set; }

        /// <summary>
        /// Gets or sets the YCbCr positioning.
        /// </summary>  
        public string YCbCrPositioning { get; set; }

        /// <summary>
        /// Gets or sets the Y resolution.
        /// </summary>  
        public double? YResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class JpegExifData {\n");
          sb.Append("  Artist: ").Append(this.Artist).Append("\n");
          sb.Append("  Copyright: ").Append(this.Copyright).Append("\n");
          sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
          sb.Append("  ImageDescription: ").Append(this.ImageDescription).Append("\n");
          sb.Append("  Make: ").Append(this.Make).Append("\n");
          sb.Append("  Model: ").Append(this.Model).Append("\n");
          sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
          sb.Append("  PrimaryChromaticities: ").Append(this.PrimaryChromaticities).Append("\n");
          sb.Append("  ReferenceBlackWhite: ").Append(this.ReferenceBlackWhite).Append("\n");
          sb.Append("  ResolutionUnit: ").Append(this.ResolutionUnit).Append("\n");
          sb.Append("  Software: ").Append(this.Software).Append("\n");
          sb.Append("  TransferFunction: ").Append(this.TransferFunction).Append("\n");
          sb.Append("  XResolution: ").Append(this.XResolution).Append("\n");
          sb.Append("  YCbCrCoefficients: ").Append(this.YCbCrCoefficients).Append("\n");
          sb.Append("  YCbCrPositioning: ").Append(this.YCbCrPositioning).Append("\n");
          sb.Append("  YResolution: ").Append(this.YResolution).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
