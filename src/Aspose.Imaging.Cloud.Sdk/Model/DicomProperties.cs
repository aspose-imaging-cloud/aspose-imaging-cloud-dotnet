// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DicomProperties.cs">
//   Copyright (c) 2018 Aspose Pty Ltd.
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
  /// Represents information about image in dicom format.
  /// </summary>  
  public class DicomProperties 
  {                       
        /// <summary>
        /// Gets or sets the planar configuration.
        /// </summary>  
        public int? PlanarConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the array of red colors.
        /// </summary>  
        public byte[] Reds { get; set; }

        /// <summary>
        /// Gets or sets the array of green colors.
        /// </summary>  
        public byte[] Greens { get; set; }

        /// <summary>
        /// Gets or sets the array of blue colors.
        /// </summary>  
        public byte[] Blues { get; set; }

        /// <summary>
        /// Gets or sets the header information by bytes.
        /// </summary>  
        public byte[] DicomHeaderInfoByBytes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it's a signed image.
        /// </summary>  
        public bool? SignedImage { get; set; }

        /// <summary>
        /// Gets or sets the header information of the DICOM file.
        /// </summary>  
        public List<string> DicomInfo { get; set; }

        /// <summary>
        /// Gets or sets samples per pixel count.
        /// </summary>  
        public int? SamplesPerPixel { get; set; }

        /// <summary>
        /// Gets or sets allocated bits count.
        /// </summary>  
        public int? BitsAllocated { get; set; }

        /// <summary>
        /// Gets or sets the photo interpretation.
        /// </summary>  
        public string PhotoInterpretation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether width tag found.
        /// </summary>  
        public bool? WidthTagFound { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether height tag found.
        /// </summary>  
        public bool? HeightTagFound { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the window centre.
        /// </summary>  
        public double? WindowCentre { get; set; }

        /// <summary>
        /// Gets or sets the width of the window.
        /// </summary>  
        public double? WindowWidth { get; set; }

        /// <summary>
        /// Gets or sets data representation of the pixel samples.
        /// </summary>  
        public int? PixelRepresentation { get; set; }

        /// <summary>
        /// Gets or sets a value of the rescale intercept.
        /// </summary>  
        public double? RescaleIntercept { get; set; }

        /// <summary>
        /// Gets or sets a value of the rescale slope.
        /// </summary>  
        public double? RescaleSlope { get; set; }

        /// <summary>
        /// Gets or sets the number of frames.
        /// </summary>  
        public int? NumberOfFrames { get; set; }

        /// <summary>
        /// Gets or sets the length of element.
        /// </summary>  
        public int? LengthValue { get; set; }

        /// <summary>
        /// Indicates if DICOM image has little endian byte order.
        /// </summary>  
        public bool? IsLittleEndian { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>  
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether \"DICOM\" data is found.
        /// </summary>  
        public bool? DicomFound { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DicomProperties {\n");
          sb.Append("  PlanarConfiguration: ").Append(this.PlanarConfiguration).Append("\n");
          sb.Append("  Reds: ").Append(this.Reds).Append("\n");
          sb.Append("  Greens: ").Append(this.Greens).Append("\n");
          sb.Append("  Blues: ").Append(this.Blues).Append("\n");
          sb.Append("  DicomHeaderInfoByBytes: ").Append(this.DicomHeaderInfoByBytes).Append("\n");
          sb.Append("  SignedImage: ").Append(this.SignedImage).Append("\n");
          sb.Append("  DicomInfo: ").Append(this.DicomInfo).Append("\n");
          sb.Append("  SamplesPerPixel: ").Append(this.SamplesPerPixel).Append("\n");
          sb.Append("  BitsAllocated: ").Append(this.BitsAllocated).Append("\n");
          sb.Append("  PhotoInterpretation: ").Append(this.PhotoInterpretation).Append("\n");
          sb.Append("  WidthTagFound: ").Append(this.WidthTagFound).Append("\n");
          sb.Append("  HeightTagFound: ").Append(this.HeightTagFound).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  WindowCentre: ").Append(this.WindowCentre).Append("\n");
          sb.Append("  WindowWidth: ").Append(this.WindowWidth).Append("\n");
          sb.Append("  PixelRepresentation: ").Append(this.PixelRepresentation).Append("\n");
          sb.Append("  RescaleIntercept: ").Append(this.RescaleIntercept).Append("\n");
          sb.Append("  RescaleSlope: ").Append(this.RescaleSlope).Append("\n");
          sb.Append("  NumberOfFrames: ").Append(this.NumberOfFrames).Append("\n");
          sb.Append("  LengthValue: ").Append(this.LengthValue).Append("\n");
          sb.Append("  IsLittleEndian: ").Append(this.IsLittleEndian).Append("\n");
          sb.Append("  Offset: ").Append(this.Offset).Append("\n");
          sb.Append("  DicomFound: ").Append(this.DicomFound).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}