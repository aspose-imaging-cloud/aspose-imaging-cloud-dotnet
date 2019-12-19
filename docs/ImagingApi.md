# Aspose.Imaging.Cloud.Sdk.Api.ImagingApi

<a name="addsearchimage"></a>
## **AddSearchImage**
> void AddSearchImage(AddSearchImageRequest request)

Add image and images features to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **AddSearchImageRequest** Parameters
```csharp
AddSearchImageRequest(
    string searchContextId, 
    string imageId, 
    System.IO.Stream imageData = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| Search context identifier. | 
 **imageId** | **string**| Image identifier. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**| Folder. | [optional] 
 **storage** | **string**| Storage | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="appendtiff"></a>
## **AppendTiff**
> void AppendTiff(AppendTiffRequest request)

Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images).

### **AppendTiffRequest** Parameters
```csharp
AppendTiffRequest(
    string name, 
    string appendFile, 
    string storage = null, 
    string folder = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Original image file name. | 
 **appendFile** | **string**| Image file name to be appended to original one. | 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **folder** | **string**| Folder with images to process. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="compareimages"></a>
## **CompareImages**
> [SearchResultsSet](SearchResultsSet.md) CompareImages(CompareImagesRequest request)

Compare two images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **CompareImagesRequest** Parameters
```csharp
CompareImagesRequest(
    string searchContextId, 
    string imageId1, 
    System.IO.Stream imageData = null, 
    string imageId2 = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imageId1** | **string**| The first image Id in storage. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **imageId2** | **string**| The second image Id in storage or null (if image loading in request). | [optional] 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**SearchResultsSet**](SearchResultsSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="converttifftofax"></a>
## **ConvertTiffToFax**
> System.IO.Stream ConvertTiffToFax(ConvertTiffToFaxRequest request)

Update parameters of existing TIFF image accordingly to fax parameters.

### **ConvertTiffToFaxRequest** Parameters
```csharp
ConvertTiffToFaxRequest(
    string name, 
    string storage = null, 
    string folder = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **folder** | **string**| Folder with image to process. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="copyfile"></a>
## **CopyFile**
> void CopyFile(CopyFileRequest request)

Copy file

### **CopyFileRequest** Parameters
```csharp
CopyFileRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="copyfolder"></a>
## **CopyFolder**
> void CopyFolder(CopyFolderRequest request)

Copy folder

### **CopyFolderRequest** Parameters
```csharp
CopyFolderRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createcroppedimage"></a>
## **CreateCroppedImage**
> System.IO.Stream CreateCroppedImage(CreateCroppedImageRequest request)

Crop an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateCroppedImageRequest** Parameters
```csharp
CreateCroppedImageRequest(
    System.IO.Stream imageData, 
    string format, 
    int? x, 
    int? y, 
    int? width, 
    int? height, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **x** | **int?**| X position of start point for cropping rectangle. | 
 **y** | **int?**| Y position of start point for cropping rectangle. | 
 **width** | **int?**| Width of cropping rectangle. | 
 **height** | **int?**| Height of cropping rectangle. | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createdeskewedimage"></a>
## **CreateDeskewedImage**
> System.IO.Stream CreateDeskewedImage(CreateDeskewedImageRequest request)

Crop an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateDeskewedImageRequest** Parameters
```csharp
CreateDeskewedImageRequest(
    System.IO.Stream imageData, 
    bool? resizeProportionally, 
    string bkColor = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **resizeProportionally** | **bool?**| Resize proportionally | 
 **bkColor** | **string**| background color | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image) | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createfolder"></a>
## **CreateFolder**
> void CreateFolder(CreateFolderRequest request)

Create the folder

### **CreateFolderRequest** Parameters
```csharp
CreateFolderRequest(
    string path, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimagefeatures"></a>
## **CreateImageFeatures**
> void CreateImageFeatures(CreateImageFeaturesRequest request)

Extract images features and add them to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateImageFeaturesRequest** Parameters
```csharp
CreateImageFeaturesRequest(
    string searchContextId, 
    System.IO.Stream imageData = null, 
    string imageId = null, 
    string imagesFolder = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **imageId** | **string**| The image identifier. | [optional] 
 **imagesFolder** | **string**| Images source - a folder | [optional] 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimageframe"></a>
## **CreateImageFrame**
> System.IO.Stream CreateImageFrame(CreateImageFrameRequest request)

Get separate frame from existing TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateImageFrameRequest** Parameters
```csharp
CreateImageFrameRequest(
    System.IO.Stream imageData, 
    int? frameId, 
    int? newWidth = null, 
    int? newHeight = null, 
    int? x = null, 
    int? y = null, 
    int? rectWidth = null, 
    int? rectHeight = null, 
    string rotateFlipMethod = null, 
    bool? saveOtherFrames = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **frameId** | **int?**| Number of a frame. | 
 **newWidth** | **int?**| New width. | [optional] 
 **newHeight** | **int?**| New height. | [optional] 
 **x** | **int?**| X position of start point for cropping rectangle. | [optional] 
 **y** | **int?**| Y position of start point for cropping rectangle. | [optional] 
 **rectWidth** | **int?**| Width of cropping rectangle. | [optional] 
 **rectHeight** | **int?**| Height of cropping rectangle. | [optional] 
 **rotateFlipMethod** | **string**| RotateFlip method (Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY). Default is RotateNoneFlipNone. | [optional] 
 **saveOtherFrames** | **bool?**| If result will include all other frames or just a specified frame. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimagesearch"></a>
## **CreateImageSearch**
> [SearchContextStatus](SearchContextStatus.md) CreateImageSearch(CreateImageSearchRequest request)

Create new search context.

### **CreateImageSearchRequest** Parameters
```csharp
CreateImageSearchRequest(
    string detector = null, 
    string matchingAlgorithm = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **detector** | **string**| The image features detector. | [optional] [default to akaze]
 **matchingAlgorithm** | **string**| The matching algorithm. | [optional] [default to randomBinaryTree]
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**SearchContextStatus**](SearchContextStatus.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimagetag"></a>
## **CreateImageTag**
> void CreateImageTag(CreateImageTagRequest request)

Add tag and reference image to search context. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateImageTagRequest** Parameters
```csharp
CreateImageTagRequest(
    System.IO.Stream imageData, 
    string searchContextId, 
    string tagName, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **searchContextId** | **string**| The search context identifier. | 
 **tagName** | **string**| The tag. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedbmp"></a>
## **CreateModifiedBmp**
> System.IO.Stream CreateModifiedBmp(CreateModifiedBmpRequest request)

Update parameters of BMP image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedBmpRequest** Parameters
```csharp
CreateModifiedBmpRequest(
    System.IO.Stream imageData, 
    int? bitsPerPixel, 
    int? horizontalResolution, 
    int? verticalResolution, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **bitsPerPixel** | **int?**| Color depth. | 
 **horizontalResolution** | **int?**| New horizontal resolution. | 
 **verticalResolution** | **int?**| New vertical resolution. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedemf"></a>
## **CreateModifiedEmf**
> System.IO.Stream CreateModifiedEmf(CreateModifiedEmfRequest request)

Process existing EMF imaging using given parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedEmfRequest** Parameters
```csharp
CreateModifiedEmfRequest(
    System.IO.Stream imageData, 
    string bkColor, 
    int? pageWidth, 
    int? pageHeight, 
    int? borderX, 
    int? borderY, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null, 
    string format = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **bkColor** | **string**| Color of the background. | 
 **pageWidth** | **int?**| Width of the page. | 
 **pageHeight** | **int?**| Height of the page. | 
 **borderX** | **int?**| Border width. | 
 **borderY** | **int?**| Border height. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **format** | **string**| Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedgif"></a>
## **CreateModifiedGif**
> System.IO.Stream CreateModifiedGif(CreateModifiedGifRequest request)

Update parameters of GIF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedGifRequest** Parameters
```csharp
CreateModifiedGifRequest(
    System.IO.Stream imageData, 
    int? backgroundColorIndex = null, 
    int? colorResolution = null, 
    bool? hasTrailer = null, 
    bool? interlaced = null, 
    bool? isPaletteSorted = null, 
    int? pixelAspectRatio = null, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **backgroundColorIndex** | **int?**| Index of the background color. | [optional] [default to 32]
 **colorResolution** | **int?**| Color resolution. | [optional] [default to 3]
 **hasTrailer** | **bool?**| Specifies if image has trailer. | [optional] [default to true]
 **interlaced** | **bool?**| Specifies if image is interlaced. | [optional] [default to true]
 **isPaletteSorted** | **bool?**| Specifies if palette is sorted. | [optional] [default to false]
 **pixelAspectRatio** | **int?**| Pixel aspect ratio. | [optional] [default to 3]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to true]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedjpeg"></a>
## **CreateModifiedJpeg**
> System.IO.Stream CreateModifiedJpeg(CreateModifiedJpegRequest request)

Update parameters of JPEG image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedJpegRequest** Parameters
```csharp
CreateModifiedJpegRequest(
    System.IO.Stream imageData, 
    int? quality = null, 
    string compressionType = null, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **quality** | **int?**| Quality of an image from 0 to 100. Default is 75. | [optional] [default to 75]
 **compressionType** | **string**| Compression type: baseline (default), progressive, lossless or jpegls. | [optional] [default to baseline]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedjpeg2000"></a>
## **CreateModifiedJpeg2000**
> System.IO.Stream CreateModifiedJpeg2000(CreateModifiedJpeg2000Request request)

Update parameters of JPEG2000 image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedJpeg2000Request** Parameters
```csharp
CreateModifiedJpeg2000Request(
    System.IO.Stream imageData, 
    string comment, 
    string codec = null, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **comment** | **string**| The comment (can be either single or comma-separated). | 
 **codec** | **string**| The codec (j2k or jp2). | [optional] [default to j2k]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedpsd"></a>
## **CreateModifiedPsd**
> System.IO.Stream CreateModifiedPsd(CreateModifiedPsdRequest request)

Update parameters of PSD image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedPsdRequest** Parameters
```csharp
CreateModifiedPsdRequest(
    System.IO.Stream imageData, 
    int? channelsCount = null, 
    string compressionMethod = null, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **channelsCount** | **int?**| Count of color channels. | [optional] [default to 4]
 **compressionMethod** | **string**| Compression method (for now, raw and RLE are supported). | [optional] [default to rle]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedsvg"></a>
## **CreateModifiedSvg**
> System.IO.Stream CreateModifiedSvg(CreateModifiedSvgRequest request)

Update parameters of SVG image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedSvgRequest** Parameters
```csharp
CreateModifiedSvgRequest(
    System.IO.Stream imageData, 
    string colorType = null, 
    bool? textAsShapes = null, 
    double? scaleX = null, 
    double? scaleY = null, 
    int? pageWidth = null, 
    int? pageHeight = null, 
    int? borderX = null, 
    int? borderY = null, 
    string bkColor = null, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null, 
    string format = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **colorType** | **string**| Color type for SVG image. Only RGB is supported for now. | [optional] [default to Rgb]
 **textAsShapes** | **bool?**| Whether text must be converted as shapes. true if all text is turned into SVG shapes in the convertion; otherwise, false | [optional] [default to false]
 **scaleX** | **double?**| Scale X. | [optional] [default to 0.0]
 **scaleY** | **double?**| Scale Y. | [optional] [default to 0.0]
 **pageWidth** | **int?**| Width of the page. | [optional] 
 **pageHeight** | **int?**| Height of the page. | [optional] 
 **borderX** | **int?**| Border width. Only 0 is supported for now. | [optional] 
 **borderY** | **int?**| Border height. Only 0 is supported for now. | [optional] 
 **bkColor** | **string**| Background color (Default is white). | [optional] [default to white]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **format** | **string**| Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedtiff"></a>
## **CreateModifiedTiff**
> System.IO.Stream CreateModifiedTiff(CreateModifiedTiffRequest request)

Update parameters of TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedTiffRequest** Parameters
```csharp
CreateModifiedTiffRequest(
    System.IO.Stream imageData, 
    int? bitDepth, 
    string compression = null, 
    string resolutionUnit = null, 
    double? horizontalResolution = null, 
    double? verticalResolution = null, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **bitDepth** | **int?**| Bit depth. | 
 **compression** | **string**| Compression (none is default). Please, refer to https://apireference.aspose.com/net/imaging/aspose.imaging.fileformats.tiff.enums/tiffcompressions for all possible values. | [optional] 
 **resolutionUnit** | **string**| New resolution unit (none - the default one, inch or centimeter). | [optional] 
 **horizontalResolution** | **double?**| New horizontal resolution. | [optional] [default to 0.0]
 **verticalResolution** | **double?**| New vertical resolution. | [optional] [default to 0.0]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedwebp"></a>
## **CreateModifiedWebP**
> System.IO.Stream CreateModifiedWebP(CreateModifiedWebPRequest request)

Update parameters of WEBP image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedWebPRequest** Parameters
```csharp
CreateModifiedWebPRequest(
    System.IO.Stream imageData, 
    bool? lossLess, 
    int? quality, 
    int? animLoopCount, 
    string animBackgroundColor, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **lossLess** | **bool?**| If WEBP should be in lossless format. | 
 **quality** | **int?**| Quality (0-100). | 
 **animLoopCount** | **int?**| The animation loop count. | 
 **animBackgroundColor** | **string**| Color of the animation background. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedwmf"></a>
## **CreateModifiedWmf**
> System.IO.Stream CreateModifiedWmf(CreateModifiedWmfRequest request)

Process existing WMF image using given parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateModifiedWmfRequest** Parameters
```csharp
CreateModifiedWmfRequest(
    System.IO.Stream imageData, 
    string bkColor, 
    int? pageWidth, 
    int? pageHeight, 
    int? borderX, 
    int? borderY, 
    bool? fromScratch = null, 
    string outPath = null, 
    string storage = null, 
    string format = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **bkColor** | **string**| Color of the background. | 
 **pageWidth** | **int?**| Width of the page. | 
 **pageHeight** | **int?**| Height of the page. | 
 **borderX** | **int?**| Border width. | 
 **borderY** | **int?**| Border height. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **format** | **string**| Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createresizedimage"></a>
## **CreateResizedImage**
> System.IO.Stream CreateResizedImage(CreateResizedImageRequest request)

Resize an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateResizedImageRequest** Parameters
```csharp
CreateResizedImageRequest(
    System.IO.Stream imageData, 
    string format, 
    int? newWidth, 
    int? newHeight, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **newWidth** | **int?**| New width. | 
 **newHeight** | **int?**| New height. | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createrotateflippedimage"></a>
## **CreateRotateFlippedImage**
> System.IO.Stream CreateRotateFlippedImage(CreateRotateFlippedImageRequest request)

Rotate and/or flip an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateRotateFlippedImageRequest** Parameters
```csharp
CreateRotateFlippedImageRequest(
    System.IO.Stream imageData, 
    string format, 
    string method, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **method** | **string**| RotateFlip method (Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY). | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createsavedimageas"></a>
## **CreateSavedImageAs**
> System.IO.Stream CreateSavedImageAs(CreateSavedImageAsRequest request)

Export existing image to another format. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.             

### **CreateSavedImageAsRequest** Parameters
```csharp
CreateSavedImageAsRequest(
    System.IO.Stream imageData, 
    string format, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createupdatedimage"></a>
## **CreateUpdatedImage**
> System.IO.Stream CreateUpdatedImage(CreateUpdatedImageRequest request)

Perform scaling, cropping and flipping of an image in a single request. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **CreateUpdatedImageRequest** Parameters
```csharp
CreateUpdatedImageRequest(
    System.IO.Stream imageData, 
    string format, 
    int? newWidth, 
    int? newHeight, 
    int? x, 
    int? y, 
    int? rectWidth, 
    int? rectHeight, 
    string rotateFlipMethod, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **newWidth** | **int?**| New width of the scaled image. | 
 **newHeight** | **int?**| New height of the scaled image. | 
 **x** | **int?**| X position of start point for cropping rectangle. | 
 **y** | **int?**| Y position of start point for cropping rectangle. | 
 **rectWidth** | **int?**| Width of cropping rectangle. | 
 **rectHeight** | **int?**| Height of cropping rectangle. | 
 **rotateFlipMethod** | **string**| RotateFlip method (Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY). Default is RotateNoneFlipNone. | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed image). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createwebsiteimagefeatures"></a>
## **CreateWebSiteImageFeatures**
> void CreateWebSiteImageFeatures(CreateWebSiteImageFeaturesRequest request)

Extract images features from web page and add them to search context

### **CreateWebSiteImageFeaturesRequest** Parameters
```csharp
CreateWebSiteImageFeaturesRequest(
    string searchContextId, 
    string imagesSource, 
    System.IO.Stream imageData = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imagesSource** | **string**| Images source - a web page | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="cropimage"></a>
## **CropImage**
> System.IO.Stream CropImage(CropImageRequest request)

Crop an existing image.

### **CropImageRequest** Parameters
```csharp
CropImageRequest(
    string name, 
    string format, 
    int? x, 
    int? y, 
    int? width, 
    int? height, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **x** | **int?**| X position of start point for cropping rectangle. | 
 **y** | **int?**| Y position of start point for cropping rectangle. | 
 **width** | **int?**| Width of cropping rectangle | 
 **height** | **int?**| Height of cropping rectangle. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deletefile"></a>
## **DeleteFile**
> void DeleteFile(DeleteFileRequest request)

Delete file

### **DeleteFileRequest** Parameters
```csharp
DeleteFileRequest(
    string path, 
    string storageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deletefolder"></a>
## **DeleteFolder**
> void DeleteFolder(DeleteFolderRequest request)

Delete folder

### **DeleteFolderRequest** Parameters
```csharp
DeleteFolderRequest(
    string path, 
    string storageName = null, 
    bool? recursive = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deleteimagefeatures"></a>
## **DeleteImageFeatures**
> void DeleteImageFeatures(DeleteImageFeaturesRequest request)

Deletes image features from search context.

### **DeleteImageFeaturesRequest** Parameters
```csharp
DeleteImageFeaturesRequest(
    string searchContextId, 
    string imageId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imageId** | **string**| The image identifier. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deleteimagesearch"></a>
## **DeleteImageSearch**
> void DeleteImageSearch(DeleteImageSearchRequest request)

Deletes the search context.

### **DeleteImageSearchRequest** Parameters
```csharp
DeleteImageSearchRequest(
    string searchContextId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deletesearchimage"></a>
## **DeleteSearchImage**
> void DeleteSearchImage(DeleteSearchImageRequest request)

Delete image and images features from search context

### **DeleteSearchImageRequest** Parameters
```csharp
DeleteSearchImageRequest(
    string searchContextId, 
    string imageId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| Search context identifier. | 
 **imageId** | **string**| Image identifier. | 
 **folder** | **string**| Folder. | [optional] 
 **storage** | **string**| Storage | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deskewimage"></a>
## **DeskewImage**
> System.IO.Stream DeskewImage(DeskewImageRequest request)

Deskew an existing image.

### **DeskewImageRequest** Parameters
```csharp
DeskewImageRequest(
    string name, 
    bool? resizePrortionally, 
    string bkColor = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **resizePrortionally** | **bool?**| Resize proportionally | 
 **bkColor** | **string**| Background color | [optional] 
 **folder** | **string**| Folder | [optional] 
 **storage** | **string**| Storage | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="downloadfile"></a>
## **DownloadFile**
> System.IO.Stream DownloadFile(DownloadFileRequest request)

Download file

### **DownloadFileRequest** Parameters
```csharp
DownloadFileRequest(
    string path, 
    string storageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="extractimagefeatures"></a>
## **ExtractImageFeatures**
> [ImageFeatures](ImageFeatures.md) ExtractImageFeatures(ExtractImageFeaturesRequest request)

Extract features from image without adding to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **ExtractImageFeaturesRequest** Parameters
```csharp
ExtractImageFeaturesRequest(
    string searchContextId, 
    string imageId, 
    System.IO.Stream imageData = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imageId** | **string**| The image identifier. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**ImageFeatures**](ImageFeatures.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="extractimageframeproperties"></a>
## **ExtractImageFrameProperties**
> [ImagingResponse](ImagingResponse.md) ExtractImageFrameProperties(ExtractImageFramePropertiesRequest request)

Get separate frame properties of existing TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **ExtractImageFramePropertiesRequest** Parameters
```csharp
ExtractImageFramePropertiesRequest(
    System.IO.Stream imageData, 
    int? frameId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **frameId** | **int?**| Number of a frame. | 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="extractimageproperties"></a>
## **ExtractImageProperties**
> [ImagingResponse](ImagingResponse.md) ExtractImageProperties(ExtractImagePropertiesRequest request)

Get properties of an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.

### **ExtractImagePropertiesRequest** Parameters
```csharp
ExtractImagePropertiesRequest(
    System.IO.Stream imageData)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="filtereffectimage"></a>
## **FilterEffectImage**
> System.IO.Stream FilterEffectImage(FilterEffectImageRequest request)

Apply filtering effects to an existing image.

### **FilterEffectImageRequest** Parameters
```csharp
FilterEffectImageRequest(
    string name, 
    string format, 
    string filterType, 
    FilterPropertiesBase filterProperties, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **filterType** | **string**| Filter type (BigRectangular, SmallRectangular, Median, GaussWiener, MotionWiener, GaussianBlur, Sharpen, BilateralSmoothing). | 
 **filterProperties** | [**FilterPropertiesBase**](FilterPropertiesBase.md)| Filter properties. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="findimageduplicates"></a>
## **FindImageDuplicates**
> [ImageDuplicatesSet](ImageDuplicatesSet.md) FindImageDuplicates(FindImageDuplicatesRequest request)

Find images duplicates.

### **FindImageDuplicatesRequest** Parameters
```csharp
FindImageDuplicatesRequest(
    string searchContextId, 
    double? similarityThreshold, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **similarityThreshold** | **double?**| The similarity threshold. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**ImageDuplicatesSet**](ImageDuplicatesSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="findimagesbytags"></a>
## **FindImagesByTags**
> [SearchResultsSet](SearchResultsSet.md) FindImagesByTags(FindImagesByTagsRequest request)

Find images by tags. Tags JSON string is passed as zero-indexed multipart/form-data content or as raw body stream.

### **FindImagesByTagsRequest** Parameters
```csharp
FindImagesByTagsRequest(
    string tags, 
    string searchContextId, 
    double? similarityThreshold, 
    int? maxCount, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tags** | **string**| Tags array for searching | 
 **searchContextId** | **string**| The search context identifier. | 
 **similarityThreshold** | **double?**| The similarity threshold. | 
 **maxCount** | **int?**| The maximum count. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**SearchResultsSet**](SearchResultsSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="findsimilarimages"></a>
## **FindSimilarImages**
> [SearchResultsSet](SearchResultsSet.md) FindSimilarImages(FindSimilarImagesRequest request)

Find similar images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **FindSimilarImagesRequest** Parameters
```csharp
FindSimilarImagesRequest(
    string searchContextId, 
    double? similarityThreshold, 
    int? maxCount, 
    System.IO.Stream imageData = null, 
    string imageId = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **similarityThreshold** | **double?**| The similarity threshold. | 
 **maxCount** | **int?**| The maximum count. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **imageId** | **string**| The search image identifier. | [optional] 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**SearchResultsSet**](SearchResultsSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getdiscusage"></a>
## **GetDiscUsage**
> [DiscUsage](DiscUsage.md) GetDiscUsage(GetDiscUsageRequest request)

Get disc usage

### **GetDiscUsageRequest** Parameters
```csharp
GetDiscUsageRequest(
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getfileversions"></a>
## **GetFileVersions**
> [FileVersions](FileVersions.md) GetFileVersions(GetFileVersionsRequest request)

Get file versions

### **GetFileVersionsRequest** Parameters
```csharp
GetFileVersionsRequest(
    string path, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getfileslist"></a>
## **GetFilesList**
> [FilesList](FilesList.md) GetFilesList(GetFilesListRequest request)

Get all files and folders within a folder

### **GetFilesListRequest** Parameters
```csharp
GetFilesListRequest(
    string path, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesList**](FilesList.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimagefeatures"></a>
## **GetImageFeatures**
> [ImageFeatures](ImageFeatures.md) GetImageFeatures(GetImageFeaturesRequest request)

Gets image features from search context.

### **GetImageFeaturesRequest** Parameters
```csharp
GetImageFeaturesRequest(
    string searchContextId, 
    string imageId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imageId** | **string**| The image identifier. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**ImageFeatures**](ImageFeatures.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageframe"></a>
## **GetImageFrame**
> System.IO.Stream GetImageFrame(GetImageFrameRequest request)

Get separate frame from existing TIFF image.

### **GetImageFrameRequest** Parameters
```csharp
GetImageFrameRequest(
    string name, 
    int? frameId, 
    int? newWidth = null, 
    int? newHeight = null, 
    int? x = null, 
    int? y = null, 
    int? rectWidth = null, 
    int? rectHeight = null, 
    string rotateFlipMethod = null, 
    bool? saveOtherFrames = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **frameId** | **int?**| Number of a frame. | 
 **newWidth** | **int?**| New width. | [optional] 
 **newHeight** | **int?**| New height. | [optional] 
 **x** | **int?**| X position of start point for cropping rectangle. | [optional] 
 **y** | **int?**| Y position of start point for cropping rectangle. | [optional] 
 **rectWidth** | **int?**| Width of cropping rectangle. | [optional] 
 **rectHeight** | **int?**| Height of cropping rectangle. | [optional] 
 **rotateFlipMethod** | **string**| RotateFlip method (Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY). Default is RotateNoneFlipNone. | [optional] 
 **saveOtherFrames** | **bool?**| If result will include all other frames or just a specified frame. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageframeproperties"></a>
## **GetImageFrameProperties**
> [ImagingResponse](ImagingResponse.md) GetImageFrameProperties(GetImageFramePropertiesRequest request)

Get separate frame properties of existing TIFF image.

### **GetImageFramePropertiesRequest** Parameters
```csharp
GetImageFramePropertiesRequest(
    string name, 
    int? frameId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename with image. | 
 **frameId** | **int?**| Number of a frame. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageproperties"></a>
## **GetImageProperties**
> [ImagingResponse](ImagingResponse.md) GetImageProperties(GetImagePropertiesRequest request)

Get properties of an image.

### **GetImagePropertiesRequest** Parameters
```csharp
GetImagePropertiesRequest(
    string name, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimagesearchstatus"></a>
## **GetImageSearchStatus**
> [SearchContextStatus](SearchContextStatus.md) GetImageSearchStatus(GetImageSearchStatusRequest request)

Gets the search context status.

### **GetImageSearchStatusRequest** Parameters
```csharp
GetImageSearchStatusRequest(
    string searchContextId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

[**SearchContextStatus**](SearchContextStatus.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getsearchimage"></a>
## **GetSearchImage**
> System.IO.Stream GetSearchImage(GetSearchImageRequest request)

Get image from search context

### **GetSearchImageRequest** Parameters
```csharp
GetSearchImageRequest(
    string searchContextId, 
    string imageId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| Search context identifier. | 
 **imageId** | **string**| Image identifier. | 
 **folder** | **string**| Folder. | [optional] 
 **storage** | **string**| Storage | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifybmp"></a>
## **ModifyBmp**
> System.IO.Stream ModifyBmp(ModifyBmpRequest request)

Update parameters of existing BMP image.

### **ModifyBmpRequest** Parameters
```csharp
ModifyBmpRequest(
    string name, 
    int? bitsPerPixel, 
    int? horizontalResolution, 
    int? verticalResolution, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **bitsPerPixel** | **int?**| Color depth. | 
 **horizontalResolution** | **int?**| New horizontal resolution. | 
 **verticalResolution** | **int?**| New vertical resolution. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifyemf"></a>
## **ModifyEmf**
> System.IO.Stream ModifyEmf(ModifyEmfRequest request)

Process existing EMF imaging using given parameters.

### **ModifyEmfRequest** Parameters
```csharp
ModifyEmfRequest(
    string name, 
    string bkColor, 
    int? pageWidth, 
    int? pageHeight, 
    int? borderX, 
    int? borderY, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null, 
    string format = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **bkColor** | **string**| Color of the background. | 
 **pageWidth** | **int?**| Width of the page. | 
 **pageHeight** | **int?**| Height of the page. | 
 **borderX** | **int?**| Border width. | 
 **borderY** | **int?**| Border height. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **format** | **string**| Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifygif"></a>
## **ModifyGif**
> System.IO.Stream ModifyGif(ModifyGifRequest request)

Update parameters of existing GIF image.

### **ModifyGifRequest** Parameters
```csharp
ModifyGifRequest(
    string name, 
    int? backgroundColorIndex = null, 
    int? colorResolution = null, 
    bool? hasTrailer = null, 
    bool? interlaced = null, 
    bool? isPaletteSorted = null, 
    int? pixelAspectRatio = null, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **backgroundColorIndex** | **int?**| Index of the background color. | [optional] [default to 32]
 **colorResolution** | **int?**| Color resolution. | [optional] [default to 3]
 **hasTrailer** | **bool?**| Specifies if image has trailer. | [optional] [default to true]
 **interlaced** | **bool?**| Specifies if image is interlaced. | [optional] [default to true]
 **isPaletteSorted** | **bool?**| Specifies if palette is sorted. | [optional] [default to false]
 **pixelAspectRatio** | **int?**| Pixel aspect ratio. | [optional] [default to 3]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to true]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifyjpeg"></a>
## **ModifyJpeg**
> System.IO.Stream ModifyJpeg(ModifyJpegRequest request)

Update parameters of existing JPEG image.

### **ModifyJpegRequest** Parameters
```csharp
ModifyJpegRequest(
    string name, 
    int? quality = null, 
    string compressionType = null, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **quality** | **int?**| Quality of an image from 0 to 100. Default is 75. | [optional] [default to 75]
 **compressionType** | **string**| Compression type: baseline (default), progressive, lossless or jpegls. | [optional] [default to baseline]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifyjpeg2000"></a>
## **ModifyJpeg2000**
> System.IO.Stream ModifyJpeg2000(ModifyJpeg2000Request request)

Update parameters of existing JPEG2000 image.

### **ModifyJpeg2000Request** Parameters
```csharp
ModifyJpeg2000Request(
    string name, 
    string comment, 
    string codec = null, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **comment** | **string**| The comment (can be either single or comma-separated). | 
 **codec** | **string**| The codec (j2k or jp2). | [optional] [default to j2k]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifypsd"></a>
## **ModifyPsd**
> System.IO.Stream ModifyPsd(ModifyPsdRequest request)

Update parameters of existing PSD image.

### **ModifyPsdRequest** Parameters
```csharp
ModifyPsdRequest(
    string name, 
    int? channelsCount = null, 
    string compressionMethod = null, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **channelsCount** | **int?**| Count of color channels. | [optional] [default to 4]
 **compressionMethod** | **string**| Compression method (for now, raw and RLE are supported). | [optional] [default to rle]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifysvg"></a>
## **ModifySvg**
> System.IO.Stream ModifySvg(ModifySvgRequest request)

Update parameters of existing SVG image.

### **ModifySvgRequest** Parameters
```csharp
ModifySvgRequest(
    string name, 
    string colorType = null, 
    bool? textAsShapes = null, 
    double? scaleX = null, 
    double? scaleY = null, 
    int? pageWidth = null, 
    int? pageHeight = null, 
    int? borderX = null, 
    int? borderY = null, 
    string bkColor = null, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null, 
    string format = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **colorType** | **string**| Color type for SVG image. Only RGB is supported for now. | [optional] [default to Rgb]
 **textAsShapes** | **bool?**| Whether text must be converted as shapes. true if all text is turned into SVG shapes in the convertion; otherwise, false | [optional] [default to false]
 **scaleX** | **double?**| Scale X. | [optional] [default to 0.0]
 **scaleY** | **double?**| Scale Y. | [optional] [default to 0.0]
 **pageWidth** | **int?**| Width of the page. | [optional] 
 **pageHeight** | **int?**| Height of the page. | [optional] 
 **borderX** | **int?**| Border width. Only 0 is supported for now. | [optional] 
 **borderY** | **int?**| Border height. Only 0 is supported for now. | [optional] 
 **bkColor** | **string**| Background color (Default is white). | [optional] [default to white]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **format** | **string**| Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | [optional] [default to svg]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifytiff"></a>
## **ModifyTiff**
> System.IO.Stream ModifyTiff(ModifyTiffRequest request)

Update parameters of existing TIFF image.

### **ModifyTiffRequest** Parameters
```csharp
ModifyTiffRequest(
    string name, 
    int? bitDepth, 
    string compression = null, 
    string resolutionUnit = null, 
    double? horizontalResolution = null, 
    double? verticalResolution = null, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **bitDepth** | **int?**| Bit depth. | 
 **compression** | **string**| Compression (none is default). Please, refer to https://apireference.aspose.com/net/imaging/aspose.imaging.fileformats.tiff.enums/tiffcompressions for all possible values. | [optional] 
 **resolutionUnit** | **string**| New resolution unit (none - the default one, inch or centimeter). | [optional] 
 **horizontalResolution** | **double?**| New horizontal resolution. | [optional] [default to 0.0]
 **verticalResolution** | **double?**| New vertical resolution. | [optional] [default to 0.0]
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifywebp"></a>
## **ModifyWebP**
> System.IO.Stream ModifyWebP(ModifyWebPRequest request)

Update parameters of existing WEBP image.

### **ModifyWebPRequest** Parameters
```csharp
ModifyWebPRequest(
    string name, 
    bool? lossLess, 
    int? quality, 
    int? animLoopCount, 
    string animBackgroundColor, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **lossLess** | **bool?**| If WEBP should be in lossless format. | 
 **quality** | **int?**| Quality (0-100). | 
 **animLoopCount** | **int?**| The animation loop count. | 
 **animBackgroundColor** | **string**| Color of the animation background. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifywmf"></a>
## **ModifyWmf**
> System.IO.Stream ModifyWmf(ModifyWmfRequest request)

Process existing WMF image using given parameters.

### **ModifyWmfRequest** Parameters
```csharp
ModifyWmfRequest(
    string name, 
    string bkColor, 
    int? pageWidth, 
    int? pageHeight, 
    int? borderX, 
    int? borderY, 
    bool? fromScratch = null, 
    string folder = null, 
    string storage = null, 
    string format = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **bkColor** | **string**| Color of the background. | 
 **pageWidth** | **int?**| Width of the page. | 
 **pageHeight** | **int?**| Height of the page. | 
 **borderX** | **int?**| Border width. | 
 **borderY** | **int?**| Border height. | 
 **fromScratch** | **bool?**| Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false. | [optional] [default to false]
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 
 **format** | **string**| Export format (PNG is the default one). Please, refer to the export table from https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="movefile"></a>
## **MoveFile**
> void MoveFile(MoveFileRequest request)

Move file

### **MoveFileRequest** Parameters
```csharp
MoveFileRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="movefolder"></a>
## **MoveFolder**
> void MoveFolder(MoveFolderRequest request)

Move folder

### **MoveFolderRequest** Parameters
```csharp
MoveFolderRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="objectexists"></a>
## **ObjectExists**
> [ObjectExist](ObjectExist.md) ObjectExists(ObjectExistsRequest request)

Check if file or folder exists

### **ObjectExistsRequest** Parameters
```csharp
ObjectExistsRequest(
    string path, 
    string storageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="resizeimage"></a>
## **ResizeImage**
> System.IO.Stream ResizeImage(ResizeImageRequest request)

Resize an existing image.

### **ResizeImageRequest** Parameters
```csharp
ResizeImageRequest(
    string name, 
    string format, 
    int? newWidth, 
    int? newHeight, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **newWidth** | **int?**| New width. | 
 **newHeight** | **int?**| New height. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="rotateflipimage"></a>
## **RotateFlipImage**
> System.IO.Stream RotateFlipImage(RotateFlipImageRequest request)

Rotate and/or flip an existing image.

### **RotateFlipImageRequest** Parameters
```csharp
RotateFlipImageRequest(
    string name, 
    string format, 
    string method, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **method** | **string**| RotateFlip method (Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY). | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="saveimageas"></a>
## **SaveImageAs**
> System.IO.Stream SaveImageAs(SaveImageAsRequest request)

Export existing image to another format.

### **SaveImageAsRequest** Parameters
```csharp
SaveImageAsRequest(
    string name, 
    string format, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of image. | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="storageexists"></a>
## **StorageExists**
> [StorageExist](StorageExist.md) StorageExists(StorageExistsRequest request)

Check if storage exists

### **StorageExistsRequest** Parameters
```csharp
StorageExistsRequest(
    string storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="updateimage"></a>
## **UpdateImage**
> System.IO.Stream UpdateImage(UpdateImageRequest request)

Perform scaling, cropping and flipping of an existing image in a single request.

### **UpdateImageRequest** Parameters
```csharp
UpdateImageRequest(
    string name, 
    string format, 
    int? newWidth, 
    int? newHeight, 
    int? x, 
    int? y, 
    int? rectWidth, 
    int? rectHeight, 
    string rotateFlipMethod, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an image. | 
 **format** | **string**| Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases. | 
 **newWidth** | **int?**| New width of the scaled image. | 
 **newHeight** | **int?**| New height of the scaled image. | 
 **x** | **int?**| X position of start point for cropping rectangle. | 
 **y** | **int?**| Y position of start point for cropping rectangle. | 
 **rectWidth** | **int?**| Width of cropping rectangle. | 
 **rectHeight** | **int?**| Height of cropping rectangle. | 
 **rotateFlipMethod** | **string**| RotateFlip method (Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY). Default is RotateNoneFlipNone. | 
 **folder** | **string**| Folder with image to process. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="updateimagefeatures"></a>
## **UpdateImageFeatures**
> void UpdateImageFeatures(UpdateImageFeaturesRequest request)

Update images features in search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **UpdateImageFeaturesRequest** Parameters
```csharp
UpdateImageFeaturesRequest(
    string searchContextId, 
    string imageId, 
    System.IO.Stream imageData = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| The search context identifier. | 
 **imageId** | **string**| The image identifier. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**| The folder. | [optional] 
 **storage** | **string**| The storage. | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="updatesearchimage"></a>
## **UpdateSearchImage**
> void UpdateSearchImage(UpdateSearchImageRequest request)

Update image and images features in search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.

### **UpdateSearchImageRequest** Parameters
```csharp
UpdateSearchImageRequest(
    string searchContextId, 
    string imageId, 
    System.IO.Stream imageData = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**| Search context identifier. | 
 **imageId** | **string**| Image identifier. | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**| Folder. | [optional] 
 **storage** | **string**| Storage | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="uploadfile"></a>
## **UploadFile**
> [FilesUploadResult](FilesUploadResult.md) UploadFile(UploadFileRequest request)

Upload file

### **UploadFileRequest** Parameters
```csharp
UploadFileRequest(
    string path, 
    System.IO.Stream file, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

