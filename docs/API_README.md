<a name="documentation-for-api-endpoints"></a>
## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ImagingApi* | [**AddSearchImage**](ImagingApi.md#addsearchimage) | **POST** /imaging/ai/imageSearch/{searchContextId}/image | Add image and images features to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**AppendTiff**](ImagingApi.md#appendtiff) | **POST** /imaging/tiff/{name}/appendTiff | Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images).
*ImagingApi* | [**CompareImages**](ImagingApi.md#compareimages) | **POST** /imaging/ai/imageSearch/{searchContextId}/compare | Compare two images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**ConvertImage**](ImagingApi.md#convertimage) | **GET** /imaging/{name}/convert | Convert existing image to another format.
*ImagingApi* | [**ConvertTiffToFax**](ImagingApi.md#converttifftofax) | **GET** /imaging/tiff/{name}/toFax | Update parameters of existing TIFF image accordingly to fax parameters.
*ImagingApi* | [**CopyFile**](ImagingApi.md#copyfile) | **PUT** /imaging/storage/file/copy/{srcPath} | Copy file
*ImagingApi* | [**CopyFolder**](ImagingApi.md#copyfolder) | **PUT** /imaging/storage/folder/copy/{srcPath} | Copy folder
*ImagingApi* | [**CreateConvertedImage**](ImagingApi.md#createconvertedimage) | **POST** /imaging/convert | Convert existing image to another format. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.             
*ImagingApi* | [**CreateCroppedImage**](ImagingApi.md#createcroppedimage) | **POST** /imaging/crop | Crop an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateDeskewedImage**](ImagingApi.md#createdeskewedimage) | **POST** /imaging/deskew | Deskew an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateFaxTiff**](ImagingApi.md#createfaxtiff) | **POST** /imaging/tiff/toFax | Update parameters of TIFF image accordingly to fax parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateFolder**](ImagingApi.md#createfolder) | **PUT** /imaging/storage/folder/{path} | Create the folder
*ImagingApi* | [**CreateGrayscaledImage**](ImagingApi.md#creategrayscaledimage) | **POST** /imaging/grayscale | Grayscales an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateImageFeatures**](ImagingApi.md#createimagefeatures) | **POST** /imaging/ai/imageSearch/{searchContextId}/features | Extract images features and add them to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateImageFrame**](ImagingApi.md#createimageframe) | **POST** /imaging/frames/{frameId} | Get separate frame from existing image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateImageFrameRange**](ImagingApi.md#createimageframerange) | **POST** /imaging/frames/range | Get frames range from existing image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateImageSearch**](ImagingApi.md#createimagesearch) | **POST** /imaging/ai/imageSearch/create | Create new search context.
*ImagingApi* | [**CreateImageTag**](ImagingApi.md#createimagetag) | **POST** /imaging/ai/imageSearch/{searchContextId}/addTag | Add tag and reference image to search context. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedBmp**](ImagingApi.md#createmodifiedbmp) | **POST** /imaging/bmp | Update parameters of BMP image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedEmf**](ImagingApi.md#createmodifiedemf) | **POST** /imaging/emf | Process existing EMF imaging using given parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedGif**](ImagingApi.md#createmodifiedgif) | **POST** /imaging/gif | Update parameters of GIF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedJpeg**](ImagingApi.md#createmodifiedjpeg) | **POST** /imaging/jpg | Update parameters of JPEG image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedJpeg2000**](ImagingApi.md#createmodifiedjpeg2000) | **POST** /imaging/jpg2000 | Update parameters of JPEG2000 image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedPsd**](ImagingApi.md#createmodifiedpsd) | **POST** /imaging/psd | Update parameters of PSD image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedSvg**](ImagingApi.md#createmodifiedsvg) | **POST** /imaging/svg | Update parameters of SVG image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedTiff**](ImagingApi.md#createmodifiedtiff) | **POST** /imaging/tiff | Update parameters of TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedWebP**](ImagingApi.md#createmodifiedwebp) | **POST** /imaging/webp | Update parameters of WEBP image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateModifiedWmf**](ImagingApi.md#createmodifiedwmf) | **POST** /imaging/wmf | Process existing WMF image using given parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateObjectBounds**](ImagingApi.md#createobjectbounds) | **POST** /imaging/ai/objectdetection/bounds | Detects objects bounds. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateResizedImage**](ImagingApi.md#createresizedimage) | **POST** /imaging/resize | Resize an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateRotateFlippedImage**](ImagingApi.md#createrotateflippedimage) | **POST** /imaging/rotateflip | Rotate and/or flip an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateSavedImageAs**](ImagingApi.md#createsavedimageas) | **POST** /imaging/saveAs | Export existing image to another format. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.             
*ImagingApi* | [**CreateUpdatedImage**](ImagingApi.md#createupdatedimage) | **POST** /imaging/updateImage | Perform scaling, cropping and flipping of an image in a single request. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**CreateVisualObjectBounds**](ImagingApi.md#createvisualobjectbounds) | **POST** /imaging/ai/objectdetection/visualbounds | Detects objects bounds and draw them on the original image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream
*ImagingApi* | [**CreateWebSiteImageFeatures**](ImagingApi.md#createwebsiteimagefeatures) | **POST** /imaging/ai/imageSearch/{searchContextId}/features/web | Extract images features from web page and add them to search context
*ImagingApi* | [**CropImage**](ImagingApi.md#cropimage) | **GET** /imaging/{name}/crop | Crop an existing image.
*ImagingApi* | [**DeleteFile**](ImagingApi.md#deletefile) | **DELETE** /imaging/storage/file/{path} | Delete file
*ImagingApi* | [**DeleteFolder**](ImagingApi.md#deletefolder) | **DELETE** /imaging/storage/folder/{path} | Delete folder
*ImagingApi* | [**DeleteImageFeatures**](ImagingApi.md#deleteimagefeatures) | **DELETE** /imaging/ai/imageSearch/{searchContextId}/features | Deletes image features from search context.
*ImagingApi* | [**DeleteImageSearch**](ImagingApi.md#deleteimagesearch) | **DELETE** /imaging/ai/imageSearch/{searchContextId} | Deletes the search context.
*ImagingApi* | [**DeleteSearchImage**](ImagingApi.md#deletesearchimage) | **DELETE** /imaging/ai/imageSearch/{searchContextId}/image | Delete image and images features from search context
*ImagingApi* | [**DeskewImage**](ImagingApi.md#deskewimage) | **GET** /imaging/{name}/deskew | Deskew an existing image.
*ImagingApi* | [**DownloadFile**](ImagingApi.md#downloadfile) | **GET** /imaging/storage/file/{path} | Download file
*ImagingApi* | [**ExtractImageFeatures**](ImagingApi.md#extractimagefeatures) | **GET** /imaging/ai/imageSearch/{searchContextId}/image2features | Extract features from image without adding to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**ExtractImageFrameProperties**](ImagingApi.md#extractimageframeproperties) | **POST** /imaging/frames/{frameId}/properties | Get separate frame properties of existing image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**ExtractImageProperties**](ImagingApi.md#extractimageproperties) | **POST** /imaging/properties | Get properties of an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**FilterEffectImage**](ImagingApi.md#filtereffectimage) | **PUT** /imaging/{name}/filterEffect | Apply filtering effects to an existing image.
*ImagingApi* | [**FindImageDuplicates**](ImagingApi.md#findimageduplicates) | **GET** /imaging/ai/imageSearch/{searchContextId}/findDuplicates | Find images duplicates.
*ImagingApi* | [**FindImagesByTags**](ImagingApi.md#findimagesbytags) | **POST** /imaging/ai/imageSearch/{searchContextId}/findByTags | Find images by tags. Tags JSON string is passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**FindSimilarImages**](ImagingApi.md#findsimilarimages) | **GET** /imaging/ai/imageSearch/{searchContextId}/findSimilar | Find similar images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**GetAvailableLabels**](ImagingApi.md#getavailablelabels) | **GET** /imaging/ai/objectdetection/availablelabels/{method} | Detects objects bounds and draw them on the original image
*ImagingApi* | [**GetDiscUsage**](ImagingApi.md#getdiscusage) | **GET** /imaging/storage/disc | Get disc usage
*ImagingApi* | [**GetFileVersions**](ImagingApi.md#getfileversions) | **GET** /imaging/storage/version/{path} | Get file versions
*ImagingApi* | [**GetFilesList**](ImagingApi.md#getfileslist) | **GET** /imaging/storage/folder/{path} | Get all files and folders within a folder
*ImagingApi* | [**GetImageFeatures**](ImagingApi.md#getimagefeatures) | **GET** /imaging/ai/imageSearch/{searchContextId}/features | Gets image features from search context.
*ImagingApi* | [**GetImageFrame**](ImagingApi.md#getimageframe) | **GET** /imaging/{name}/frames/{frameId} | Get separate frame from existing image.
*ImagingApi* | [**GetImageFrameProperties**](ImagingApi.md#getimageframeproperties) | **GET** /imaging/{name}/frames/{frameId}/properties | Get separate frame properties of existing image.
*ImagingApi* | [**GetImageFrameRange**](ImagingApi.md#getimageframerange) | **GET** /imaging/{name}/frames/range | Get frames range from existing image.
*ImagingApi* | [**GetImageProperties**](ImagingApi.md#getimageproperties) | **GET** /imaging/{name}/properties | Get properties of an image.
*ImagingApi* | [**GetImageSearchStatus**](ImagingApi.md#getimagesearchstatus) | **GET** /imaging/ai/imageSearch/{searchContextId}/status | Gets the search context status.
*ImagingApi* | [**GetObjectBounds**](ImagingApi.md#getobjectbounds) | **GET** /imaging/ai/objectdetection/{name}/bounds | Detects objects' bounds
*ImagingApi* | [**GetSearchImage**](ImagingApi.md#getsearchimage) | **GET** /imaging/ai/imageSearch/{searchContextId}/image | Get image from search context
*ImagingApi* | [**GetVisualObjectBounds**](ImagingApi.md#getvisualobjectbounds) | **GET** /imaging/ai/objectdetection/{name}/visualbounds | Detects objects bounds and draw them on the original image
*ImagingApi* | [**GrayscaleImage**](ImagingApi.md#grayscaleimage) | **GET** /imaging/{name}/grayscale | Grayscale an existing image.
*ImagingApi* | [**ModifyBmp**](ImagingApi.md#modifybmp) | **GET** /imaging/{name}/bmp | Update parameters of existing BMP image.
*ImagingApi* | [**ModifyEmf**](ImagingApi.md#modifyemf) | **GET** /imaging/{name}/emf | Process existing EMF imaging using given parameters.
*ImagingApi* | [**ModifyGif**](ImagingApi.md#modifygif) | **GET** /imaging/{name}/gif | Update parameters of existing GIF image.
*ImagingApi* | [**ModifyJpeg**](ImagingApi.md#modifyjpeg) | **GET** /imaging/{name}/jpg | Update parameters of existing JPEG image.
*ImagingApi* | [**ModifyJpeg2000**](ImagingApi.md#modifyjpeg2000) | **GET** /imaging/{name}/jpg2000 | Update parameters of existing JPEG2000 image.
*ImagingApi* | [**ModifyPsd**](ImagingApi.md#modifypsd) | **GET** /imaging/{name}/psd | Update parameters of existing PSD image.
*ImagingApi* | [**ModifySvg**](ImagingApi.md#modifysvg) | **GET** /imaging/{name}/svg | Update parameters of existing SVG image.
*ImagingApi* | [**ModifyTiff**](ImagingApi.md#modifytiff) | **GET** /imaging/{name}/tiff | Update parameters of existing TIFF image.
*ImagingApi* | [**ModifyWebP**](ImagingApi.md#modifywebp) | **GET** /imaging/{name}/webp | Update parameters of existing WEBP image.
*ImagingApi* | [**ModifyWmf**](ImagingApi.md#modifywmf) | **GET** /imaging/{name}/wmf | Process existing WMF image using given parameters.
*ImagingApi* | [**MoveFile**](ImagingApi.md#movefile) | **PUT** /imaging/storage/file/move/{srcPath} | Move file
*ImagingApi* | [**MoveFolder**](ImagingApi.md#movefolder) | **PUT** /imaging/storage/folder/move/{srcPath} | Move folder
*ImagingApi* | [**ObjectExists**](ImagingApi.md#objectexists) | **GET** /imaging/storage/exist/{path} | Check if file or folder exists
*ImagingApi* | [**ResizeImage**](ImagingApi.md#resizeimage) | **GET** /imaging/{name}/resize | Resize an existing image.
*ImagingApi* | [**RotateFlipImage**](ImagingApi.md#rotateflipimage) | **GET** /imaging/{name}/rotateflip | Rotate and/or flip an existing image.
*ImagingApi* | [**SaveImageAs**](ImagingApi.md#saveimageas) | **GET** /imaging/{name}/saveAs | Export existing image to another format.
*ImagingApi* | [**StorageExists**](ImagingApi.md#storageexists) | **GET** /imaging/storage/{storageName}/exist | Check if storage exists
*ImagingApi* | [**UpdateImage**](ImagingApi.md#updateimage) | **GET** /imaging/{name}/updateImage | Perform scaling, cropping and flipping of an existing image in a single request.
*ImagingApi* | [**UpdateImageFeatures**](ImagingApi.md#updateimagefeatures) | **PUT** /imaging/ai/imageSearch/{searchContextId}/features | Update images features in search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**UpdateSearchImage**](ImagingApi.md#updatesearchimage) | **PUT** /imaging/ai/imageSearch/{searchContextId}/image | Update image and images features in search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
*ImagingApi* | [**UploadFile**](ImagingApi.md#uploadfile) | **PUT** /imaging/storage/file/{path} | Upload file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AvailableLabelsList](AvailableLabelsList.md)
 - [Model.BmpProperties](BmpProperties.md)
 - [Model.DetectedObject](DetectedObject.md)
 - [Model.DetectedObjectList](DetectedObjectList.md)
 - [Model.DicomProperties](DicomProperties.md)
 - [Model.DiscUsage](DiscUsage.md)
 - [Model.DjvuProperties](DjvuProperties.md)
 - [Model.DngProperties](DngProperties.md)
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

