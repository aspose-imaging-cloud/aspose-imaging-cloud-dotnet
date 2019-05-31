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
    var getSaveAsRequest =
        new GetImageSaveAsRequest("inputImage.png", "ExampleFolderNet");

    using (Stream convertedImage = imagingApi.GetImageSaveAs(getSaveAsRequest))
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
        var postSaveToStorageRequest =
            new PostImageSaveAsRequest(localInputImage, "jpg", "ExampleFolderNet/resultImage.jpg");

        imagingApi.PostImageSaveAs(postSaveToStorageRequest);

        // download saved image from storage
        using (Stream savedFile =
            imagingApi.DownloadFile(new DownloadFileRequest("ExampleFolderNet/resultImage.jpg")))
        {
            // process resulting image from storage
        }

        localInputImage.Seek(0, SeekOrigin.Begin);

        // convert image from request stream to JPEG and read it from resulting stream
        // please, set outPath parameter as null to return result in response stream instead of saving to storage
        var postSaveToStreamRequest =
            new PostImageSaveAsRequest(localInputImage, "jpg");

        using (Stream resultPostImageStream = 
            imagingApi.PostImageSaveAs(postSaveToStreamRequest))
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

### Imaging.AI - Compare two images
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// specify images for comparing (image ID is a path to image in storage)
var imageInStorage1 = @"WorkFolder\Image1.jpg";
var imageInStorage2 = @"WorkFolder\Image2.jpg";
  
// compare images
var response = imagingApi.PostSearchContextCompareImages(
    new PostSearchContextCompareImagesRequest(
    searchContextId, imageInStorage1, imageId2: imageInStorage2));
var similarity = response.Results[0].Similarity;
```

### Imaging.AI - Find similar images
```csharp
// optional parameters are base URL, API version and debug mode
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.PostSearchContextExtractImageFeatures(
    new PostSearchContextExtractImageFeaturesRequest(
    searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetSearchContextStatus(
    new GetSearchContextStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    
 
bool imageFromStorage = true;
 
SearchResultsSet results;
if (imageFromStorage)
{
    // use search image from storage
    var storageImageId = "searhImage.jpg";
    results = imagingApi.GetSearchContextFindSimilar(
        new GetSearchContextFindSimilarRequest(apiResponse.Id, 90, 5, null, storageImageId));
}
else
{
    // load search image as a stream
    using (FileStream imageStream = 
        new FileStream(@"D:\test\localInputImage.jpg", FileMode.Open, FileAccess.Read))
    {      
        results = imagingApi.GetSearchContextFindSimilar(
            new GetSearchContextFindSimilarRequest(apiResponse.Id, 90, 5, imageStream));
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
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.PostSearchContextExtractImageFeatures(
    new PostSearchContextExtractImageFeaturesRequest(
    searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetSearchContextStatus(
    new GetSearchContextStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    

// request finding duplicates
var response = imagingApi.GetSearchContextFindDuplicates(
    new GetSearchContextFindDuplicatesRequest(searchContextId, 90));
 
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
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.PostSearchContextExtractImageFeatures(
    new PostSearchContextExtractImageFeaturesRequest(
    searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetSearchContextStatus(
    new GetSearchContextStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    
 
var tag = "MyTag";
// load tag image as a stream
using (FileStream tagImageStream = 
    new FileStream(@"D:\test\tagImage.jpg", FileMode.Open, FileAccess.Read))
{       
    imagingApi.PostSearchContextAddTag(
        new PostSearchContextAddTagRequest(tagImageStream, searchContextId, tag));
}
 
// serialize search tags collection to JSON
var searchTags = JsonConvert.SerializeObject(new[] { tag });
 
// search images by tags
var response = imagingApi.PostSearchContextFindByTags(
    new PostSearchContextFindByTagsRequest(searchTags, searchContextId, 90, 10));
 
// process search results
foreach (var searchResult in response.Results)
{
    Console.WriteLine($"ImageName: {searchResult.ImageId}, Similarity: {searchResult.Similarity}");
}
```

### Imaging.AI - Delete search context
```csharp
// search context is stored in the storage, and in case if search context is not needed anymore it should be removed
imagingApi.DeleteSearchContext(new DeleteSearchContextRequest(searchContextId));
```

### Exception handling and error codes
```csharp
try
{
    imagingApi.DeleteSearchContext(new DeleteSearchContextRequest(searchContextId));
}
catch (ApiException ex) 
{
    Console.WriteLine(ex.ErrorCode);
    Console.WriteLine(ex.Message);
    // inspect ex.Error
}
```