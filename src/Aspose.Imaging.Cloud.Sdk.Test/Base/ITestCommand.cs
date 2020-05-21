using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Imaging.Cloud.Sdk.Test.Base
{
    public interface ITestCommand : IDisposable
    {
        void InvokeRequest();
        void AssertResponse();
    }
}
