using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples
{
    /// <summary>
    ///     Examples of operations with multi frame image.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class MultiframeImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MultiframeImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public MultiframeImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Multiframe image example:");
        }

        protected override string SampleImageFileName => "MultipageSampleImage.djvu";
        
        /// <summary>
        ///     Get separate frame from existing image.
        /// </summary>
        public void GetImageFrameFromStorage()
        {
            Console.WriteLine("Get separate frame from existing image in cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Index of the frame
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageFrameRequest = new GetImageFrameRequest(SampleImageFileName, frameId, folder:folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}");

            using (var imageFrame = ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                SaveUpdatedImageToOutput("SingleFrame.djvu", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Get separate frame from existing image, and upload the frame to Cloud Storage
        /// </summary>
        public void GetImageFrameAndUploadToStorage()
        {
            Console.WriteLine("Get separate frame from existing image and upload to cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Index of the frame
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageFrameRequest =
                new GetImageFrameRequest(SampleImageFileName, frameId, folder: folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: frame Id:{frameId}");

            using (var imageFrame = ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                UploadImageToCloudExample(imageFrame, "SingleFrame.djvu");
            }

            Console.WriteLine();
        }        
        
        /// <summary>
        ///     Get separate frame from existing image. Image data is passed in a request stream.
        /// </summary>
        public void CreateImageFrameFromRequestBody()
        {
            Console.WriteLine("Get separate frame from existing image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? frameId = 1;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                var createImageFrameRequest =
                    new CreateImageFrameRequest(inputImageStream, frameId, outPath: outPath, storage: storage);

                Console.WriteLine($"Call CreateImageFrame with params: frame Id:{frameId}");

                using (var imageFrame = ImagingApi.CreateImageFrame(createImageFrameRequest))
                {
                    SaveUpdatedImageToOutput("SingleFrameFromRequest.djvu", imageFrame);
                }
            }

            Console.WriteLine();
        }
        
        /// <summary>
        ///     Get frame range from existing image.
        /// </summary>
        public void GetImageFrameRangeFromStorage()
        {
            Console.WriteLine("Get frame range from existing image in cloud storage");

            UploadSampleImageToCloud();

            int? startFrameId = 1; // Index of the first frame in range
            int? endFrameId = 4; // Index of the last frame in range
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageFrameRangeRequest = new GetImageFrameRangeRequest(SampleImageFileName, startFrameId, endFrameId,
                folder: folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: start frame Id:{startFrameId}, end frame Id:{endFrameId}");

            using (var imageFrame = ImagingApi.GetImageFrameRange(getImageFrameRangeRequest))
            {
                SaveUpdatedImageToOutput("FrameRange.djvu", imageFrame);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Get frame range from existing image, and upload the frame to Cloud Storage
        /// </summary>
        public void GetImageFrameRangeAndUploadToStorage()
        {
            Console.WriteLine("Get frame range from existing image in cloud storage");

            UploadSampleImageToCloud();

            int? startFrameId = 1; // Index of the first frame in range
            int? endFrameId = 4; // Index of the last frame in range
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageFrameRangeRequest = new GetImageFrameRangeRequest(SampleImageFileName, startFrameId, endFrameId,
                folder: folder, storage: storage);

            Console.WriteLine($"Call GetImageFrame with params: start frame Id:{startFrameId}, end frame Id:{endFrameId}");

            using (var imageFrame = ImagingApi.GetImageFrameRange(getImageFrameRangeRequest))
            {
                UploadImageToCloudExample(imageFrame, "FrameRange.djvu");
            }

            Console.WriteLine();
        }        
        
        /// <summary>
        ///     Get frame range from existing image. Image data is passed in a request stream.
        /// </summary>
        public void CreateImageFrameRangeFromRequestBody()
        {
            Console.WriteLine("Get separate frame from existing image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? startFrameId = 1; // Index of the first frame in range
                int? endFrameId = 4; // Index of the last frame in range
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                var createImageFrameRangeRequest =
                    new CreateImageFrameRangeRequest(inputImageStream, startFrameId, endFrameId, outPath: outPath, storage: storage);

                Console.WriteLine($"Call CreateImageFrame with params: start frame Id:{startFrameId}, end frame Id:{endFrameId}");

                using (var imageFrame = ImagingApi.CreateImageFrameRange(createImageFrameRangeRequest))
                {
                    SaveUpdatedImageToOutput("FrameRangeFromRequest.djvu", imageFrame);
                }
            }

            Console.WriteLine();
        }
        
        /// <summary>
        ///     Get separate frame properties of a image.
        /// </summary>
        public void GetImageFramePropertiesFromStorage()
        {
            Console.WriteLine("Gets separate frame properties of existing image from cloud storage");

            UploadSampleImageToCloud();

            int? frameId = 1; // Number of a frame
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var imageFramePropertiesRequest =
                new GetImageFramePropertiesRequest(SampleImageFileName, frameId, folder, storage);

            Console.WriteLine($"Call GetImageFrameProperties with params: frame Id:{frameId}");

            var imagingResponse = ImagingApi.GetImageFrameProperties(imageFramePropertiesRequest);
            OutputPropertiesToFile("MultiframeImageProperties.txt", imagingResponse);

            Console.WriteLine();
        }

        /// <summary>
        ///     Get separate frame properties of a image.
        ///     Image data is passed in a request stream.
        /// </summary>
        public void ExtractImageFramePropertiesFromRequestBody()
        {
            Console.WriteLine("Get separate frame properties of existing image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? frameId = 1;

                var imageFramePropertiesRequest =
                    new ExtractImageFramePropertiesRequest(inputImageStream, frameId);

                Console.WriteLine($"Call ExtractImageFrameProperties with params: frame Id:{frameId}");

                var imagingResponse = ImagingApi.ExtractImageFrameProperties(imageFramePropertiesRequest);
                OutputPropertiesToFile("MuttiframeImagePropertiesFromRequest.txt", imagingResponse);
            }

            Console.WriteLine();
        }
    }
}