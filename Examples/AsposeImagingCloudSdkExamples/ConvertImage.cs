using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSdkExamples
{
    /// <summary>
    ///     Convert image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class ConvertImage : ImagingBase
    {

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExportImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public ConvertImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Convert image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        /// <remarks>
        ///     Input formats could be one of the following:
        ///     BMP, GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
        /// </remarks>
        protected override string SampleImageFileName => "ExportSampleImage.bmp";

        /// <summary>
        ///     Convert an image to another format. Image data is passed in a request stream.
        /// </summary>
        public void CreateConvertedImageFromReques()
        {
            Console.WriteLine("Convert an image to another format. Image data is passed in a request body");

            var imagePath = Path.Combine(ExampleImagesFolder, SampleImageFileName);

            // Please refer to https://docs.aspose.cloud/imaging/supported-file-formats/#convert 
            // for possible output formats
            var outFormat = "pdf";
            using (var updatedImage = ConvertImageFromRequestExample(imagePath, outFormat))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, true, outFormat);
            }

            Console.WriteLine();
        }    

        /// <summary>
        ///     Convert an image to another format.
        /// </summary>
        public void ConvertImageFromStorage()
        {
            Console.WriteLine("Convert an image to another format");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/imaging/supported-file-formats/#convert 
            // for possible output formats
            var outFormat = "pdf";
            using (var updatedImage = ConvertImageFromStorageExample(SampleImageFileName, CloudPath, "outFormat"))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false, outFormat);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Convert an image to another format.
        /// </summary>
        public void ConvertImageAndUploadToStorage()
        {
            Console.WriteLine("Convert an image to another format and upload to cloud storage");

            UploadSampleImageToCloud();
            // Please refer to https://docs.aspose.cloud/imaging/supported-file-formats/#convert 
            // for possible output formats
            var outFormat = "pdf";            
            using (var updatedImage = ConvertImageFromStorageExample(SampleImageFileName, CloudPath, outFormat))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName(false, outFormat));
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Convert image from request.
        /// </summary>
        /// <param name="imagePath">Image file path.</param>
        /// <param name="outFormat">Conversion format.</param>
        /// <returns>Converted image stream.</returns>
        private Stream ConvertImageFromRequestExample(string imagePath, string outFormat)
        {
            // Load image file            
            using (var inputImageStream = File.OpenRead(imagePath))
            {
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // Cloud Storage name

                // Create an instance of conversion request
                var request = new CreateConvertedImageRequest(inputImageStream, outFormat, outPath, storage);

                Console.WriteLine($"Call CreateConvertedImage with params: format:{outFormat}");

                // Convert an image
                var updatedImage = ImagingApi.CreateConvertedImage(request);

                return updatedImage;
            }
        }

        /// <summary>
        /// Convert image from storage.
        /// </summary>
        /// <param name="imageFileName">Image file name.</param>
        /// <param name="storageImageFolder">Image folder path in cloud storage.</param>
        /// <param name="outFormat">Conversion format.</param>
        /// <returns>Converted image stream.</returns>
        private Stream ConvertImageFromStorageExample(string imageFileName, string storageImageFolder, string outFormat)
        {
            // see UploadImageToCloudExample

            string storage = null; // Cloud Storage name, null - default storage

            // Create an instance of conversion request
            var request = new ConvertImageRequest(imageFileName, outFormat, storageImageFolder, storage);

            Console.WriteLine($"Call ConvertImage with params: format:{outFormat}");

            // Convert an image
            var updatedImage = ImagingApi.ConvertImage(request);
            return updatedImage;
        }
    }
}