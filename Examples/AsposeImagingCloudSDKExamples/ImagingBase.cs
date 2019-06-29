using Aspose.Imaging.Cloud.Sdk.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples
{
    class ImagingBase
    {
        protected const string MyAppKey = ""; // Get AppKey and AppSID from https://dashboard.aspose.cloud/
        protected const string MyAppSid = ""; // Get AppKey and AppSID from https://dashboard.aspose.cloud/
        protected const string PathToDataFiles = @"..\..\..\..\..\TestData\";

        // Aspose.Imaging API
        protected ImagingApi ImagingApi;

        public ImagingBase()
        {
            this.ImagingApi = new ImagingApi(MyAppKey, MyAppSid);
        }
    }
}
