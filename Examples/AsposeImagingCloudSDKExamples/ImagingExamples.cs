// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagingExamples.cs">
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
using AsposeImagingCloudSDKExamples.AI;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    class ImagingExamples
    {
        static void Main(string[] args)
        {
            string myAppSid = ""; // Get AppSID from https://dashboard.aspose.cloud/
            string myAppKey = ""; // Get AppKey from https://dashboard.aspose.cloud/
          
            if (string.IsNullOrEmpty(myAppSid) || string.IsNullOrEmpty(myAppKey))
            {
                Console.WriteLine("Please, initialize AppSid, AppKey with your valid credentials from https://dashboard.aspose.cloud/");
                Console.WriteLine("If you haven't the credentials, please, Sign Up.");
                Console.WriteLine("Press any key ...");
                Console.ReadKey();
                return;
            }

            try
            {
                var api = new ImagingApi(appKey: myAppKey, appSid: myAppSid);

                PrepareOutput();

                Console.WriteLine("Runnig Imaging Cloud examples:");
                Console.WriteLine();

                // Update parameters of existing BMP image
                UpdateBMPImage bmpImage = new UpdateBMPImage(api);
                bmpImage.ModifyBmpFromStorage();
                bmpImage.ModifyBmpAndUploadToStorage();
                bmpImage.CreateModifiedBmpFromRequestBody();

                // Crop an existing image
                CropImage cropImage = new CropImage(api);
                cropImage.CropImageFromStorage();
                cropImage.CropImageAndUploadToStorage();
                cropImage.CreateCroppedImageFromRequestBody();

                // Process existing EMF imaging using given parameters
                UpdateEMFImage updateEMFImage = new UpdateEMFImage(api);
                updateEMFImage.ModifyEmfFromStorage();
                updateEMFImage.ModifyEmfAndUploadToStorage();
                updateEMFImage.CreateModifiedEmfFromRequestBody();

                // Export existing image to another format
                ExportImage exportImage = new ExportImage(api);
                exportImage.SaveImageAsFromStorage();
                exportImage.SaveImageAsAndUploadToStorage();
                exportImage.CreateSavedImageAsFromRequestBody();

                // Get properties of an image
                ImageProperties imageProperties = new ImageProperties(api);
                imageProperties.GetImagePropertiesFromStorage();
                imageProperties.ExtractImagePropertiesFromRequestBody();

                // Resize an existing image
                ResizeImage resizeImage = new ResizeImage(api);
                resizeImage.ResizeImageFromStorage();
                resizeImage.ResizeImageAndUploadToStorage();
                resizeImage.CreateResizedImageFromRequestBody();

                // Rotate and/or flip an existing image
                RotateFlipImage rotateFlipImage = new RotateFlipImage(api);
                rotateFlipImage.RotateFlipImageFromStorage();
                rotateFlipImage.RotateFlipImageAndUploadToStorage();
                rotateFlipImage.CreateRotateFlippedImageFromRequestBody();

                // TIFF Frames
                TIFFFrames tiffFrames = new TIFFFrames(api);
                // Get a specified frame from existing TIFF image
                tiffFrames.GetImageFrameFromStorage();
                // Get a specified frame from existing TIFF image, and upload the frame to Cloud Storage
                tiffFrames.GetImageFrameAndUploadToStorage();
                // Resize a TIFF frame
                tiffFrames.ResizeImageFrameFromStorage();
                // Crop a TIFF frame
                tiffFrames.CropImageFrameFromStorage();
                // RotateFlip a TIFF frame
                tiffFrames.RotateFlipImageFrameFromStorage();
                // Get other frames from existing TIFF image
                tiffFrames.GetAllImageFramesFromStorage();
                // Get separate frame from existing TIFF image.
                // Image data is passed as zero-indexed multipart/form-data content or as raw body stream
                tiffFrames.CreateImageFrameFromRequestBody();
                // Get separate frame properties of existing TIFF image
                tiffFrames.GetImageFramePropertiesFromStorage();
                // Get separate frame properties of existing TIFF image.
                // Image data is passed as zero-indexed multipart/form-data content or as raw body stream
                tiffFrames.ExtractImageFramePropertiesFromRequestBody();

                // Update parameters of existing TIFF image
                TIFFImage tiffImage = new TIFFImage(api);
                tiffImage.ModifyTiffFromStorage();
                tiffImage.ModifyTiffAndUploadToStorage();
                tiffImage.CreateModifiedTiffFromRequestBody();
                tiffImage.ConvertTiffToFaxFromStorage();
                tiffImage.AppendTiffFromStorage();

                // Update parameters of existing GIF image
                UpdateGIFImage updateGIFImage = new UpdateGIFImage(api);
                updateGIFImage.ModifyGifFromStorage();
                updateGIFImage.ModifyGifAndUploadToStorage();
                updateGIFImage.CreateModifiedGifFromRequestBody();

                // Perform scaling, cropping and flipping of an existing image in a single request
                UpdateImage updateImage = new UpdateImage(api);
                updateImage.UpdateImageFromStorage();
                updateImage.UpdateImageAndUploadToStorage();
                updateImage.CreateUpdatedImageFromRequestBody();

                // Update parameters of existing JPEG2000 image
                UpdateJPEG2000Image updateJPEG2000Image = new UpdateJPEG2000Image(api);
                updateJPEG2000Image.ModifyJpeg2000FromStorage();
                updateJPEG2000Image.ModifyJpeg2000AndUploadToStorage();
                updateJPEG2000Image.CreateModifiedJpeg2000FromRequestBody();

                // Update parameters of existing JPEG image
                UpdateJPEGImage updateJPEGImage = new UpdateJPEGImage(api);
                updateJPEGImage.ModifyJpegFromStorage();
                updateJPEGImage.ModifyJpegAndUploadToStorage();
                updateJPEGImage.CreateModifiedJpegFromRequestBody();

                // Update parameters of existing PSD image
                UpdatePSDImage updatePSDImage = new UpdatePSDImage(api);
                updatePSDImage.ModifyPsdFromStorage();
                updatePSDImage.ModifyPsdAndUploadToStorage();
                updatePSDImage.CreateModifiedPsdFromRequestBody();

                // Update parameters of existing WEBP image
                WEBPImage webpImage = new WEBPImage(api);
                webpImage.ModifyWebPFromStorage();
                webpImage.ModifyWebPAndUploadToStorage();
                webpImage.CreateModifiedWebPFromRequestBody();

                // Process existing WMF image using given parameters
                WMFImage wmfImage = new WMFImage(api);
                wmfImage.ModifyWmfFromStorage();
                wmfImage.ModifyWmfAndUploadToStorage();
                wmfImage.CreateModifiedWmfFromRequestBody();

                // AI APIs           

                Console.WriteLine("Runnig AI examples:");
                Console.WriteLine();

                // Compare two images
                CompareImages compareImages = new CompareImages(api);
                compareImages.PrepareSearchContext();
                compareImages.CompareTwoImagesInCloud();
                compareImages.CompareLoadedImageToImageInCloud();
                compareImages.DeleteSearchContext();

                // Find Duplicate Images
                FindDuplicateImages findDuplicateImages = new FindDuplicateImages(api);
                findDuplicateImages.PrepareSearchContext();
                findDuplicateImages.FindImageDuplicates();
                findDuplicateImages.DeleteSearchContext();

                // Find Similar Images
                FindImages findImages = new FindImages(api);
                findImages.PrepareSearchContext();
                findImages.FindSimilarImages();
                findImages.FindImagesByTag();
                findImages.DeleteSearchContext();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something goes wrong: {ex}");
            }

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prepare output folder.
        /// </summary>
        private static void PrepareOutput()
        {
            if (Directory.Exists(ImagingBase.OutputFolder))
            {
                Directory.Delete(ImagingBase.OutputFolder, true);
            }

            Directory.CreateDirectory(ImagingBase.OutputFolder);
        }
    }
}