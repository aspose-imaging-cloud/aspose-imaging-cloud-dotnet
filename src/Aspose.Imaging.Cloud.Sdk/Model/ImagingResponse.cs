// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagingResponse.cs">
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
  public class ImagingResponse 
  {                       
        /// <summary>
        /// Gets or sets Height
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets BitsPerPixel
        /// </summary>  
        public int? BitsPerPixel { get; set; }

        /// <summary>
        /// Gets or sets BmpProperties
        /// </summary>  
        public BmpProperties BmpProperties { get; set; }

        /// <summary>
        /// Gets or sets GifProperties
        /// </summary>  
        public GifProperties GifProperties { get; set; }

        /// <summary>
        /// Gets or sets JpegProperties
        /// </summary>  
        public JpegProperties JpegProperties { get; set; }

        /// <summary>
        /// Gets or sets PngProperties
        /// </summary>  
        public PngProperties PngProperties { get; set; }

        /// <summary>
        /// Gets or sets TiffProperties
        /// </summary>  
        public TiffProperties TiffProperties { get; set; }

        /// <summary>
        /// Gets or sets PsdProperties
        /// </summary>  
        public PsdProperties PsdProperties { get; set; }

        /// <summary>
        /// Gets or sets DjvuProperties
        /// </summary>  
        public DjvuProperties DjvuProperties { get; set; }

        /// <summary>
        /// Gets or sets WebPProperties
        /// </summary>  
        public WebPProperties WebPProperties { get; set; }

        /// <summary>
        /// Gets or sets Jpeg2000Properties
        /// </summary>  
        public Jpeg2000Properties Jpeg2000Properties { get; set; }

        /// <summary>
        /// Gets or sets DicomProperties
        /// </summary>  
        public DicomProperties DicomProperties { get; set; }

        /// <summary>
        /// Gets or sets DngProperties
        /// </summary>  
        public DngProperties DngProperties { get; set; }

        /// <summary>
        /// Gets or sets OdgProperties
        /// </summary>  
        public OdgProperties OdgProperties { get; set; }

        /// <summary>
        /// Gets or sets SvgProperties
        /// </summary>  
        public SvgProperties SvgProperties { get; set; }

        /// <summary>
        /// Gets or sets EpsProperties
        /// </summary>  
        public EpsProperties EpsProperties { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution
        /// </summary>  
        public double? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution
        /// </summary>  
        public double? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets IsCached
        /// </summary>  
        public bool? IsCached { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImagingResponse {\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  BitsPerPixel: ").Append(this.BitsPerPixel).Append("\n");
          sb.Append("  BmpProperties: ").Append(this.BmpProperties).Append("\n");
          sb.Append("  GifProperties: ").Append(this.GifProperties).Append("\n");
          sb.Append("  JpegProperties: ").Append(this.JpegProperties).Append("\n");
          sb.Append("  PngProperties: ").Append(this.PngProperties).Append("\n");
          sb.Append("  TiffProperties: ").Append(this.TiffProperties).Append("\n");
          sb.Append("  PsdProperties: ").Append(this.PsdProperties).Append("\n");
          sb.Append("  DjvuProperties: ").Append(this.DjvuProperties).Append("\n");
          sb.Append("  WebPProperties: ").Append(this.WebPProperties).Append("\n");
          sb.Append("  Jpeg2000Properties: ").Append(this.Jpeg2000Properties).Append("\n");
          sb.Append("  DicomProperties: ").Append(this.DicomProperties).Append("\n");
          sb.Append("  DngProperties: ").Append(this.DngProperties).Append("\n");
          sb.Append("  OdgProperties: ").Append(this.OdgProperties).Append("\n");
          sb.Append("  SvgProperties: ").Append(this.SvgProperties).Append("\n");
          sb.Append("  EpsProperties: ").Append(this.EpsProperties).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  IsCached: ").Append(this.IsCached).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
