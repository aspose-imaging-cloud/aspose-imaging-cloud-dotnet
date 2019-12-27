// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FilterEffectApiTests.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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


using System.IO;

namespace Aspose.Imaging.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    ///  Class for testing FilterEffectApi
    /// </summary>
    [Category("v3.0")]
    [Category("FilterEffect")]
    [TestFixture]
    public class FilterEffectApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test FilterEffectImage
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".psd", null)]
#if EXTENDED_TEST        
        [TestCase(".dicom", null)]
        [TestCase(".djvu", null)]
        [TestCase(".gif", null)]
        [TestCase(".tiff", null)]
        [TestCase(".webp", null)]
#endif
        public void FilterEffectTest(string formatExtension, params string[] additionalExportFormats)
        {
            string name = null;
            string folder = TempFolder;
            string storage = this.TestStorage;
            
            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (var inputFile in InputTestFiles)
            {
                if (inputFile.Name.EndsWith(formatExtension))
                {
                    name = inputFile.Name;
                }
                else
                {
                    continue;
                }

                foreach (var filter in filters)
                {
                    foreach (var format in formatsToExport)
                    {
                        this.TestGetRequest(
                            "FilterEffectTest",
                            $"Input image: {name}; Output format: {format ?? "null"}; Filter type: {filter.FilterType}",
                            name,
                            delegate
                            {
                                var request = new FilterEffectImageRequest(name,  filter.FilterType,
                                    filter.FilterProperties, format, folder, storage);
                                return ImagingApi.FilterEffectImage(request);
                            },
                            delegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                            {
                                Assert.AreEqual(Image.GetFileFormat(resultStream),
                                    format == null ? formatExtension : format.Substring(1));
                            },
                            folder,
                            storage
                        );


                    }
                }
            }
        }
        
        /// <summary>
        /// Wrapper for filter type and filter properties
        /// </summary>
        private class Filter
        {
            /// <summary>
            /// Creates Filter instance
            /// </summary>
            /// <param name="filterType">The filter type.</param>
            /// <param name="filterProperties">The filter properties.</param>
            public Filter(string filterType, FilterPropertiesBase filterProperties)
            {
                FilterType = filterType;
                FilterProperties = filterProperties;
            }

            /// <summary>
            /// The filter type
            /// </summary>
            public string FilterType { get; }

            /// <summary>
            /// The filter properties
            /// </summary>
            public FilterPropertiesBase FilterProperties { get; }
        }

        /// <summary>
        /// Filters to test
        /// </summary>
        private readonly IEnumerable<Filter> filters = new[]
        {
            new Filter("BigRectangular", new BigRectangularFilterProperties()),
            new Filter("SmallRectangular", new SmallRectangularFilterProperties()),
            new Filter("Median", new MedianFilterProperties
            {
                Size = 3
            }),
            new Filter("GaussWiener", new GaussWienerFilterProperties
            {
                Radius = 2,
                Smooth = 2
            }),
            new Filter("MotionWiener", new MotionWienerFilterProperties
            {
                Angle = 12,
                Length = 2,
                Smooth = 2
            }),
            new Filter("GaussianBlur", new GaussianBlurFilterProperties
            {
                Radius = 2,
                Sigma = 2
            }),
            new Filter("Sharpen", new SharpenFilterProperties
            {
                Sigma = 2,
                Size = 2
            }),
            new Filter("BilateralSmoothing", new BilateralSmoothingFilterProperties
            {
                Size = 2,
                ColorFactor = 2,
                ColorPower = 2,
                SpatialFactor = 2,
                SpatialPower = 2
            })
        };
    }
}