using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSdkExamples.AI
{
    class ObjectDetection : ImagingBase
    {
        public ObjectDetection(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Object detection example:");
        }

        protected override string SampleImageFileName => "object_detection_example.jpg";

        private const string SaveImageFormat = "jpg";

        /// <summary>
        /// Detect objects on an image from a cloud storage.
        /// </summary>
        public void DetectObjectsImageFromStorage()
        {
            Console.WriteLine("Detect object on th image from cloud storage");

            UploadSampleImageToCloud();

            string method = "ssd";
            int threshold = 50;
            bool includeClass = true;
            bool includeScore = true;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new ObjectBoundsRequest(SampleImageFileName, method, threshold, includeClass, includeScore, folder, storage);

            Console.WriteLine($"Call ObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include class: {includeClass}, includeScore: {includeScore}");

            DetectedObjectList detectedObjectList = this.ImagingApi.ObjectBounds(request);

            Console.WriteLine("Objects detected: " + detectedObjectList.DetectedObjects.Count);

            Console.WriteLine();
        }

        /// <summary>
        /// Get visualized detected objects and upload it to the cloud storage
        /// </summary>
        public void VisualiizeDetectObjectsAndUploadToStorage()
        {
            Console.WriteLine("Get the original image with visualized detected objects and upload it to the cloud storage");

            UploadSampleImageToCloud();

            string method = "ssd";
            int threshold = 50;
            bool includeClass = true;
            bool includeScore = true;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new VisualObjectBoundsRequest(SampleImageFileName, method, threshold, includeClass, includeScore, folder, storage);

            Console.WriteLine($"Call VisualObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include class: {includeClass}, includeScore: {includeScore}");

            using (Stream updatedImage = this.ImagingApi.VisualObjectBounds(request))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(false, SaveImageFormat), updatedImage);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// detected object on an image that is passed in a request stream.
        /// </summary>
        public void DetectedObjectsImageFromRequestBody()
        {
            Console.WriteLine("Detect objects on an image. Image data is passed in a request stream");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                string method = "ssd";
                int threshold = 50;
                bool includeClass = true;
                bool includeScore = true;
                string outPath = null;
                string storage = null; // We are using default Cloud Storage

                var request = new CreateObjectBoundsRequest(inputImageStream, method, threshold, includeClass, includeScore, outPath, storage);

                Console.WriteLine($"Call CreateObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include class: {includeClass}, includeScore: {includeScore}");

                DetectedObjectList detectedObjectList = this.ImagingApi.CreateObjectBounds(request);
                Console.WriteLine("Objects detected: " + detectedObjectList.DetectedObjects.Count);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Visualize detected object on an image that is passed in a request stream.
        /// </summary>
        public void VisualizeDetectedObjectsImageFromRequestBody()
        {
            Console.WriteLine("Detect objects on an image. Image data is passed in a request stream");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                string method = "ssd";
                int threshold = 50;
                bool includeClass = true;
                bool includeScore = true;
                string outPath = null;
                string storage = null; // We are using default Cloud Storage

                var request = new CreateVisualObjectBoundsRequest(inputImageStream, method, threshold, includeClass, includeScore, outPath, storage);

                Console.WriteLine($"Call CreateVisualObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include class: {includeClass}, includeScore: {includeScore}");

                using (Stream updatedImage = this.ImagingApi.CreateVisualObjectBounds(request))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true, SaveImageFormat);
                }
            }

            Console.WriteLine();
        }
    }
}
