using System.Collections.Generic;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Imaging.Cloud.Sdk.Test.Base
{
    public class CreateVisualObjectDetectionTestCommand : ITestCommand
    {
        private readonly CreateVisualObjectBoundsRequest request = null;
        private readonly ImagingApi imagingApi;
        private readonly bool saveResultToStorage;
        private readonly bool removeResult;
        private Stream response = null;
        private bool passed = false;

        public CreateVisualObjectDetectionTestCommand(
            CreateVisualObjectBoundsRequest request,
            ImagingApi imagingApi,
            bool saveResultToStorage,
            bool removeResult)
        {
            this.request = request;
            this.imagingApi = imagingApi;
            this.saveResultToStorage = saveResultToStorage;
            this.removeResult = removeResult;
        }

        public void InvokeRequest()
        {
            if (saveResultToStorage)
            {
                // remove output file from the storage (if exists)
                if (imagingApi.ObjectExists(new ObjectExistsRequest(request.outPath, request.storage)).Exists.Value)
                {
                    imagingApi.DeleteFile(new DeleteFileRequest(request.outPath, request.storage));
                }
            }

            response = imagingApi.CreateVisualObjectBounds(request);
        }

        public void AssertResponse()
        {
            Assert.NotNull(response);
            Assert.IsTrue(response.Length > 0);
            passed = true;
        }

        public void Dispose()
        {
            if (passed && saveResultToStorage && removeResult 
                && imagingApi.ObjectExists(new ObjectExistsRequest(request.outPath, request.storage)).Exists.Value)
            {
                imagingApi.DeleteFile(new DeleteFileRequest(request.outPath, request.storage));
            }
        }

        //вынести в бейс класс для imagestreamcommand
        /*
        using (Stream response = invokeRequestAction.Invoke())
                {
                    if (saveResultToStorage)
                    {
                        StorageFile resultInfo = this.GetStorageFileInfo(folder, resultFileName, storage);
                        if (resultInfo == null)
                        {
                            throw new ArgumentException(
                                $"Result file {resultFileName} doesn't exist in the specified storage folder: {folder}. " +
                                $"Result isn't present in the storage by an unknown reason.");
}

resultProperties =
                            this.ImagingApi.GetImageProperties(new GetImagePropertiesRequest(resultFileName, folder, storage));
                        Assert.NotNull(resultProperties);
                    }
                    else
                    {
                        resultProperties =
                            this.ImagingApi.ExtractImageProperties(new ExtractImagePropertiesRequest(response));
                        Assert.NotNull(resultProperties);
                    }

                    ImagingResponse originalProperties =
                        this.ImagingApi.GetImageProperties(new GetImagePropertiesRequest(inputFileName, folder, storage));
Assert.NotNull(originalProperties);

                    if (resultProperties != null)
                    {
                        propertiesTester?.Invoke(originalProperties, resultProperties, response);
                    }
                }
                */
    }
}
