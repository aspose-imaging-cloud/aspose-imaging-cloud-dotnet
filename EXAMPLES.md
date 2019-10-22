### Imaging - Save as: convert image from storage to another format
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSid");
try
{
    // upload local image to storage
    using (FileStream localInputImage = File.OpenRead("test.png"))
    {
        var uploadFileRequest = new UploadFileRequest("ExampleFolderNet/inputImage.png", localInputImage);
        FilesUploadResult result = imagingApi.UploadFile(uploadFileRequest);
        // inspect result.Errors list if there were any
        // inspect result.Uploaded list for uploaded file names
    }

    // convert image from storage to JPEG
    var saveAsRequest =
        new SaveImageAsRequest("inputImage.png", "ExampleFolderNet");

    using (Stream convertedImage = imagingApi.SaveImageAs(saveAsRequest))
    {
        // process resulting image
        // for example, save it to storage
        var uploadFileRequest =
            new UploadFileRequest("ExampleFolderNet/resultImage.jpg", convertedImage);
        FilesUploadResult result = imagingApi.UploadFile(uploadFileRequest);
        // inspect result.Errors list if there were any
        // inspect result.Uploaded list for uploaded file names
    }
}
finally
{
    // remove files from storage
    imagingApi.DeleteFile(new DeleteFileRequest("ExampleFolderNet/inputImage.png"));
    imagingApi.DeleteFile(new DeleteFileRequest("ExampleFolderNet/resultImage.jpg"));
}

// other Imaging requests typically follow the same principles regarding stream/storage relations
```

### Imaging - Save as: convert image from request stream to another format
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSid");
    
try
{
    // get local image stream
    using (FileStream localInputImage = File.OpenRead("test.png"))
    {
        // convert image from request stream to JPEG and save it to storage
        // please, use outPath parameter for saving the result to storage
        var saveAsToStorageRequest =
            new CreateSavedImageAsRequest(localInputImage, "jpg", "ExampleFolderNet/resultImage.jpg");

        imagingApi.CreateSavedImageAs(saveAsToStorageRequest);

        // download saved image from storage
        using (Stream savedFile =
            imagingApi.DownloadFile(new DownloadFileRequest("ExampleFolderNet/resultImage.jpg")))
        {
            // process resulting image from storage
        }

        localInputImage.Seek(0, SeekOrigin.Begin);

        // convert image from request stream to JPEG and read it from resulting stream
        // please, set outPath parameter as null to return result in response stream instead of saving to storage
        var saveAsToStreamRequest =
            new CreateSavedImageAsRequest(localInputImage, "jpg");

        using (Stream convertedImage = 
            imagingApi.CreateSavedImageAs(saveAsToStreamRequest))
        {
            // process resulting image from response stream
        }
    }
}
finally
{
    // remove file from storage
    imagingApi.DeleteFile(new DeleteFileRequest("ExampleFolderNet/resultImage.jpg"));
}

// other Imaging requests typically follow the same principles regarding stream/storage relations
```

### Imaging - Apply a filter to an image
```csharp
ImagingApi imagingApi = new ImagingApi("yourAppKey", "yourAppSID");

// set the filter properties
var filterProperties = new Filter("GaussianBlur", new GaussianBlurFilterProperties
{
    Radius = 2,
    Sigma = 2
});

// apply the filter to the image and obtain the result
var filteredImage = ImagingApi.FilterEffectImage(
    new FilterEffectImageRequest(name, format, "GaussianBlur", filter, folder, storage));
```

### Imaging.AI - Compare two images
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.CreateImageSearch(new CreateImageSearchRequest());
var searchContextId = apiResponse.Id;
 
// specify images for comparing (image ID is a path to image in storage)
var imageInStorage1 = @"WorkFolder\Image1.jpg";
var imageInStorage2 = @"WorkFolder\Image2.jpg";
  
// compare images
var response = imagingApi.CompareImages(
    new CompareImagesRequest(
    searchContextId, imageInStorage1, imageId2: imageInStorage2));
var similarity = response.Results[0].Similarity;
```

### Imaging.AI - Find similar images
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.CreateImageSearch(new CreateImageSearchRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.CreateImageFeatures(
    new CreateImageFeaturesRequest(
    searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetImageSearchStatus(
    new GetImageSearchStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    
 
bool imageFromStorage = true;
 
SearchResultsSet results;
if (imageFromStorage)
{
    // use search image from storage
    var storageImageId = "searhImage.jpg";
    results = imagingApi.FindSimilarImages(
        new FindSimilarImagesRequest(apiResponse.Id, 90, 5, null, storageImageId));
}
else
{
    // load search image as a stream
    using (FileStream imageStream = 
        new FileStream(@"D:\test\localInputImage.jpg", FileMode.Open, FileAccess.Read))
    {      
        results = imagingApi.FindSimilarImages(
            new FindSimilarImagesRequest(apiResponse.Id, 90, 5, imageStream));
    }
}
 
// process search results
foreach (var searchResult in results.Results)
{
   Console.WriteLine($"ImageName: {searchResult.ImageId}, Similarity: {searchResult.Similarity}");
}
```

### Imaging.AI - Find duplicate images
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.CreateImageSearch(new CreateImageSearchRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.CreateImageFeatures(
    new CreateImageFeaturesRequest(
    searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetImageSearchStatus(
    new GetImageSearchStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    

// request finding duplicates
var response = imagingApi.FindImageDuplicates(
    new FindImageDuplicatesRequest(searchContextId, 90));
 
// process duplicates search results
foreach (var duplicates in response.Duplicates)
{
    Console.WriteLine("Duplicates:");
    foreach (var duplicate in duplicates.DuplicateImages)
    { 
        Console.WriteLine(
           $"ImageName: {duplicate.ImageId}, Similarity: {duplicate.Similarity}");
    }
}
```

### Imaging.AI - Search images by tags
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.CreateImageSearch(new CreateImageSearchRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.CreateImageFeatures(
    new CreateImageFeaturesRequest(
    searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetImageSearchStatus(
    new GetImageSearchStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    
 
var tag = "MyTag";
// load tag image as a stream
using (FileStream tagImageStream = 
    new FileStream(@"D:\test\tagImage.jpg", FileMode.Open, FileAccess.Read))
{       
    imagingApi.CreateImageTag(
        new CreateImageTagRequest(tagImageStream, searchContextId, tag));
}
 
// serialize search tags collection to JSON
var searchTags = JsonConvert.SerializeObject(new[] { tag });
 
// search images by tags
var response = imagingApi.FindImagesByTags(
    new FindImagesByTagsRequest(searchTags, searchContextId, 90, 10));
 
// process search results
foreach (var searchResult in response.Results)
{
    Console.WriteLine($"ImageName: {searchResult.ImageId}, Similarity: {searchResult.Similarity}");
}
```

### Imaging.AI - Delete search context
```csharp
// search context is stored in the storage, and in case if search context is not needed anymore it should be removed
imagingApi.DeleteImageSearch(new DeleteImageSearchRequest(searchContextId));
```

### Exception handling and error codes
```csharp
try
{
    imagingApi.DeleteImageSearch(new DeleteImageSearchRequest(searchContextId));
}
catch (ApiException ex) 
{
    Console.WriteLine(ex.ErrorCode);
    Console.WriteLine(ex.Message);
    // inspect ex.Error
}
```