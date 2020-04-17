// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffOptions.cs">
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
  /// Represents options for TIFF frame.
  /// </summary>  
  public class TiffOptions 
  {                       
        /// <summary>
        /// Gets or sets a value indicating whether TIFF image has valid data.
        /// </summary>  
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets or sets the artist.
        /// </summary>  
        public string Artist { get; set; }

        /// <summary>
        /// Gets or sets the byte order.
        /// </summary>  
        public string ByteOrder { get; set; }

        /// <summary>
        /// Gets or sets the bits per sample.
        /// </summary>  
        public List<int?> BitsPerSample { get; set; }

        /// <summary>
        /// Gets or sets the compression.
        /// </summary>  
        public string Compression { get; set; }

        /// <summary>
        /// Gets or sets the copyright info.
        /// </summary>  
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the color map.
        /// </summary>  
        public List<int?> ColorMap { get; set; }

        /// <summary>
        /// Gets or sets the date and time.
        /// </summary>  
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets the document name.
        /// </summary>  
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or sets the alpha storage.
        /// </summary>  
        public string AlphaStorage { get; set; }

        /// <summary>
        /// Gets or sets the fill order.
        /// </summary>  
        public string FillOrder { get; set; }

        /// <summary>
        /// Gets or sets the half-tone hints.
        /// </summary>  
        public List<int?> HalfToneHints { get; set; }

        /// <summary>
        /// Gets or sets the image description.
        /// </summary>  
        public string ImageDescription { get; set; }

        /// <summary>
        /// Gets or sets the ink names.
        /// </summary>  
        public string InkNames { get; set; }

        /// <summary>
        /// Gets or sets the scanner manufacturer.
        /// </summary>  
        public string ScannerManufacturer { get; set; }

        /// <summary>
        /// Gets or sets the max sample value.
        /// </summary>  
        public List<int?> MaxSampleValue { get; set; }

        /// <summary>
        /// Gets or sets the min sample value.
        /// </summary>  
        public List<int?> MinSampleValue { get; set; }

        /// <summary>
        /// Gets or sets the scanner model.
        /// </summary>  
        public string ScannerModel { get; set; }

        /// <summary>
        /// Gets or sets the page name.
        /// </summary>  
        public string PageName { get; set; }

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>  
        public string Orientation { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>  
        public List<int?> PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the photometric interpretation.
        /// </summary>  
        public string Photometric { get; set; }

        /// <summary>
        /// Gets or sets the planar configuration.
        /// </summary>  
        public string PlanarConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the resolution unit.
        /// </summary>  
        public string ResolutionUnit { get; set; }

        /// <summary>
        /// Gets or sets the rows per strip.
        /// </summary>  
        public long? RowsPerStrip { get; set; }

        /// <summary>
        /// Gets or sets the sample format.
        /// </summary>  
        public List<string> SampleFormat { get; set; }

        /// <summary>
        /// Gets or sets the samples per pixel.
        /// </summary>  
        public int? SamplesPerPixel { get; set; }

        /// <summary>
        /// Gets or sets the Smax sample value.
        /// </summary>  
        public List<long?> SmaxSampleValue { get; set; }

        /// <summary>
        /// Gets or sets the Smin sample value.
        /// </summary>  
        public List<long?> SminSampleValue { get; set; }

        /// <summary>
        /// Gets or sets the software type.
        /// </summary>  
        public string SoftwareType { get; set; }

        /// <summary>
        /// Gets or sets the strip byte counts.
        /// </summary>  
        public List<long?> StripByteCounts { get; set; }

        /// <summary>
        /// Gets or sets the strip offsets.
        /// </summary>  
        public List<long?> StripOffsets { get; set; }

        /// <summary>
        /// Gets or sets the subfile type.
        /// </summary>  
        public string SubFileType { get; set; }

        /// <summary>
        /// Gets or sets the target printer.
        /// </summary>  
        public string TargetPrinter { get; set; }

        /// <summary>
        /// Gets or sets the threshholding.
        /// </summary>  
        public string Threshholding { get; set; }

        /// <summary>
        /// Gets or sets the total pages count.
        /// </summary>  
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the X position.
        /// </summary>  
        public double? Xposition { get; set; }

        /// <summary>
        /// Gets or sets the X resolution.
        /// </summary>  
        public double? Xresolution { get; set; }

        /// <summary>
        /// Gets or sets the Y position.
        /// </summary>  
        public double? Yposition { get; set; }

        /// <summary>
        /// Gets or sets the Y resolution.
        /// </summary>  
        public double? Yresolution { get; set; }

        /// <summary>
        /// Gets or sets the FaxT4 Options.
        /// </summary>  
        public string FaxT4Options { get; set; }

        /// <summary>
        /// Gets or sets the predictor (a mathematical operator that is applied to the image data before an encoding scheme is applied).
        /// </summary>  
        public string Predictor { get; set; }

        /// <summary>
        /// Gets or sets the image length.
        /// </summary>  
        public long? ImageLength { get; set; }

        /// <summary>
        /// Gets or sets the image width.
        /// </summary>  
        public long? ImageWidth { get; set; }

        /// <summary>
        /// Gets or sets the valid tag count.
        /// </summary>  
        public int? ValidTagCount { get; set; }

        /// <summary>
        /// Gets or sets the bits per pixel.
        /// </summary>  
        public int? BitsPerPixel { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TiffOptions {\n");
          sb.Append("  IsValid: ").Append(this.IsValid).Append("\n");
          sb.Append("  Artist: ").Append(this.Artist).Append("\n");
          sb.Append("  ByteOrder: ").Append(this.ByteOrder).Append("\n");
          sb.Append("  BitsPerSample: ").Append(this.BitsPerSample).Append("\n");
          sb.Append("  Compression: ").Append(this.Compression).Append("\n");
          sb.Append("  Copyright: ").Append(this.Copyright).Append("\n");
          sb.Append("  ColorMap: ").Append(this.ColorMap).Append("\n");
          sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
          sb.Append("  DocumentName: ").Append(this.DocumentName).Append("\n");
          sb.Append("  AlphaStorage: ").Append(this.AlphaStorage).Append("\n");
          sb.Append("  FillOrder: ").Append(this.FillOrder).Append("\n");
          sb.Append("  HalfToneHints: ").Append(this.HalfToneHints).Append("\n");
          sb.Append("  ImageDescription: ").Append(this.ImageDescription).Append("\n");
          sb.Append("  InkNames: ").Append(this.InkNames).Append("\n");
          sb.Append("  ScannerManufacturer: ").Append(this.ScannerManufacturer).Append("\n");
          sb.Append("  MaxSampleValue: ").Append(this.MaxSampleValue).Append("\n");
          sb.Append("  MinSampleValue: ").Append(this.MinSampleValue).Append("\n");
          sb.Append("  ScannerModel: ").Append(this.ScannerModel).Append("\n");
          sb.Append("  PageName: ").Append(this.PageName).Append("\n");
          sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
          sb.Append("  PageNumber: ").Append(this.PageNumber).Append("\n");
          sb.Append("  Photometric: ").Append(this.Photometric).Append("\n");
          sb.Append("  PlanarConfiguration: ").Append(this.PlanarConfiguration).Append("\n");
          sb.Append("  ResolutionUnit: ").Append(this.ResolutionUnit).Append("\n");
          sb.Append("  RowsPerStrip: ").Append(this.RowsPerStrip).Append("\n");
          sb.Append("  SampleFormat: ").Append(this.SampleFormat).Append("\n");
          sb.Append("  SamplesPerPixel: ").Append(this.SamplesPerPixel).Append("\n");
          sb.Append("  SmaxSampleValue: ").Append(this.SmaxSampleValue).Append("\n");
          sb.Append("  SminSampleValue: ").Append(this.SminSampleValue).Append("\n");
          sb.Append("  SoftwareType: ").Append(this.SoftwareType).Append("\n");
          sb.Append("  StripByteCounts: ").Append(this.StripByteCounts).Append("\n");
          sb.Append("  StripOffsets: ").Append(this.StripOffsets).Append("\n");
          sb.Append("  SubFileType: ").Append(this.SubFileType).Append("\n");
          sb.Append("  TargetPrinter: ").Append(this.TargetPrinter).Append("\n");
          sb.Append("  Threshholding: ").Append(this.Threshholding).Append("\n");
          sb.Append("  TotalPages: ").Append(this.TotalPages).Append("\n");
          sb.Append("  Xposition: ").Append(this.Xposition).Append("\n");
          sb.Append("  Xresolution: ").Append(this.Xresolution).Append("\n");
          sb.Append("  Yposition: ").Append(this.Yposition).Append("\n");
          sb.Append("  Yresolution: ").Append(this.Yresolution).Append("\n");
          sb.Append("  FaxT4Options: ").Append(this.FaxT4Options).Append("\n");
          sb.Append("  Predictor: ").Append(this.Predictor).Append("\n");
          sb.Append("  ImageLength: ").Append(this.ImageLength).Append("\n");
          sb.Append("  ImageWidth: ").Append(this.ImageWidth).Append("\n");
          sb.Append("  ValidTagCount: ").Append(this.ValidTagCount).Append("\n");
          sb.Append("  BitsPerPixel: ").Append(this.BitsPerPixel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
