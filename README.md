# Aspose.Imaging for Cloud .NET SDK
[Aspose.Imaging for Cloud](https://products.aspose.cloud/imaging/cloud) is a true REST API that enables you to perform a wide range of image processing operations including creation, manipulation and conversion in the cloud, with zero initial costs. Our Cloud SDKs are wrappers around REST API in various programming languages, allowing you to process images in language of your choice quickly and easily, gaining all benefits of strong types and IDE highlights. 

This repository contains Aspose.Imaging for Cloud .NET SDK source code. This SDK allows you to work with Aspose.Imaging for Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

To use this SDK, you will need App SID and App Key which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

The solution is updated using [code generator](https://github.com/aspose-imaging-cloud/aspose-imaging-cloud-codegen).

# Example
```csharp
// optional parameters are base URL, API version, authentication type and debug mode
// default base URL is https://api.aspose.cloud/
// default API version is v2
// default authentication type is OAuth2.0
// default debug mode is false
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");

// this GET request converts image files
// optional parameters are output file path, input file folder and Aspose storage name (if you have more than one storage and want to use non-default one) 
// if output file path is not set, resulting image is returned in a stream; otherwise, it's saved at the specified path in the storage and null is returned
var getSaveRequest = new GetImageSaveAsRequest("inputImage.jpg", "png", "ResultFolder/resultImage.png", "InputFolder");

// returns null, saves result to storage
imagingApi.GetImageSaveAs(getSaveRequest);

var getStreamRequest = new GetImageSaveAsRequest("inputImage.jpg", "png", null, "InputFolder");

// returns resulting stream
using (Stream resultGetImageStream = imagingApi.GetImageSaveAs(getStreamRequest))
{
	// process resulting stream
}

// another option is to use POST request and send image in a stream, if it's not present in your storage

using (FileStream inputImageStream = new FileStream(@"D:\test\localInputImage.jpg", FileMode.Open, FileAccess.Read))
{
	var postSaveRequest = new PostImageSaveAsRequest(inputImageStream, "png", "ResultFolder/resultImage.png");
	
	// returns null, saves result to storage
	imagingApi.PostImageSaveAs(postSaveRequest);
}

using (FileStream inputImageStream = new FileStream(@"D:\test\localInputImage.jpg", FileMode.Open, FileAccess.Read))
{
	var postStreamRequest = new PostImageSaveAsRequest(inputImageStream, "png");
	
	// returns resulting stream
	using (Stream resultPostImageStream = imagingApi.PostImageSaveAs(postStreamRequest))
	{
		// process resulting stream
	}
}

// another requests typically follow the same principles
```

# Tests
Tests are intended for internal usage only.

# Licensing
All Aspose.Imaging for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

# Contact Us
Your feedback is very important to us. Please feel free to contact via
+ [**Free Support Forum**](https://forum.aspose.cloud/c/imaging)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.imaging/)

# Resources
+ [**Web API reference**](https://apireference.aspose.cloud/imaging/)
+ [**Website**](https://www.aspose.cloud)
+ [**Product Home**](https://products.aspose.cloud/imaging/cloud)
+ [**Documentation**](https://docs.aspose.cloud/display/imagingcloud/Home)
+ [**Blog**](https://blog.aspose.cloud/category/aspose-products/aspose.imaging-cloud/)