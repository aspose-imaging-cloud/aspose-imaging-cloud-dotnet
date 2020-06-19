using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk.Test.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Imaging.Cloud.Sdk.Test.Api.AI.ObjectDetection
{
    public class AvailableLabelsTestCommand : ITestCommand
    {
        private readonly GetAvailableLabelsRequest _request;
        private readonly ImagingApi _imagingApi;
        private AvailableLabelsList response;

        public AvailableLabelsTestCommand(
            GetAvailableLabelsRequest request,
            ImagingApi imagingApi)
        {
            _request = request;
            _imagingApi = imagingApi;
        }

        public void AssertResponse()
        {
            Assert.NotNull(response);
            Assert.NotNull(response.AvailableLabels);
            Assert.IsTrue(response.AvailableLabels.Count > 0);
        }

        public void Dispose()
        {
            
        }

        public void InvokeRequest()
        {
            response = _imagingApi.GetAvailableLabels(_request);
        }
    }
}
