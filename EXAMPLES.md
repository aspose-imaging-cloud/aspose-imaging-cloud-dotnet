### Imaging - Convert to another format (other operations are similar to use)
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

// another Imaging requests typically follow the same principles
```

### Imaging.AI - Compare two images
```csharp
// optional parameters are base URL, API version, authentication type and debug mode
// default base URL is https://api.aspose.cloud/
// default API version is v2
// default authentication type is OAuth2.0
// default debug mode is false
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// specify images for comparing (image ID is a path to image in storage)
var imageInStorage1 = @"WorkFolder\Image1.jpg";
var imageInStorage2 = @"WorkFolder\Image2.jpg";
  
// compare images
var response = imagingApi.PostSearchContextCompareImages(
    new PostSearchContextCompareImagesRequest(searchContextId, imageInStorage1, imageId2: imageInStorage2));
var similarity = response.Results[0].Similarity;
```

### Imaging.AI - Find similar images
```csharp
// optional parameters are base URL, API version, authentication type and debug mode
// default base URL is https://api.aspose.cloud/
// default API version is v2
// default authentication type is OAuth2.0
// default debug mode is false
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.PostSearchContextExtractImageFeatures(
    new PostSearchContextExtractImageFeaturesRequest(searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(searchContextId)).SearchStatus != "Idle")
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
    using (FileStream imageStream = new FileStream(@"D:\test\localInputImage.jpg", FileMode.Open, FileAccess.Read))
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
// optional parameters are base URL, API version, authentication type and debug mode
// default base URL is https://api.aspose.cloud/
// default API version is v2
// default authentication type is OAuth2.0
// default debug mode is false
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.PostSearchContextExtractImageFeatures(
    new PostSearchContextExtractImageFeaturesRequest(searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(searchContextId)).SearchStatus != "Idle")
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
// optional parameters are base URL, API version, authentication type and debug mode
// default base URL is https://api.aspose.cloud/
// default API version is v2
// default authentication type is OAuth2.0
// default debug mode is false
var imagingApi = new ImagingApi("yourAppKey", "yourAppSID");
 
// create search context or use existing search context ID if search context was created earlier
var apiResponse = imagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest());
var searchContextId = apiResponse.Id;
 
// extract images features if it was not done before
imagingApi.PostSearchContextExtractImageFeatures(
    new PostSearchContextExtractImageFeaturesRequest(searchContextId, imageId: null, imagesFolder: "WorkFolder"))
 
// wait 'till image features extraction is completed
while (imagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(searchContextId)).SearchStatus != "Idle")
{
    Thread.Sleep(TimeSpan.FromSeconds(10));
}    
 
var tag = "MyTag";
// load tag image as a stream
using (FileStream tagImageStream = new FileStream(@"D:\test\tagImage.jpg", FileMode.Open, FileAccess.Read))
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