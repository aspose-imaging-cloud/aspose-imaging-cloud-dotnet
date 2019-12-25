// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TIFFFrames.cs">
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

using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    /// <summary>
    /// TIFF frames example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingBase" />
    class TIFFFrames : ImagingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TIFFFrames"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public TIFFFrames(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("TIFF frames example:");
        }

        /// <summary>
        /// Gets the name of the example image file.
        /// </summary>
        /// <value>
        /// The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "TiffFrameSampleImage.tiff";

        /// <summary>
        /// Get separate frame from existing TIFF image.
        /// </summary>
        public void GetImageFrameFromStorage()
        {
            Console.WriteLine("Get separate frame from existing TIFF image in cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(
                SampleImageFileName, frameId, newWidth, newHeight,
                x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, folder, storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}, new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, save other frames:{saveOtherFrames}");

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                SaveUpdatedImageToOutput("SingleFrame.tiff", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Get separate frame from existing TIFF image, and upload the frame to Cloud Storage
        /// </summary>
        public void GetImageFrameAndUploadToStorage()
        {
            Console.WriteLine("Get separate frame from existing TIFF image and upload to cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(
                SampleImageFileName, frameId, newWidth, newHeight,
                x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, folder, storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}, new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, save other frames:{saveOtherFrames}");

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                UploadImageToCloud("SingleFrame.tiff", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Resize a TIFF frame.
        /// </summary>
        public void ResizeImageFrameFromStorage()
        {
            Console.WriteLine("Resize frame from existing TIFF image from cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 0; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 300;
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(SampleImageFileName, frameId, newWidth, newHeight,
                                saveOtherFrames: saveOtherFrames, folder: folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}, new width:{newWidth}, new height:{newHeight}, save other frames:{saveOtherFrames}");

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                SaveUpdatedImageToOutput("ResizeFrame.tiff", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Crop a TIFF frame.
        /// </summary>
        public void CropImageFrameFromStorage()
        {
            Console.WriteLine("Crop frame from existing TIFF image from cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 0; // Number of a frame
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(SampleImageFileName, frameId, x: x, y: y, 
                                                            rectWidth: rectWidth, rectHeight: rectHeight, saveOtherFrames: saveOtherFrames, folder: folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, save other frames:{saveOtherFrames}");

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                SaveUpdatedImageToOutput("CropFrame.tiff", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Rotate/Flip a TIFF frame.
        /// </summary>
        public void RotateFlipImageFrameFromStorage()
        {
            Console.WriteLine("Rotate/flip frame from existing TIFF image from cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 0; // Number of a frame
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(SampleImageFileName, frameId,
                                rotateFlipMethod: rotateFlipMethod, saveOtherFrames: saveOtherFrames, folder: folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}, rotate/flip method:{rotateFlipMethod}, save other frames:{saveOtherFrames}");

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                SaveUpdatedImageToOutput("RotateFlipFrame.tiff", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Gets all image frames from storage.
        /// </summary>
        public void GetAllImageFramesFromStorage()
        {
            Console.WriteLine("Gets all image frames from existing TIFF image from cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include all other frames
            bool? saveOtherFrames = true;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(
                SampleImageFileName, frameId, newWidth, newHeight,
                x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, folder, storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}, new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, save other frames:{saveOtherFrames}");

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                SaveUpdatedImageToOutput("OtherFrames.tiff", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Get separate frame from existing TIFF image. Image data is passed in a request stream.
        /// </summary>
        public void CreateImageFrameFromRequestBody()
        {
            Console.WriteLine("Get separate frame from existing TIFF image from request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? frameId = 1;
                int? newWidth = 300;
                int? newHeight = 450;
                int? x = 10;
                int? y = 10;
                int? rectWidth = 200;
                int? rectHeight = 300;
                string rotateFlipMethod = "Rotate90FlipX";
                bool? saveOtherFrames = false;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                CreateImageFrameRequest createImageFrameRequest = new CreateImageFrameRequest(inputImageStream, frameId, newWidth,
                            newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, outPath, storage);

                Console.WriteLine($"Call CreateImageFrame with params: frame Id:{frameId}, new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, save other frames:{saveOtherFrames}");

                using (Stream imageFrame = this.ImagingApi.CreateImageFrame(createImageFrameRequest))
                {
                    SaveUpdatedImageToOutput("SingleFrameFromRequest.tiff", imageFrame);
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Get separate frame properties of a TIFF image.
        /// </summary>
        public void GetImageFramePropertiesFromStorage()
        {
            Console.WriteLine("Gets separate frame properties of existing TIFF image from cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Number of a frame
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFramePropertiesRequest imageFramePropertiesRequest = 
                new GetImageFramePropertiesRequest(SampleImageFileName, frameId, folder, storage);

            Console.WriteLine($"Call GetImageFrameProperties with params: frame Id:{frameId}");

            ImagingResponse imagingResponse = this.ImagingApi.GetImageFrameProperties(imageFramePropertiesRequest);
            OutputPropertiesToFile("TiffFrameProperties.txt", imagingResponse);

            Console.WriteLine();
        }

        /// <summary>
        /// Get separate frame properties of a TIFF image. 
        /// Image data is passed in a request stream.
        /// </summary>
        public void ExtractImageFramePropertiesFromRequestBody()
        {
            Console.WriteLine("Get separate frame properties of existing TIFF image from request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? frameId = 1;

                ExtractImageFramePropertiesRequest imageFramePropertiesRequest = 
                    new ExtractImageFramePropertiesRequest(inputImageStream, frameId);

                Console.WriteLine($"Call ExtractImageFrameProperties with params: frame Id:{frameId}");

                ImagingResponse imagingResponse = this.ImagingApi.ExtractImageFrameProperties(imageFramePropertiesRequest);
                OutputPropertiesToFile("TiffFramePropertiesFromRequest.txt", imagingResponse);
            }

            Console.WriteLine();
        }
    }
}