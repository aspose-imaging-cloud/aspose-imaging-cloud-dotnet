using System.Collections.Generic;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Imaging.Cloud.Sdk.Test.Base
{
    public class VisualObjectDetectionTestCommand : ITestCommand
    {
        private readonly VisualObjectBoundsRequest request = null;
        private readonly ImagingApi imagingApi;
        private readonly bool saveResultToStorage;
        private readonly bool removeResult;
        private readonly string storage;
        private Stream response = null;
        private string outPath;
        private bool passed = false;

        public VisualObjectDetectionTestCommand(
            VisualObjectBoundsRequest request,
            ImagingApi imagingApi,
            bool saveResultToStorage,
            bool removeResult,
            string folder,
            string storage,
            string resultFileName)
        {
            this.request = request;
            this.imagingApi = imagingApi;
            this.saveResultToStorage = saveResultToStorage;
            this.removeResult = removeResult;
            this.storage = storage;
            if(saveResultToStorage)
            {
                this.outPath = folder + "/" + resultFileName;
            }
        }

        public void InvokeRequest()
        {
            Prepare();
            response = imagingApi.VisualObjectBounds(request);
        }

        private void Prepare()
        {
            if (saveResultToStorage)
            {
                // remove output file from the storage (if exists)
                if (imagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
                {
                   imagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
                }
            }
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
                && imagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
            {
                imagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
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
