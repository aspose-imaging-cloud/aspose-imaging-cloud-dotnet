using Aspose.Imaging.Cloud.Sdk.Api;
using AsposeImagingCloudSDKExamples.ai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples
{
    class ImagingExamples
    {   
        static void Main(string[] args)
        {
            // Update parameters of existing BMP image
            UpdateBMPImage bmpImage = new UpdateBMPImage();
            bmpImage.updateParametersOfBMPImageInCloud();
            bmpImage.updateParametersOfBMPImageInRequestBody();

            // Crop an existing image
            CropImage cropImage = new CropImage();
            cropImage.cropImageInCloud();
            cropImage.cropImageInRequestBody();

            // Process existing EMF imaging using given parameters
            UpdateEMFImageProperties updateEMFImage = new UpdateEMFImageProperties();
            updateEMFImage.processEMFImage();
            updateEMFImage.processEMFImageWithoutStorage();

            // Export existing image to another format
            ExportImage exportImage = new ExportImage();
            exportImage.exportImageToAnotherFormat();
            exportImage.exportImageToAnotherFormatWithoutStorage();

            // Get properties of an image
            ImageProperties imageProperties = new ImageProperties();
            imageProperties.getPropertiesOfAnImageInCloud();
            imageProperties.getPropertiesOfAnImageInRequestBody();

            // Resize an existing image
            ResizeImage resizeImage = new ResizeImage();
            resizeImage.resizeAnImageInCloud();
            resizeImage.resizeAnImageInRequestBody();

            // Rotate and/or flip an existing image
            RotateFlipAnImage rotateFlipAnImage = new RotateFlipAnImage();
            rotateFlipAnImage.rotateFlipAnImageInCloud();
            rotateFlipAnImage.rotateFlipAnImageInRequestBody();

            // TIFF Frames
            TIFFFrames tiffFrames = new TIFFFrames();
            // Get a specified frame from existing TIFF image
            tiffFrames.getAFrameFromTIFFImageInCloud();
            // Get other frames from existing TIFF image
            tiffFrames.getOtherFramesFromTIFFImageInCloud();
            // Get separate frame from existing TIFF image.
            // Image data is passed as zero-indexed multipart/form-data content or as raw body stream
            tiffFrames.getAFrameFromTIFFImageInRequestBody();
            // Get separate frame properties of existing TIFF image
            tiffFrames.getFramePropertiesOfTIFFImageInCloud();
            // Get separate frame properties of existing TIFF image.
            // Image data is passed as zero-indexed multipart/form-data content or as raw body stream
            tiffFrames.getFramePropertiesOfTIFFImageInRequestBody();

            // Update parameters of existing TIFF image
            TIFFImage tiffImage = new TIFFImage();
            tiffImage.updateParametersOfTIFFImageInCloud();
            tiffImage.updateParametersOfTIFFImageInRequestBody();
            tiffImage.updateParametersOfTIFFImageAccordingToFaxParameters();
            tiffImage.mergeTIFFImages();

            // Update parameters of existing GIF image
            UpdateGIFImage updateGIFImage = new UpdateGIFImage();
            updateGIFImage.updateParametersOfGIFImageInCloud();
            updateGIFImage.updateParametersOfGIFImageInRequestBody();

            // Perform scaling, cropping and flipping of an existing image in a single request
            UpdateImage updateImage = new UpdateImage();
            updateImage.updateImageInCloud();
            updateImage.updateImageInRequestBody();

            // Update parameters of existing JPEG2000 image
            UpdateJPEG2000Image updateJPEG2000Image = new UpdateJPEG2000Image();
            updateJPEG2000Image.updateParametersOfJPEG2000ImageInCloud();
            updateJPEG2000Image.updateParametersOfJPEG2000ImageInRequestBody();

            // Update parameters of existing JPEG image
            UpdateJPEGImage updateJPEGImage = new UpdateJPEGImage();
            updateJPEGImage.updateParametersOfJPEGImageInCloud();
            updateJPEGImage.updateParametersOfJPEGImageInRequestBody();

            // Update parameters of existing PSD image
            UpdatePSDImage updatePSDImage = new UpdatePSDImage();
            updatePSDImage.updateParametersOfPSDImageInCloud();
            updatePSDImage.updateParametersOfPSDImageInRequestBody();

            // Update parameters of existing WEBP image
            WEBPImage webpImage = new WEBPImage();
            webpImage.updateParametersOfWEBPImageInCloud();
            webpImage.updateParametersOfWEBPImageInRequestBody();

            // Process existing WMF image using given parameters
            WMFImage wmfImage = new WMFImage();
            wmfImage.updateParametersOfWMFImageInCloud();
            wmfImage.updateParametersOfWMFImageInRequestBody();

            // AI APIs 
            // Compare two images
            CompareImages compareImages = new CompareImages();
            compareImages.CompareTwoImagesInSearchContext();
            compareImages.CompareLoadedImageToImageInSearchContext();

            // Find Duplicate Images
            FindDuplicateImages findDuplicateImages = new FindDuplicateImages();
            findDuplicateImages.FindDuplicates();

            // Find Similar Images
            FindImages findImages = new FindImages();
            findImages.FindSimilarImages();
            findImages.FindSimilarImagesByTag();
        }
    }
}
