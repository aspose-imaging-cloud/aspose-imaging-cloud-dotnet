<a name="documentation-for-api-endpoints"></a>
## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ImagingApi* | [**AddSearchImage**](ImagingApi.md#addsearchimage) | **POST** /imaging/ai/imageSearch/{searchContextId}/image | 
*ImagingApi* | [**AppendTiff**](ImagingApi.md#appendtiff) | **POST** /imaging/tiff/{name}/appendTiff | 
*ImagingApi* | [**CompareImages**](ImagingApi.md#compareimages) | **POST** /imaging/ai/imageSearch/{searchContextId}/compare | 
*ImagingApi* | [**ConvertImage**](ImagingApi.md#convertimage) | **GET** /imaging/{name}/convert | 
*ImagingApi* | [**ConvertTiffToFax**](ImagingApi.md#converttifftofax) | **GET** /imaging/tiff/{name}/toFax | 
*ImagingApi* | [**CopyFile**](ImagingApi.md#copyfile) | **PUT** /imaging/storage/file/copy/{srcPath} | Copy file
*ImagingApi* | [**CopyFolder**](ImagingApi.md#copyfolder) | **PUT** /imaging/storage/folder/copy/{srcPath} | Copy folder
*ImagingApi* | [**CreateConvertedImage**](ImagingApi.md#createconvertedimage) | **POST** /imaging/convert | 
*ImagingApi* | [**CreateCroppedImage**](ImagingApi.md#createcroppedimage) | **POST** /imaging/crop | 
*ImagingApi* | [**CreateDeskewedImage**](ImagingApi.md#createdeskewedimage) | **POST** /imaging/deskew | 
*ImagingApi* | [**CreateFaxTiff**](ImagingApi.md#createfaxtiff) | **POST** /imaging/tiff/toFax | 
*ImagingApi* | [**CreateFolder**](ImagingApi.md#createfolder) | **PUT** /imaging/storage/folder/{path} | Create the folder
*ImagingApi* | [**CreateGrayscaledImage**](ImagingApi.md#creategrayscaledimage) | **POST** /imaging/grayscale | 
*ImagingApi* | [**CreateImageFeatures**](ImagingApi.md#createimagefeatures) | **POST** /imaging/ai/imageSearch/{searchContextId}/features | 
*ImagingApi* | [**CreateImageFrame**](ImagingApi.md#createimageframe) | **POST** /imaging/frames/{frameId} | 
*ImagingApi* | [**CreateImageFrameRange**](ImagingApi.md#createimageframerange) | **POST** /imaging/frames/range | 
*ImagingApi* | [**CreateImageSearch**](ImagingApi.md#createimagesearch) | **POST** /imaging/ai/imageSearch/create | 
*ImagingApi* | [**CreateImageTag**](ImagingApi.md#createimagetag) | **POST** /imaging/ai/imageSearch/{searchContextId}/addTag | 
*ImagingApi* | [**CreateModifiedBmp**](ImagingApi.md#createmodifiedbmp) | **POST** /imaging/bmp | 
*ImagingApi* | [**CreateModifiedEmf**](ImagingApi.md#createmodifiedemf) | **POST** /imaging/emf | 
*ImagingApi* | [**CreateModifiedGif**](ImagingApi.md#createmodifiedgif) | **POST** /imaging/gif | 
*ImagingApi* | [**CreateModifiedJpeg**](ImagingApi.md#createmodifiedjpeg) | **POST** /imaging/jpg | 
*ImagingApi* | [**CreateModifiedJpeg2000**](ImagingApi.md#createmodifiedjpeg2000) | **POST** /imaging/jpg2000 | 
*ImagingApi* | [**CreateModifiedPsd**](ImagingApi.md#createmodifiedpsd) | **POST** /imaging/psd | 
*ImagingApi* | [**CreateModifiedSvg**](ImagingApi.md#createmodifiedsvg) | **POST** /imaging/svg | 
*ImagingApi* | [**CreateModifiedTiff**](ImagingApi.md#createmodifiedtiff) | **POST** /imaging/tiff | 
*ImagingApi* | [**CreateModifiedWebP**](ImagingApi.md#createmodifiedwebp) | **POST** /imaging/webp | 
*ImagingApi* | [**CreateModifiedWmf**](ImagingApi.md#createmodifiedwmf) | **POST** /imaging/wmf | 
*ImagingApi* | [**CreateObjectBounds**](ImagingApi.md#createobjectbounds) | **POST** /imaging/ai/objectdetection/bounds | 
*ImagingApi* | [**CreateResizedImage**](ImagingApi.md#createresizedimage) | **POST** /imaging/resize | 
*ImagingApi* | [**CreateRotateFlippedImage**](ImagingApi.md#createrotateflippedimage) | **POST** /imaging/rotateflip | 
*ImagingApi* | [**CreateUpdatedImage**](ImagingApi.md#createupdatedimage) | **POST** /imaging/updateImage | 
*ImagingApi* | [**CreateVisualObjectBounds**](ImagingApi.md#createvisualobjectbounds) | **POST** /imaging/ai/objectdetection/visualbounds | 
*ImagingApi* | [**CreateWebSiteImageFeatures**](ImagingApi.md#createwebsiteimagefeatures) | **POST** /imaging/ai/imageSearch/{searchContextId}/features/web | 
*ImagingApi* | [**CropImage**](ImagingApi.md#cropimage) | **GET** /imaging/{name}/crop | 
*ImagingApi* | [**DeleteFile**](ImagingApi.md#deletefile) | **DELETE** /imaging/storage/file/{path} | Delete file
*ImagingApi* | [**DeleteFolder**](ImagingApi.md#deletefolder) | **DELETE** /imaging/storage/folder/{path} | Delete folder
*ImagingApi* | [**DeleteImageFeatures**](ImagingApi.md#deleteimagefeatures) | **DELETE** /imaging/ai/imageSearch/{searchContextId}/features | 
*ImagingApi* | [**DeleteImageSearch**](ImagingApi.md#deleteimagesearch) | **DELETE** /imaging/ai/imageSearch/{searchContextId} | 
*ImagingApi* | [**DeleteSearchImage**](ImagingApi.md#deletesearchimage) | **DELETE** /imaging/ai/imageSearch/{searchContextId}/image | 
*ImagingApi* | [**DeskewImage**](ImagingApi.md#deskewimage) | **GET** /imaging/{name}/deskew | 
*ImagingApi* | [**DownloadFile**](ImagingApi.md#downloadfile) | **GET** /imaging/storage/file/{path} | Download file
*ImagingApi* | [**ExtractImageFeatures**](ImagingApi.md#extractimagefeatures) | **GET** /imaging/ai/imageSearch/{searchContextId}/image2features | 
*ImagingApi* | [**ExtractImageFrameProperties**](ImagingApi.md#extractimageframeproperties) | **POST** /imaging/frames/{frameId}/properties | 
*ImagingApi* | [**ExtractImageProperties**](ImagingApi.md#extractimageproperties) | **POST** /imaging/properties | 
*ImagingApi* | [**FilterEffectImage**](ImagingApi.md#filtereffectimage) | **PUT** /imaging/{name}/filterEffect | 
*ImagingApi* | [**FindImageDuplicates**](ImagingApi.md#findimageduplicates) | **GET** /imaging/ai/imageSearch/{searchContextId}/findDuplicates | 
*ImagingApi* | [**FindImagesByTags**](ImagingApi.md#findimagesbytags) | **POST** /imaging/ai/imageSearch/{searchContextId}/findByTags | 
*ImagingApi* | [**FindSimilarImages**](ImagingApi.md#findsimilarimages) | **GET** /imaging/ai/imageSearch/{searchContextId}/findSimilar | 
*ImagingApi* | [**GetAvailableLabels**](ImagingApi.md#getavailablelabels) | **GET** /imaging/ai/objectdetection/availablelabels/{method} | 
*ImagingApi* | [**GetDiscUsage**](ImagingApi.md#getdiscusage) | **GET** /imaging/storage/disc | Get disc usage
*ImagingApi* | [**GetFileVersions**](ImagingApi.md#getfileversions) | **GET** /imaging/storage/version/{path} | Get file versions
*ImagingApi* | [**GetFilesList**](ImagingApi.md#getfileslist) | **GET** /imaging/storage/folder/{path} | Get all files and folders within a folder
*ImagingApi* | [**GetImageFeatures**](ImagingApi.md#getimagefeatures) | **GET** /imaging/ai/imageSearch/{searchContextId}/features | 
*ImagingApi* | [**GetImageFrame**](ImagingApi.md#getimageframe) | **GET** /imaging/{name}/frames/{frameId} | 
*ImagingApi* | [**GetImageFrameProperties**](ImagingApi.md#getimageframeproperties) | **GET** /imaging/{name}/frames/{frameId}/properties | 
*ImagingApi* | [**GetImageFrameRange**](ImagingApi.md#getimageframerange) | **GET** /imaging/{name}/frames/range | 
*ImagingApi* | [**GetImageProperties**](ImagingApi.md#getimageproperties) | **GET** /imaging/{name}/properties | 
*ImagingApi* | [**GetImageSearchStatus**](ImagingApi.md#getimagesearchstatus) | **GET** /imaging/ai/imageSearch/{searchContextId}/status | 
*ImagingApi* | [**GetObjectBounds**](ImagingApi.md#getobjectbounds) | **GET** /imaging/ai/objectdetection/{name}/bounds | 
*ImagingApi* | [**GetSearchImage**](ImagingApi.md#getsearchimage) | **GET** /imaging/ai/imageSearch/{searchContextId}/image | 
*ImagingApi* | [**GetVisualObjectBounds**](ImagingApi.md#getvisualobjectbounds) | **GET** /imaging/ai/objectdetection/{name}/visualbounds | 
*ImagingApi* | [**GrayscaleImage**](ImagingApi.md#grayscaleimage) | **GET** /imaging/{name}/grayscale | 
*ImagingApi* | [**ModifyBmp**](ImagingApi.md#modifybmp) | **GET** /imaging/{name}/bmp | 
*ImagingApi* | [**ModifyEmf**](ImagingApi.md#modifyemf) | **GET** /imaging/{name}/emf | 
*ImagingApi* | [**ModifyGif**](ImagingApi.md#modifygif) | **GET** /imaging/{name}/gif | 
*ImagingApi* | [**ModifyJpeg**](ImagingApi.md#modifyjpeg) | **GET** /imaging/{name}/jpg | 
*ImagingApi* | [**ModifyJpeg2000**](ImagingApi.md#modifyjpeg2000) | **GET** /imaging/{name}/jpg2000 | 
*ImagingApi* | [**ModifyPsd**](ImagingApi.md#modifypsd) | **GET** /imaging/{name}/psd | 
*ImagingApi* | [**ModifySvg**](ImagingApi.md#modifysvg) | **GET** /imaging/{name}/svg | 
*ImagingApi* | [**ModifyTiff**](ImagingApi.md#modifytiff) | **GET** /imaging/{name}/tiff | 
*ImagingApi* | [**ModifyWebP**](ImagingApi.md#modifywebp) | **GET** /imaging/{name}/webp | 
*ImagingApi* | [**ModifyWmf**](ImagingApi.md#modifywmf) | **GET** /imaging/{name}/wmf | 
*ImagingApi* | [**MoveFile**](ImagingApi.md#movefile) | **PUT** /imaging/storage/file/move/{srcPath} | Move file
*ImagingApi* | [**MoveFolder**](ImagingApi.md#movefolder) | **PUT** /imaging/storage/folder/move/{srcPath} | Move folder
*ImagingApi* | [**ObjectExists**](ImagingApi.md#objectexists) | **GET** /imaging/storage/exist/{path} | Check if file or folder exists
*ImagingApi* | [**ResizeImage**](ImagingApi.md#resizeimage) | **GET** /imaging/{name}/resize | 
*ImagingApi* | [**RotateFlipImage**](ImagingApi.md#rotateflipimage) | **GET** /imaging/{name}/rotateflip | 
*ImagingApi* | [**StorageExists**](ImagingApi.md#storageexists) | **GET** /imaging/storage/{storageName}/exist | Check if storage exists
*ImagingApi* | [**UpdateImage**](ImagingApi.md#updateimage) | **GET** /imaging/{name}/updateImage | 
*ImagingApi* | [**UpdateImageFeatures**](ImagingApi.md#updateimagefeatures) | **PUT** /imaging/ai/imageSearch/{searchContextId}/features | 
*ImagingApi* | [**UpdateSearchImage**](ImagingApi.md#updatesearchimage) | **PUT** /imaging/ai/imageSearch/{searchContextId}/image | 
*ImagingApi* | [**UploadFile**](ImagingApi.md#uploadfile) | **PUT** /imaging/storage/file/{path} | Upload file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AvailableLabelsList](AvailableLabelsList.md)
 - [Model.BmpProperties](BmpProperties.md)
 - [Model.Complex](Complex.md)
 - [Model.DetectedObject](DetectedObject.md)
 - [Model.DetectedObjectList](DetectedObjectList.md)
 - [Model.DicomProperties](DicomProperties.md)
 - [Model.DiscUsage](DiscUsage.md)
 - [Model.DjvuProperties](DjvuProperties.md)
 - [Model.DngProperties](DngProperties.md)
 - [Model.EpsProperties](EpsProperties.md)
 - [Model.Error](Error.md)
 - [Model.ErrorDetails](ErrorDetails.md)
 - [Model.ExifData](ExifData.md)
 - [Model.FileVersions](FileVersions.md)
 - [Model.FilesList](FilesList.md)
 - [Model.FilesUploadResult](FilesUploadResult.md)
 - [Model.FilterPropertiesBase](FilterPropertiesBase.md)
 - [Model.GifProperties](GifProperties.md)
 - [Model.ImageDuplicates](ImageDuplicates.md)
 - [Model.ImageDuplicatesSet](ImageDuplicatesSet.md)
 - [Model.ImageFeatures](ImageFeatures.md)
 - [Model.ImagingResponse](ImagingResponse.md)
 - [Model.JfifData](JfifData.md)
 - [Model.Jpeg2000Properties](Jpeg2000Properties.md)
 - [Model.JpegProperties](JpegProperties.md)
 - [Model.ObjectExist](ObjectExist.md)
 - [Model.OdgMetadata](OdgMetadata.md)
 - [Model.OdgPage](OdgPage.md)
 - [Model.OdgProperties](OdgProperties.md)
 - [Model.PngProperties](PngProperties.md)
 - [Model.PsdProperties](PsdProperties.md)
 - [Model.Rectangle](Rectangle.md)
 - [Model.SearchContextStatus](SearchContextStatus.md)
 - [Model.SearchResult](SearchResult.md)
 - [Model.SearchResultsSet](SearchResultsSet.md)
 - [Model.StorageExist](StorageExist.md)
 - [Model.StorageFile](StorageFile.md)
 - [Model.SvgProperties](SvgProperties.md)
 - [Model.TiffFrame](TiffFrame.md)
 - [Model.TiffOptions](TiffOptions.md)
 - [Model.TiffProperties](TiffProperties.md)
 - [Model.WebPProperties](WebPProperties.md)
 - [Model.BigRectangularFilterProperties](BigRectangularFilterProperties.md)
 - [Model.BilateralSmoothingFilterProperties](BilateralSmoothingFilterProperties.md)
 - [Model.ConvolutionFilterProperties](ConvolutionFilterProperties.md)
 - [Model.DeconvolutionFilterProperties](DeconvolutionFilterProperties.md)
 - [Model.FileVersion](FileVersion.md)
 - [Model.JpegExifData](JpegExifData.md)
 - [Model.MedianFilterProperties](MedianFilterProperties.md)
 - [Model.SmallRectangularFilterProperties](SmallRectangularFilterProperties.md)
 - [Model.GaussWienerFilterProperties](GaussWienerFilterProperties.md)
 - [Model.GaussianBlurFilterProperties](GaussianBlurFilterProperties.md)
 - [Model.MotionWienerFilterProperties](MotionWienerFilterProperties.md)
 - [Model.SharpenFilterProperties](SharpenFilterProperties.md)

