// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeconvolutionFilterProperties.cs">
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
  /// Deconvolution Filter Options, abstract class
  /// </summary>  
  public class DeconvolutionFilterProperties : FilterPropertiesBase 
  {                       
        /// <summary>
        /// Gets or sets the SNR(signal-to-noise ratio) recommended range 0.002 - 0.009, default value = 0.007
        /// </summary>  
        public double? Snr { get; set; }

        /// <summary>
        /// Gets or sets the brightness. recommended range 1 - 1.5 default value = 1.15
        /// </summary>  
        public double? Brightness { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this DeconvolutionFilterProperties is grayscale. Return grayscale mode or RGB mode.
        /// </summary>  
        public bool? Grayscale { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is partial loaded.
        /// </summary>  
        public bool? IsPartialLoaded { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DeconvolutionFilterProperties {\n");
          sb.Append("  Snr: ").Append(this.Snr).Append("\n");
          sb.Append("  Brightness: ").Append(this.Brightness).Append("\n");
          sb.Append("  Grayscale: ").Append(this.Grayscale).Append("\n");
          sb.Append("  IsPartialLoaded: ").Append(this.IsPartialLoaded).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
