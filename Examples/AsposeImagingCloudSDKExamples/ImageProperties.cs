// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageProperties.cs">
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

using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    class ImageProperties : ImagingBase
    {

        // Get properties of an image, which is store in the cloud.
        public void GetImagePropertiesFromStorage()
        {
            string fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Get properties of an image
            // Folder with image to process. The value is null because the file is saved at the root of the storage
            string folder = null;
            string storage = null; // We are using default Cloud Storage

            GetImagePropertiesRequest getImagePropertiesRequest = new GetImagePropertiesRequest(fileName, folder,
                                                                                                            storage);

            ImagingResponse imagingResponse = this.ImagingApi.GetImageProperties(getImagePropertiesRequest);
            
        }

        // Get properties of an image. Image data is passed in a request stream.
        public void ExtractImagePropertiesFromRequestBody()
        {
            string fileName = "Sample.tiff";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                ExtractImagePropertiesRequest imagePropertiesRequest = new ExtractImagePropertiesRequest(inputImageStream);
                ImagingResponse imagingResponse = this.ImagingApi.ExtractImageProperties(imagePropertiesRequest);
            }
        }
    }
}
