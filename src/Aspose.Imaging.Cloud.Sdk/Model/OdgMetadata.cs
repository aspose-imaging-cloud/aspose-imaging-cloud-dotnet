// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OdgMetadata.cs">
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
  public class OdgMetadata 
  {                       
        /// <summary>
        /// Gets or sets Generator
        /// </summary>  
        public string Generator { get; set; }

        /// <summary>
        /// Gets or sets Title
        /// </summary>  
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Subject
        /// </summary>  
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets Keywords
        /// </summary>  
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets InitialCreator
        /// </summary>  
        public string InitialCreator { get; set; }

        /// <summary>
        /// Gets or sets Creator
        /// </summary>  
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets PrintedBy
        /// </summary>  
        public string PrintedBy { get; set; }

        /// <summary>
        /// Gets or sets CreationDateTime
        /// </summary>  
        public string CreationDateTime { get; set; }

        /// <summary>
        /// Gets or sets ModificationDateTime
        /// </summary>  
        public string ModificationDateTime { get; set; }

        /// <summary>
        /// Gets or sets PrintDateTime
        /// </summary>  
        public string PrintDateTime { get; set; }

        /// <summary>
        /// Gets or sets DocumentTemplate
        /// </summary>  
        public string DocumentTemplate { get; set; }

        /// <summary>
        /// Gets or sets AutomaticReload
        /// </summary>  
        public string AutomaticReload { get; set; }

        /// <summary>
        /// Gets or sets HyperlinkBehavior
        /// </summary>  
        public string HyperlinkBehavior { get; set; }

        /// <summary>
        /// Gets or sets Language
        /// </summary>  
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets EditingCycles
        /// </summary>  
        public string EditingCycles { get; set; }

        /// <summary>
        /// Gets or sets EditingDuration
        /// </summary>  
        public string EditingDuration { get; set; }

        /// <summary>
        /// Gets or sets DocumentStatistics
        /// </summary>  
        public string DocumentStatistics { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OdgMetadata {\n");
          sb.Append("  Generator: ").Append(this.Generator).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  Keywords: ").Append(this.Keywords).Append("\n");
          sb.Append("  InitialCreator: ").Append(this.InitialCreator).Append("\n");
          sb.Append("  Creator: ").Append(this.Creator).Append("\n");
          sb.Append("  PrintedBy: ").Append(this.PrintedBy).Append("\n");
          sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append("\n");
          sb.Append("  ModificationDateTime: ").Append(this.ModificationDateTime).Append("\n");
          sb.Append("  PrintDateTime: ").Append(this.PrintDateTime).Append("\n");
          sb.Append("  DocumentTemplate: ").Append(this.DocumentTemplate).Append("\n");
          sb.Append("  AutomaticReload: ").Append(this.AutomaticReload).Append("\n");
          sb.Append("  HyperlinkBehavior: ").Append(this.HyperlinkBehavior).Append("\n");
          sb.Append("  Language: ").Append(this.Language).Append("\n");
          sb.Append("  EditingCycles: ").Append(this.EditingCycles).Append("\n");
          sb.Append("  EditingDuration: ").Append(this.EditingDuration).Append("\n");
          sb.Append("  DocumentStatistics: ").Append(this.DocumentStatistics).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
