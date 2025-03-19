# Aspose.Imaging.Cloud.Sdk.Api.ImagingApi

<a name="addsearchimage"></a>
## **AddSearchImage**
> void AddSearchImage(AddSearchImageRequest request)



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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="appendtiff"></a>
## **AppendTiff**
> void AppendTiff(AppendTiffRequest request)



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
 **name** | **string**|  | 
 **appendFile** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="compareimages"></a>
## **CompareImages**
> [SearchResultsSet](SearchResultsSet.md) CompareImages(CompareImagesRequest request)



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
 **searchContextId** | **string**|  | 
 **imageId1** | **string**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **imageId2** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**SearchResultsSet**](SearchResultsSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="convertimage"></a>
## **ConvertImage**
> System.IO.Stream ConvertImage(ConvertImageRequest request)



### **ConvertImageRequest** Parameters
```csharp
ConvertImageRequest(
    string name, 
    string format, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **format** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="converttifftofax"></a>
## **ConvertTiffToFax**
> System.IO.Stream ConvertTiffToFax(ConvertTiffToFaxRequest request)



### **ConvertTiffToFaxRequest** Parameters
```csharp
ConvertTiffToFaxRequest(
    string name, 
    string storage = null, 
    string folder = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

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

<a name="createconvertedimage"></a>
## **CreateConvertedImage**
> System.IO.Stream CreateConvertedImage(CreateConvertedImageRequest request)



### **CreateConvertedImageRequest** Parameters
```csharp
CreateConvertedImageRequest(
    System.IO.Stream imageData, 
    string format, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **format** | **string**|  | 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createcroppedimage"></a>
## **CreateCroppedImage**
> System.IO.Stream CreateCroppedImage(CreateCroppedImageRequest request)



### **CreateCroppedImageRequest** Parameters
```csharp
CreateCroppedImageRequest(
    System.IO.Stream imageData, 
    int? x, 
    int? y, 
    int? width, 
    int? height, 
    string format = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **width** | **int?**|  | 
 **height** | **int?**|  | 
 **format** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createdeskewedimage"></a>
## **CreateDeskewedImage**
> System.IO.Stream CreateDeskewedImage(CreateDeskewedImageRequest request)



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
 **resizeProportionally** | **bool?**|  | 
 **bkColor** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createfaxtiff"></a>
## **CreateFaxTiff**
> System.IO.Stream CreateFaxTiff(CreateFaxTiffRequest request)



### **CreateFaxTiffRequest** Parameters
```csharp
CreateFaxTiffRequest(
    System.IO.Stream imageData, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

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

<a name="creategrayscaledimage"></a>
## **CreateGrayscaledImage**
> System.IO.Stream CreateGrayscaledImage(CreateGrayscaledImageRequest request)



### **CreateGrayscaledImageRequest** Parameters
```csharp
CreateGrayscaledImageRequest(
    System.IO.Stream imageData, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimagefeatures"></a>
## **CreateImageFeatures**
> void CreateImageFeatures(CreateImageFeaturesRequest request)



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
 **searchContextId** | **string**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **imageId** | **string**|  | [optional] 
 **imagesFolder** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimageframe"></a>
## **CreateImageFrame**
> System.IO.Stream CreateImageFrame(CreateImageFrameRequest request)



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
 **frameId** | **int?**|  | 
 **newWidth** | **int?**|  | [optional] 
 **newHeight** | **int?**|  | [optional] 
 **x** | **int?**|  | [optional] 
 **y** | **int?**|  | [optional] 
 **rectWidth** | **int?**|  | [optional] 
 **rectHeight** | **int?**|  | [optional] 
 **rotateFlipMethod** | **string**|  | [optional] 
 **saveOtherFrames** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimageframerange"></a>
## **CreateImageFrameRange**
> System.IO.Stream CreateImageFrameRange(CreateImageFrameRangeRequest request)



### **CreateImageFrameRangeRequest** Parameters
```csharp
CreateImageFrameRangeRequest(
    System.IO.Stream imageData, 
    int? startFrameId, 
    int? endFrameId, 
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
 **startFrameId** | **int?**|  | 
 **endFrameId** | **int?**|  | 
 **newWidth** | **int?**|  | [optional] 
 **newHeight** | **int?**|  | [optional] 
 **x** | **int?**|  | [optional] 
 **y** | **int?**|  | [optional] 
 **rectWidth** | **int?**|  | [optional] 
 **rectHeight** | **int?**|  | [optional] 
 **rotateFlipMethod** | **string**|  | [optional] 
 **saveOtherFrames** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimagesearch"></a>
## **CreateImageSearch**
> [SearchContextStatus](SearchContextStatus.md) CreateImageSearch(CreateImageSearchRequest request)



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
 **detector** | **string**|  | [optional] [default to akaze]
 **matchingAlgorithm** | **string**|  | [optional] [default to randomBinaryTree]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**SearchContextStatus**](SearchContextStatus.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createimagetag"></a>
## **CreateImageTag**
> void CreateImageTag(CreateImageTagRequest request)



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
 **searchContextId** | **string**|  | 
 **tagName** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedbmp"></a>
## **CreateModifiedBmp**
> System.IO.Stream CreateModifiedBmp(CreateModifiedBmpRequest request)



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
 **bitsPerPixel** | **int?**|  | 
 **horizontalResolution** | **int?**|  | 
 **verticalResolution** | **int?**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedemf"></a>
## **CreateModifiedEmf**
> System.IO.Stream CreateModifiedEmf(CreateModifiedEmfRequest request)



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
 **bkColor** | **string**|  | 
 **pageWidth** | **int?**|  | 
 **pageHeight** | **int?**|  | 
 **borderX** | **int?**|  | 
 **borderY** | **int?**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 
 **format** | **string**|  | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedgif"></a>
## **CreateModifiedGif**
> System.IO.Stream CreateModifiedGif(CreateModifiedGifRequest request)



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
 **backgroundColorIndex** | **int?**|  | [optional] [default to 32]
 **colorResolution** | **int?**|  | [optional] [default to 3]
 **hasTrailer** | **bool?**|  | [optional] [default to true]
 **interlaced** | **bool?**|  | [optional] [default to true]
 **isPaletteSorted** | **bool?**|  | [optional] [default to false]
 **pixelAspectRatio** | **int?**|  | [optional] [default to 3]
 **fromScratch** | **bool?**|  | [optional] [default to true]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedjpeg"></a>
## **CreateModifiedJpeg**
> System.IO.Stream CreateModifiedJpeg(CreateModifiedJpegRequest request)



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
 **quality** | **int?**|  | [optional] [default to 75]
 **compressionType** | **string**|  | [optional] [default to baseline]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedjpeg2000"></a>
## **CreateModifiedJpeg2000**
> System.IO.Stream CreateModifiedJpeg2000(CreateModifiedJpeg2000Request request)



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
 **comment** | **string**|  | 
 **codec** | **string**|  | [optional] [default to j2k]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedpsd"></a>
## **CreateModifiedPsd**
> System.IO.Stream CreateModifiedPsd(CreateModifiedPsdRequest request)



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
 **channelsCount** | **int?**|  | [optional] [default to 4]
 **compressionMethod** | **string**|  | [optional] [default to rle]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedsvg"></a>
## **CreateModifiedSvg**
> System.IO.Stream CreateModifiedSvg(CreateModifiedSvgRequest request)



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
 **colorType** | **string**|  | [optional] [default to Rgb]
 **textAsShapes** | **bool?**|  | [optional] [default to false]
 **scaleX** | **double?**|  | [optional] [default to 0.0]
 **scaleY** | **double?**|  | [optional] [default to 0.0]
 **pageWidth** | **int?**|  | [optional] 
 **pageHeight** | **int?**|  | [optional] 
 **borderX** | **int?**|  | [optional] 
 **borderY** | **int?**|  | [optional] 
 **bkColor** | **string**|  | [optional] [default to white]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 
 **format** | **string**|  | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedtiff"></a>
## **CreateModifiedTiff**
> System.IO.Stream CreateModifiedTiff(CreateModifiedTiffRequest request)



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
 **bitDepth** | **int?**|  | 
 **compression** | **string**|  | [optional] 
 **resolutionUnit** | **string**|  | [optional] 
 **horizontalResolution** | **double?**|  | [optional] [default to 0.0]
 **verticalResolution** | **double?**|  | [optional] [default to 0.0]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedwebp"></a>
## **CreateModifiedWebP**
> System.IO.Stream CreateModifiedWebP(CreateModifiedWebPRequest request)



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
 **lossLess** | **bool?**|  | 
 **quality** | **int?**|  | 
 **animLoopCount** | **int?**|  | 
 **animBackgroundColor** | **string**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createmodifiedwmf"></a>
## **CreateModifiedWmf**
> System.IO.Stream CreateModifiedWmf(CreateModifiedWmfRequest request)



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
 **bkColor** | **string**|  | 
 **pageWidth** | **int?**|  | 
 **pageHeight** | **int?**|  | 
 **borderX** | **int?**|  | 
 **borderY** | **int?**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 
 **format** | **string**|  | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createobjectbounds"></a>
## **CreateObjectBounds**
> [DetectedObjectList](DetectedObjectList.md) CreateObjectBounds(CreateObjectBoundsRequest request)



### **CreateObjectBoundsRequest** Parameters
```csharp
CreateObjectBoundsRequest(
    System.IO.Stream imageData, 
    string method = null, 
    int? threshold = null, 
    bool? includeLabel = null, 
    bool? includeScore = null, 
    string allowedLabels = null, 
    string blockedLabels = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **method** | **string**|  | [optional] [default to ssd]
 **threshold** | **int?**|  | [optional] [default to 50]
 **includeLabel** | **bool?**|  | [optional] [default to false]
 **includeScore** | **bool?**|  | [optional] [default to false]
 **allowedLabels** | **string**|  | [optional] 
 **blockedLabels** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**DetectedObjectList**](DetectedObjectList.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createresizedimage"></a>
## **CreateResizedImage**
> System.IO.Stream CreateResizedImage(CreateResizedImageRequest request)



### **CreateResizedImageRequest** Parameters
```csharp
CreateResizedImageRequest(
    System.IO.Stream imageData, 
    int? newWidth, 
    int? newHeight, 
    string format = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **newWidth** | **int?**|  | 
 **newHeight** | **int?**|  | 
 **format** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createrotateflippedimage"></a>
## **CreateRotateFlippedImage**
> System.IO.Stream CreateRotateFlippedImage(CreateRotateFlippedImageRequest request)



### **CreateRotateFlippedImageRequest** Parameters
```csharp
CreateRotateFlippedImageRequest(
    System.IO.Stream imageData, 
    string method, 
    string format = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **method** | **string**|  | 
 **format** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createupdatedimage"></a>
## **CreateUpdatedImage**
> System.IO.Stream CreateUpdatedImage(CreateUpdatedImageRequest request)



### **CreateUpdatedImageRequest** Parameters
```csharp
CreateUpdatedImageRequest(
    System.IO.Stream imageData, 
    int? newWidth, 
    int? newHeight, 
    int? x, 
    int? y, 
    int? rectWidth, 
    int? rectHeight, 
    string rotateFlipMethod, 
    string format = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **newWidth** | **int?**|  | 
 **newHeight** | **int?**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **rectWidth** | **int?**|  | 
 **rectHeight** | **int?**|  | 
 **rotateFlipMethod** | **string**|  | 
 **format** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createvisualobjectbounds"></a>
## **CreateVisualObjectBounds**
> System.IO.Stream CreateVisualObjectBounds(CreateVisualObjectBoundsRequest request)



### **CreateVisualObjectBoundsRequest** Parameters
```csharp
CreateVisualObjectBoundsRequest(
    System.IO.Stream imageData, 
    string method = null, 
    int? threshold = null, 
    bool? includeLabel = null, 
    bool? includeScore = null, 
    string allowedLabels = null, 
    string blockedLabels = null, 
    string color = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **method** | **string**|  | [optional] [default to ssd]
 **threshold** | **int?**|  | [optional] [default to 50]
 **includeLabel** | **bool?**|  | [optional] [default to false]
 **includeScore** | **bool?**|  | [optional] [default to false]
 **allowedLabels** | **string**|  | [optional] 
 **blockedLabels** | **string**|  | [optional] 
 **color** | **string**|  | [optional] 
 **outPath** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createwebsiteimagefeatures"></a>
## **CreateWebSiteImageFeatures**
> void CreateWebSiteImageFeatures(CreateWebSiteImageFeaturesRequest request)



### **CreateWebSiteImageFeaturesRequest** Parameters
```csharp
CreateWebSiteImageFeaturesRequest(
    string searchContextId, 
    string imagesSource, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**|  | 
 **imagesSource** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="cropimage"></a>
## **CropImage**
> System.IO.Stream CropImage(CropImageRequest request)



### **CropImageRequest** Parameters
```csharp
CropImageRequest(
    string name, 
    int? x, 
    int? y, 
    int? width, 
    int? height, 
    string format = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **width** | **int?**|  | 
 **height** | **int?**|  | 
 **format** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deleteimagesearch"></a>
## **DeleteImageSearch**
> void DeleteImageSearch(DeleteImageSearchRequest request)



### **DeleteImageSearchRequest** Parameters
```csharp
DeleteImageSearchRequest(
    string searchContextId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deletesearchimage"></a>
## **DeleteSearchImage**
> void DeleteSearchImage(DeleteSearchImageRequest request)



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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deskewimage"></a>
## **DeskewImage**
> System.IO.Stream DeskewImage(DeskewImageRequest request)



### **DeskewImageRequest** Parameters
```csharp
DeskewImageRequest(
    string name, 
    bool? resizeProportionally, 
    string bkColor = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **resizeProportionally** | **bool?**|  | 
 **bkColor** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**ImageFeatures**](ImageFeatures.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="extractimageframeproperties"></a>
## **ExtractImageFrameProperties**
> [ImagingResponse](ImagingResponse.md) ExtractImageFrameProperties(ExtractImageFramePropertiesRequest request)



### **ExtractImageFramePropertiesRequest** Parameters
```csharp
ExtractImageFramePropertiesRequest(
    System.IO.Stream imageData, 
    int? frameId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageData** | **System.IO.Stream**| Input image | 
 **frameId** | **int?**|  | 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="extractimageproperties"></a>
## **ExtractImageProperties**
> [ImagingResponse](ImagingResponse.md) ExtractImageProperties(ExtractImagePropertiesRequest request)



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



### **FilterEffectImageRequest** Parameters
```csharp
FilterEffectImageRequest(
    string name, 
    string filterType, 
    FilterPropertiesBase filterProperties, 
    string format = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **filterType** | **string**|  | 
 **filterProperties** | [**FilterPropertiesBase**](FilterPropertiesBase.md)|  | 
 **format** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="findimageduplicates"></a>
## **FindImageDuplicates**
> [ImageDuplicatesSet](ImageDuplicatesSet.md) FindImageDuplicates(FindImageDuplicatesRequest request)



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
 **searchContextId** | **string**|  | 
 **similarityThreshold** | **double?**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**ImageDuplicatesSet**](ImageDuplicatesSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="findimagesbytags"></a>
## **FindImagesByTags**
> [SearchResultsSet](SearchResultsSet.md) FindImagesByTags(FindImagesByTagsRequest request)



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
 **searchContextId** | **string**|  | 
 **similarityThreshold** | **double?**|  | 
 **maxCount** | **int?**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**SearchResultsSet**](SearchResultsSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="findsimilarimages"></a>
## **FindSimilarImages**
> [SearchResultsSet](SearchResultsSet.md) FindSimilarImages(FindSimilarImagesRequest request)



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
 **searchContextId** | **string**|  | 
 **similarityThreshold** | **double?**|  | 
 **maxCount** | **int?**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **imageId** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**SearchResultsSet**](SearchResultsSet.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getavailablelabels"></a>
## **GetAvailableLabels**
> [AvailableLabelsList](AvailableLabelsList.md) GetAvailableLabels(GetAvailableLabelsRequest request)



### **GetAvailableLabelsRequest** Parameters
```csharp
GetAvailableLabelsRequest(
    string method)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **method** | **string**|  | 

### Return type

[**AvailableLabelsList**](AvailableLabelsList.md)

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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**ImageFeatures**](ImageFeatures.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageframe"></a>
## **GetImageFrame**
> System.IO.Stream GetImageFrame(GetImageFrameRequest request)



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
 **name** | **string**|  | 
 **frameId** | **int?**|  | 
 **newWidth** | **int?**|  | [optional] 
 **newHeight** | **int?**|  | [optional] 
 **x** | **int?**|  | [optional] 
 **y** | **int?**|  | [optional] 
 **rectWidth** | **int?**|  | [optional] 
 **rectHeight** | **int?**|  | [optional] 
 **rotateFlipMethod** | **string**|  | [optional] 
 **saveOtherFrames** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageframeproperties"></a>
## **GetImageFrameProperties**
> [ImagingResponse](ImagingResponse.md) GetImageFrameProperties(GetImageFramePropertiesRequest request)



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
 **name** | **string**|  | 
 **frameId** | **int?**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageframerange"></a>
## **GetImageFrameRange**
> System.IO.Stream GetImageFrameRange(GetImageFrameRangeRequest request)



### **GetImageFrameRangeRequest** Parameters
```csharp
GetImageFrameRangeRequest(
    string name, 
    int? startFrameId, 
    int? endFrameId, 
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
 **name** | **string**|  | 
 **startFrameId** | **int?**|  | 
 **endFrameId** | **int?**|  | 
 **newWidth** | **int?**|  | [optional] 
 **newHeight** | **int?**|  | [optional] 
 **x** | **int?**|  | [optional] 
 **y** | **int?**|  | [optional] 
 **rectWidth** | **int?**|  | [optional] 
 **rectHeight** | **int?**|  | [optional] 
 **rotateFlipMethod** | **string**|  | [optional] 
 **saveOtherFrames** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimageproperties"></a>
## **GetImageProperties**
> [ImagingResponse](ImagingResponse.md) GetImageProperties(GetImagePropertiesRequest request)



### **GetImagePropertiesRequest** Parameters
```csharp
GetImagePropertiesRequest(
    string name, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**ImagingResponse**](ImagingResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getimagesearchstatus"></a>
## **GetImageSearchStatus**
> [SearchContextStatus](SearchContextStatus.md) GetImageSearchStatus(GetImageSearchStatusRequest request)



### **GetImageSearchStatusRequest** Parameters
```csharp
GetImageSearchStatusRequest(
    string searchContextId, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchContextId** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**SearchContextStatus**](SearchContextStatus.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getobjectbounds"></a>
## **GetObjectBounds**
> [DetectedObjectList](DetectedObjectList.md) GetObjectBounds(GetObjectBoundsRequest request)



### **GetObjectBoundsRequest** Parameters
```csharp
GetObjectBoundsRequest(
    string name, 
    string method = null, 
    int? threshold = null, 
    bool? includeLabel = null, 
    bool? includeScore = null, 
    string allowedLabels = null, 
    string blockedLabels = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **method** | **string**|  | [optional] [default to ssd]
 **threshold** | **int?**|  | [optional] [default to 50]
 **includeLabel** | **bool?**|  | [optional] [default to false]
 **includeScore** | **bool?**|  | [optional] [default to false]
 **allowedLabels** | **string**|  | [optional] 
 **blockedLabels** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

[**DetectedObjectList**](DetectedObjectList.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getsearchimage"></a>
## **GetSearchImage**
> System.IO.Stream GetSearchImage(GetSearchImageRequest request)



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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getvisualobjectbounds"></a>
## **GetVisualObjectBounds**
> System.IO.Stream GetVisualObjectBounds(GetVisualObjectBoundsRequest request)



### **GetVisualObjectBoundsRequest** Parameters
```csharp
GetVisualObjectBoundsRequest(
    string name, 
    string method = null, 
    int? threshold = null, 
    bool? includeLabel = null, 
    bool? includeScore = null, 
    string allowedLabels = null, 
    string blockedLabels = null, 
    string color = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **method** | **string**|  | [optional] [default to ssd]
 **threshold** | **int?**|  | [optional] [default to 50]
 **includeLabel** | **bool?**|  | [optional] [default to false]
 **includeScore** | **bool?**|  | [optional] [default to false]
 **allowedLabels** | **string**|  | [optional] 
 **blockedLabels** | **string**|  | [optional] 
 **color** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="grayscaleimage"></a>
## **GrayscaleImage**
> System.IO.Stream GrayscaleImage(GrayscaleImageRequest request)



### **GrayscaleImageRequest** Parameters
```csharp
GrayscaleImageRequest(
    string name, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifybmp"></a>
## **ModifyBmp**
> System.IO.Stream ModifyBmp(ModifyBmpRequest request)



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
 **name** | **string**|  | 
 **bitsPerPixel** | **int?**|  | 
 **horizontalResolution** | **int?**|  | 
 **verticalResolution** | **int?**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifyemf"></a>
## **ModifyEmf**
> System.IO.Stream ModifyEmf(ModifyEmfRequest request)



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
 **name** | **string**|  | 
 **bkColor** | **string**|  | 
 **pageWidth** | **int?**|  | 
 **pageHeight** | **int?**|  | 
 **borderX** | **int?**|  | 
 **borderY** | **int?**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 
 **format** | **string**|  | [optional] [default to png]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifygif"></a>
## **ModifyGif**
> System.IO.Stream ModifyGif(ModifyGifRequest request)



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
 **name** | **string**|  | 
 **backgroundColorIndex** | **int?**|  | [optional] [default to 32]
 **colorResolution** | **int?**|  | [optional] [default to 3]
 **hasTrailer** | **bool?**|  | [optional] [default to true]
 **interlaced** | **bool?**|  | [optional] [default to true]
 **isPaletteSorted** | **bool?**|  | [optional] [default to false]
 **pixelAspectRatio** | **int?**|  | [optional] [default to 3]
 **fromScratch** | **bool?**|  | [optional] [default to true]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifyjpeg"></a>
## **ModifyJpeg**
> System.IO.Stream ModifyJpeg(ModifyJpegRequest request)



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
 **name** | **string**|  | 
 **quality** | **int?**|  | [optional] [default to 75]
 **compressionType** | **string**|  | [optional] [default to baseline]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifyjpeg2000"></a>
## **ModifyJpeg2000**
> System.IO.Stream ModifyJpeg2000(ModifyJpeg2000Request request)



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
 **name** | **string**|  | 
 **comment** | **string**|  | 
 **codec** | **string**|  | [optional] [default to j2k]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifypsd"></a>
## **ModifyPsd**
> System.IO.Stream ModifyPsd(ModifyPsdRequest request)



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
 **name** | **string**|  | 
 **channelsCount** | **int?**|  | [optional] [default to 4]
 **compressionMethod** | **string**|  | [optional] [default to rle]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifysvg"></a>
## **ModifySvg**
> System.IO.Stream ModifySvg(ModifySvgRequest request)



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
 **name** | **string**|  | 
 **colorType** | **string**|  | [optional] [default to Rgb]
 **textAsShapes** | **bool?**|  | [optional] [default to false]
 **scaleX** | **double?**|  | [optional] [default to 0.0]
 **scaleY** | **double?**|  | [optional] [default to 0.0]
 **pageWidth** | **int?**|  | [optional] 
 **pageHeight** | **int?**|  | [optional] 
 **borderX** | **int?**|  | [optional] 
 **borderY** | **int?**|  | [optional] 
 **bkColor** | **string**|  | [optional] [default to white]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 
 **format** | **string**|  | [optional] [default to svg]

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifytiff"></a>
## **ModifyTiff**
> System.IO.Stream ModifyTiff(ModifyTiffRequest request)



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
 **name** | **string**|  | 
 **bitDepth** | **int?**|  | 
 **compression** | **string**|  | [optional] 
 **resolutionUnit** | **string**|  | [optional] 
 **horizontalResolution** | **double?**|  | [optional] [default to 0.0]
 **verticalResolution** | **double?**|  | [optional] [default to 0.0]
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifywebp"></a>
## **ModifyWebP**
> System.IO.Stream ModifyWebP(ModifyWebPRequest request)



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
 **name** | **string**|  | 
 **lossLess** | **bool?**|  | 
 **quality** | **int?**|  | 
 **animLoopCount** | **int?**|  | 
 **animBackgroundColor** | **string**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="modifywmf"></a>
## **ModifyWmf**
> System.IO.Stream ModifyWmf(ModifyWmfRequest request)



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
 **name** | **string**|  | 
 **bkColor** | **string**|  | 
 **pageWidth** | **int?**|  | 
 **pageHeight** | **int?**|  | 
 **borderX** | **int?**|  | 
 **borderY** | **int?**|  | 
 **fromScratch** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 
 **format** | **string**|  | [optional] [default to png]

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



### **ResizeImageRequest** Parameters
```csharp
ResizeImageRequest(
    string name, 
    int? newWidth, 
    int? newHeight, 
    string format = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **newWidth** | **int?**|  | 
 **newHeight** | **int?**|  | 
 **format** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="rotateflipimage"></a>
## **RotateFlipImage**
> System.IO.Stream RotateFlipImage(RotateFlipImageRequest request)



### **RotateFlipImageRequest** Parameters
```csharp
RotateFlipImageRequest(
    string name, 
    string method, 
    string format = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **method** | **string**|  | 
 **format** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

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



### **UpdateImageRequest** Parameters
```csharp
UpdateImageRequest(
    string name, 
    int? newWidth, 
    int? newHeight, 
    int? x, 
    int? y, 
    int? rectWidth, 
    int? rectHeight, 
    string rotateFlipMethod, 
    string format = null, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **newWidth** | **int?**|  | 
 **newHeight** | **int?**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **rectWidth** | **int?**|  | 
 **rectHeight** | **int?**|  | 
 **rotateFlipMethod** | **string**|  | 
 **format** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="updateimagefeatures"></a>
## **UpdateImageFeatures**
> void UpdateImageFeatures(UpdateImageFeaturesRequest request)



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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="updatesearchimage"></a>
## **UpdateSearchImage**
> void UpdateSearchImage(UpdateSearchImageRequest request)



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
 **searchContextId** | **string**|  | 
 **imageId** | **string**|  | 
 **imageData** | **System.IO.Stream**| Input image | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**|  | [optional] 

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

