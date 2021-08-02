﻿using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

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
            Console.WriteLine("Detect object on the image from cloud storage");

            UploadSampleImageToCloud();

            string method = "ssd";
            int threshold = 50;
            bool includeLabel = true;
            bool includeScore = true;
            string allowedLabels = "cat";
            string blockedLabels = "dog";
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new GetObjectBoundsRequest(SampleImageFileName, method, threshold, includeLabel, includeScore, allowedLabels, blockedLabels, folder, storage);

            Console.WriteLine($"Call ObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include label: {includeLabel}, includeScore: {includeScore}");

            DetectedObjectList detectedObjectList = this.ImagingApi.GetObjectBounds(request);

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
            bool includeLabel = true;
            bool includeScore = true;
            string allowedLabels = "cat";
            string blockedLabels = "dog";
            string color = "blue";
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new GetVisualObjectBoundsRequest(SampleImageFileName, method, threshold, includeLabel, includeScore, allowedLabels, blockedLabels, color, folder, storage);

            Console.WriteLine($"Call VisualObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include label: {includeLabel}, includeScore: {includeScore}, color: {color}");

            using (Stream updatedImage = this.ImagingApi.GetVisualObjectBounds(request))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName(false, SaveImageFormat));
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
                bool includeLabel = true;
                bool includeScore = true;
                string allowedLabels = "cat";
                string blockedLabels = "dog";
                string outPath = null;
                string storage = null; // We are using default Cloud Storage

                var request = new CreateObjectBoundsRequest(inputImageStream, method, threshold, includeLabel, includeScore, allowedLabels, blockedLabels, outPath, storage);

                Console.WriteLine($"Call CreateObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include label: {includeLabel}, includeScore: {includeScore}");

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
                bool includeLabel = true;
                bool includeScore = true;
                string allowedLabels = "cat";
                string blockedLabels = "dog";
                string color = null;
                string outPath = null;
                string storage = null; // We are using default Cloud Storage

                var request = new CreateVisualObjectBoundsRequest(inputImageStream, method, threshold, includeLabel, includeScore, allowedLabels, blockedLabels, color, outPath, storage);

                Console.WriteLine($"Call CreateVisualObjectBoundsRequest with params: method:{method}, threshold:{threshold}, include label: {includeLabel}, include score: {includeScore}");

                using (Stream updatedImage = this.ImagingApi.CreateVisualObjectBounds(request))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true, SaveImageFormat);
                }
            }

            Console.WriteLine();
        }
    }
}
