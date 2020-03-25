// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagingApi.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.Imaging.Cloud.Sdk.Client;
    using Aspose.Imaging.Cloud.Sdk.Client.Internal;
    using Aspose.Imaging.Cloud.Sdk.Client.Internal.RequestHandlers;
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// Aspose.Imaging Cloud API.
    /// </summary>
    public class ImagingApi
    {                 
        #region Fields

        /// <summary>
        /// The configuration
        /// </summary>
        public readonly Configuration Configuration;
        
        /// <summary>
        /// The API invoker
        /// </summary>
        private readonly ApiInvoker apiInvoker;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class for Aspose Cloud-hosted solution usage.
        /// </summary>
        /// <param name="appKey">
        /// The app key.
        /// </param>
        /// <param name="appSid">
        /// The app SID.
        /// </param>
        /// <param name="baseUrl">
        /// The base URL. Use <see cref="Configuration.DefaultBaseUrl"/> to set the default base URL.
        /// </param>
        /// <param name="apiVersion">
        /// The API version.
        /// </param>
        /// <param name="debug">
        /// If debug mode is enabled.
        /// </param>
        public ImagingApi(string appKey, string appSid, string baseUrl = Configuration.DefaultBaseUrl, 
            string apiVersion = Configuration.DefaultApiVersion, bool debug = false)
            : this(new Configuration
            {
                AppKey = appKey,
                AppSid = appSid,
                ApiBaseUrl = baseUrl,
                ApiVersion = apiVersion,
                DebugMode = debug,
                OnPremise = false
            })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class for on-premise solution with metered license usage.
        /// </summary>
        /// <param name="baseUrl">
        /// The base URL of your server.
        /// </param>
        /// <param name="apiVersion">
        /// The API version.
        /// </param>
        /// <param name="debug">
        /// If debug mode is enabled.
        /// </param>
        public ImagingApi(string baseUrl, string apiVersion = Configuration.DefaultApiVersion, bool debug = false)
            : this(new Configuration
            {
                ApiBaseUrl = baseUrl,
                ApiVersion = apiVersion,
                DebugMode = debug,
                OnPremise = true
            })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        private ImagingApi(Configuration configuration)
        {
            this.Configuration = configuration;
            var requestHandlers = new List<IRequestHandler>();
            if (!configuration.OnPremise)
            {
                requestHandlers.Add(new AuthRequestHandler(this.Configuration));
            }
            
            requestHandlers.Add(new DebugLogRequestHandler(this.Configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.Configuration);
        }

        #endregion
    
        #region Methods
        
        /// <summary>
        /// Add image and images features to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="AddSearchImageRequest" /></param>            
        public void AddSearchImage(AddSearchImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling AddSearchImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling AddSearchImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images). 
        /// </summary>
        /// <param name="request">Specific request.<see cref="AppendTiffRequest" /></param>            
        public void AppendTiff(AppendTiffRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AppendTiff");
            }

            // verify the required parameter 'appendFile' is set
            if (request.appendFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'appendFile' when calling AppendTiff");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/tiff/{name}/appendTiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "appendFile", request.appendFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Compare two images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CompareImagesRequest" /></param>
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet CompareImages(CompareImagesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling CompareImages");
            }

            // verify the required parameter 'imageId1' is set
            if (request.imageId1 == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId1' when calling CompareImages");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/compare";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId1", request.imageId1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId2", request.imageId2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (SearchResultsSet)SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Update parameters of existing TIFF image accordingly to fax parameters. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ConvertTiffToFaxRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ConvertTiffToFax(ConvertTiffToFaxRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ConvertTiffToFax");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/tiff/{name}/toFax";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CopyFileRequest" /></param>            
        public void CopyFile(CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/file/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CopyFolderRequest" /></param>            
        public void CopyFolder(CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Crop an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateCroppedImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateCroppedImage(CreateCroppedImageRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateCroppedImage");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling CreateCroppedImage");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling CreateCroppedImage");
            }

            // verify the required parameter 'width' is set
            if (request.width == null) 
            {
                throw new ApiException(400, "Missing required parameter 'width' when calling CreateCroppedImage");
            }

            // verify the required parameter 'height' is set
            if (request.height == null) 
            {
                throw new ApiException(400, "Missing required parameter 'height' when calling CreateCroppedImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/crop";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Deskew an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateDeskewedImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateDeskewedImage(CreateDeskewedImageRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateDeskewedImage");
            }

            // verify the required parameter 'resizeProportionally' is set
            if (request.resizeProportionally == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resizeProportionally' when calling CreateDeskewedImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/deskew";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resizeProportionally", request.resizeProportionally);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateFolderRequest" /></param>            
        public void CreateFolder(CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Grayscales an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateGrayscaledImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateGrayscaledImage(CreateGrayscaledImageRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateGrayscaledImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/grayscale";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Extract images features and add them to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateImageFeaturesRequest" /></param>            
        public void CreateImageFeatures(CreateImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling CreateImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imagesFolder", request.imagesFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Get separate frame from existing TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateImageFrameRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateImageFrame(CreateImageFrameRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateImageFrame");
            }

            // verify the required parameter 'frameId' is set
            if (request.frameId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'frameId' when calling CreateImageFrame");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/frames/{frameId}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "frameId", request.frameId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "saveOtherFrames", request.saveOtherFrames);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Create new search context. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateImageSearchRequest" /></param>
        /// <returns><see cref="SearchContextStatus"/></returns>            
        public SearchContextStatus CreateImageSearch(CreateImageSearchRequest request)
        {
            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/create";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "detector", request.detector);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "matchingAlgorithm", request.matchingAlgorithm);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (SearchContextStatus)SerializationHelper.Deserialize<SearchContextStatus>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Add tag and reference image to search context. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateImageTagRequest" /></param>            
        public void CreateImageTag(CreateImageTagRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateImageTag");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling CreateImageTag");
            }

            // verify the required parameter 'tagName' is set
            if (request.tagName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tagName' when calling CreateImageTag");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/addTag";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "tagName", request.tagName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Update parameters of BMP image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedBmpRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedBmp(CreateModifiedBmpRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedBmp");
            }

            // verify the required parameter 'bitsPerPixel' is set
            if (request.bitsPerPixel == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitsPerPixel' when calling CreateModifiedBmp");
            }

            // verify the required parameter 'horizontalResolution' is set
            if (request.horizontalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'horizontalResolution' when calling CreateModifiedBmp");
            }

            // verify the required parameter 'verticalResolution' is set
            if (request.verticalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'verticalResolution' when calling CreateModifiedBmp");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/bmp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitsPerPixel", request.bitsPerPixel);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Process existing EMF imaging using given parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedEmfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedEmf(CreateModifiedEmfRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedEmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling CreateModifiedEmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling CreateModifiedEmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling CreateModifiedEmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling CreateModifiedEmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling CreateModifiedEmf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/emf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of GIF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedGifRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedGif(CreateModifiedGifRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedGif");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/gif";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColorIndex", request.backgroundColorIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "colorResolution", request.colorResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "hasTrailer", request.hasTrailer);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "interlaced", request.interlaced);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isPaletteSorted", request.isPaletteSorted);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pixelAspectRatio", request.pixelAspectRatio);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of JPEG image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedJpegRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedJpeg(CreateModifiedJpegRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedJpeg");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/jpg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionType", request.compressionType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of JPEG2000 image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedJpeg2000Request" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedJpeg2000(CreateModifiedJpeg2000Request request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedJpeg2000");
            }

            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling CreateModifiedJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/jpg2000";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "comment", request.comment);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "codec", request.codec);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of PSD image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedPsdRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedPsd(CreateModifiedPsdRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedPsd");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/psd";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "channelsCount", request.channelsCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionMethod", request.compressionMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of SVG image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedSvgRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedSvg(CreateModifiedSvgRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedSvg");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/svg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "colorType", request.colorType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textAsShapes", request.textAsShapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedTiffRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedTiff(CreateModifiedTiffRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling CreateModifiedTiff");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of WEBP image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedWebPRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedWebP(CreateModifiedWebPRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling CreateModifiedWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling CreateModifiedWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling CreateModifiedWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling CreateModifiedWebP");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/webp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "lossLess", request.lossLess);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "animLoopCount", request.animLoopCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "animBackgroundColor", request.animBackgroundColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Process existing WMF image using given parameters. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateModifiedWmfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateModifiedWmf(CreateModifiedWmfRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateModifiedWmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling CreateModifiedWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling CreateModifiedWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling CreateModifiedWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling CreateModifiedWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling CreateModifiedWmf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/wmf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Resize an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateResizedImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateResizedImage(CreateResizedImageRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateResizedImage");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling CreateResizedImage");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling CreateResizedImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Rotate and/or flip an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateRotateFlippedImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateRotateFlippedImage(CreateRotateFlippedImageRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateRotateFlippedImage");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling CreateRotateFlippedImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export existing image to another format. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.              
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateSavedImageAsRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateSavedImageAs(CreateSavedImageAsRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateSavedImageAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling CreateSavedImageAs");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Perform scaling, cropping and flipping of an image in a single request. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateUpdatedImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateUpdatedImage(CreateUpdatedImageRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling CreateUpdatedImage");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling CreateUpdatedImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/updateImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Extract images features from web page and add them to search context 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateWebSiteImageFeaturesRequest" /></param>            
        public void CreateWebSiteImageFeatures(CreateWebSiteImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling CreateWebSiteImageFeatures");
            }

            // verify the required parameter 'imagesSource' is set
            if (request.imagesSource == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imagesSource' when calling CreateWebSiteImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features/web";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imagesSource", request.imagesSource);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Crop an existing image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CropImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CropImage(CropImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CropImage");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling CropImage");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling CropImage");
            }

            // verify the required parameter 'width' is set
            if (request.width == null) 
            {
                throw new ApiException(400, "Missing required parameter 'width' when calling CropImage");
            }

            // verify the required parameter 'height' is set
            if (request.height == null) 
            {
                throw new ApiException(400, "Missing required parameter 'height' when calling CropImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/crop";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteFileRequest" /></param>            
        public void DeleteFile(DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteFolderRequest" /></param>            
        public void DeleteFolder(DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Deletes image features from search context. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteImageFeaturesRequest" /></param>            
        public void DeleteImageFeatures(DeleteImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling DeleteImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling DeleteImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Deletes the search context. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteImageSearchRequest" /></param>            
        public void DeleteImageSearch(DeleteImageSearchRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling DeleteImageSearch");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Delete image and images features from search context 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteSearchImageRequest" /></param>            
        public void DeleteSearchImage(DeleteSearchImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling DeleteSearchImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling DeleteSearchImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Deskew an existing image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeskewImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeskewImage(DeskewImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeskewImage");
            }

            // verify the required parameter 'resizeProportionally' is set
            if (request.resizeProportionally == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resizeProportionally' when calling DeskewImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/deskew";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resizeProportionally", request.resizeProportionally);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Extract features from image without adding to search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ExtractImageFeaturesRequest" /></param>
        /// <returns><see cref="ImageFeatures"/></returns>            
        public ImageFeatures ExtractImageFeatures(ExtractImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling ExtractImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling ExtractImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image2features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImageFeatures)SerializationHelper.Deserialize<ImageFeatures>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get separate frame properties of existing TIFF image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ExtractImageFramePropertiesRequest" /></param>
        /// <returns><see cref="ImagingResponse"/></returns>            
        public ImagingResponse ExtractImageFrameProperties(ExtractImageFramePropertiesRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling ExtractImageFrameProperties");
            }

            // verify the required parameter 'frameId' is set
            if (request.frameId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'frameId' when calling ExtractImageFrameProperties");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/frames/{frameId}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "frameId", request.frameId);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImagingResponse)SerializationHelper.Deserialize<ImagingResponse>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get properties of an image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ExtractImagePropertiesRequest" /></param>
        /// <returns><see cref="ImagingResponse"/></returns>            
        public ImagingResponse ExtractImageProperties(ExtractImagePropertiesRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling ExtractImageProperties");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImagingResponse)SerializationHelper.Deserialize<ImagingResponse>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Apply filtering effects to an existing image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="FilterEffectImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream FilterEffectImage(FilterEffectImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling FilterEffectImage");
            }

            // verify the required parameter 'filterType' is set
            if (request.filterType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filterType' when calling FilterEffectImage");
            }

            // verify the required parameter 'filterProperties' is set
            if (request.filterProperties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filterProperties' when calling FilterEffectImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/filterEffect";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filterType", request.filterType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var postBody = SerializationHelper.Serialize(request.filterProperties);
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Find images duplicates. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="FindImageDuplicatesRequest" /></param>
        /// <returns><see cref="ImageDuplicatesSet"/></returns>            
        public ImageDuplicatesSet FindImageDuplicates(FindImageDuplicatesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling FindImageDuplicates");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling FindImageDuplicates");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findDuplicates";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImageDuplicatesSet)SerializationHelper.Deserialize<ImageDuplicatesSet>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Find images by tags. Tags JSON string is passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="FindImagesByTagsRequest" /></param>
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet FindImagesByTags(FindImagesByTagsRequest request)
        {
            // verify the required parameter 'tags' is set
            if (request.tags == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tags' when calling FindImagesByTags");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling FindImagesByTags");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling FindImagesByTags");
            }

            // verify the required parameter 'maxCount' is set
            if (request.maxCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'maxCount' when calling FindImagesByTags");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findByTags";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "maxCount", request.maxCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.tags != null) 
            {
                formParams.Add("tags", request.tags);
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (SearchResultsSet)SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Find similar images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="FindSimilarImagesRequest" /></param>
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet FindSimilarImages(FindSimilarImagesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling FindSimilarImages");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling FindSimilarImages");
            }

            // verify the required parameter 'maxCount' is set
            if (request.maxCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'maxCount' when calling FindSimilarImages");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findSimilar";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "maxCount", request.maxCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (SearchResultsSet)SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage"/></returns>            
        public DiscUsage GetDiscUsage(GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/disc";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (DiscUsage)SerializationHelper.Deserialize<DiscUsage>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions"/></returns>            
        public FileVersions GetFileVersions(GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/version/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (FileVersions)SerializationHelper.Deserialize<FileVersions>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>            
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (FilesList)SerializationHelper.Deserialize<FilesList>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Gets image features from search context. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetImageFeaturesRequest" /></param>
        /// <returns><see cref="ImageFeatures"/></returns>            
        public ImageFeatures GetImageFeatures(GetImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling GetImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImageFeatures)SerializationHelper.Deserialize<ImageFeatures>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get separate frame from existing TIFF image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetImageFrameRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageFrame(GetImageFrameRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageFrame");
            }

            // verify the required parameter 'frameId' is set
            if (request.frameId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'frameId' when calling GetImageFrame");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/frames/{frameId}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "frameId", request.frameId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "saveOtherFrames", request.saveOtherFrames);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Get separate frame properties of existing TIFF image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetImageFramePropertiesRequest" /></param>
        /// <returns><see cref="ImagingResponse"/></returns>            
        public ImagingResponse GetImageFrameProperties(GetImageFramePropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageFrameProperties");
            }

            // verify the required parameter 'frameId' is set
            if (request.frameId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'frameId' when calling GetImageFrameProperties");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/frames/{frameId}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "frameId", request.frameId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImagingResponse)SerializationHelper.Deserialize<ImagingResponse>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get properties of an image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetImagePropertiesRequest" /></param>
        /// <returns><see cref="ImagingResponse"/></returns>            
        public ImagingResponse GetImageProperties(GetImagePropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageProperties");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ImagingResponse)SerializationHelper.Deserialize<ImagingResponse>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Gets the search context status. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetImageSearchStatusRequest" /></param>
        /// <returns><see cref="SearchContextStatus"/></returns>            
        public SearchContextStatus GetImageSearchStatus(GetImageSearchStatusRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetImageSearchStatus");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/status";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (SearchContextStatus)SerializationHelper.Deserialize<SearchContextStatus>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get image from search context 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetSearchImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetSearchImage(GetSearchImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling GetSearchImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Grayscale an existing image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GrayscaleImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GrayscaleImage(GrayscaleImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GrayscaleImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/grayscale";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing BMP image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyBmpRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyBmp(ModifyBmpRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyBmp");
            }

            // verify the required parameter 'bitsPerPixel' is set
            if (request.bitsPerPixel == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitsPerPixel' when calling ModifyBmp");
            }

            // verify the required parameter 'horizontalResolution' is set
            if (request.horizontalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'horizontalResolution' when calling ModifyBmp");
            }

            // verify the required parameter 'verticalResolution' is set
            if (request.verticalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'verticalResolution' when calling ModifyBmp");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/bmp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitsPerPixel", request.bitsPerPixel);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Process existing EMF imaging using given parameters. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyEmfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyEmf(ModifyEmfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyEmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling ModifyEmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling ModifyEmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling ModifyEmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling ModifyEmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling ModifyEmf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/emf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing GIF image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyGifRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyGif(ModifyGifRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyGif");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/gif";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColorIndex", request.backgroundColorIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "colorResolution", request.colorResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "hasTrailer", request.hasTrailer);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "interlaced", request.interlaced);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isPaletteSorted", request.isPaletteSorted);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pixelAspectRatio", request.pixelAspectRatio);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing JPEG image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyJpegRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyJpeg(ModifyJpegRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyJpeg");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/jpg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionType", request.compressionType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing JPEG2000 image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyJpeg2000Request" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyJpeg2000(ModifyJpeg2000Request request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyJpeg2000");
            }

            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling ModifyJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/jpg2000";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "comment", request.comment);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "codec", request.codec);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing PSD image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyPsdRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyPsd(ModifyPsdRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyPsd");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/psd";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "channelsCount", request.channelsCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionMethod", request.compressionMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing SVG image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifySvgRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifySvg(ModifySvgRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifySvg");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/svg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "colorType", request.colorType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textAsShapes", request.textAsShapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing TIFF image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyTiffRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyTiff(ModifyTiffRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling ModifyTiff");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update parameters of existing WEBP image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyWebPRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyWebP(ModifyWebPRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling ModifyWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling ModifyWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling ModifyWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling ModifyWebP");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/webp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "lossLess", request.lossLess);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "animLoopCount", request.animLoopCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "animBackgroundColor", request.animBackgroundColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Process existing WMF image using given parameters. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ModifyWmfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ModifyWmf(ModifyWmfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ModifyWmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling ModifyWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling ModifyWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling ModifyWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling ModifyWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling ModifyWmf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/wmf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="MoveFileRequest" /></param>            
        public void MoveFile(MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/file/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="MoveFolderRequest" /></param>            
        public void MoveFolder(MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/folder/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist"/></returns>            
        public ObjectExist ObjectExists(ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/exist/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ObjectExist)SerializationHelper.Deserialize<ObjectExist>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Resize an existing image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ResizeImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ResizeImage(ResizeImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ResizeImage");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling ResizeImage");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling ResizeImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Rotate and/or flip an existing image. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="RotateFlipImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RotateFlipImage(RotateFlipImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RotateFlipImage");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling RotateFlipImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export existing image to another format. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="SaveImageAsRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream SaveImageAs(SaveImageAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveImageAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling SaveImageAs");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Specific request.<see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist"/></returns>            
        public StorageExist StorageExists(StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/{storageName}/exist";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (StorageExist)SerializationHelper.Deserialize<StorageExist>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Perform scaling, cropping and flipping of an existing image in a single request. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="UpdateImageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream UpdateImage(UpdateImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateImage");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling UpdateImage");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling UpdateImage");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling UpdateImage");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling UpdateImage");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling UpdateImage");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling UpdateImage");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling UpdateImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/{name}/updateImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Update images features in search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="UpdateImageFeaturesRequest" /></param>            
        public void UpdateImageFeatures(UpdateImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling UpdateImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling UpdateImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Update image and images features in search context. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="UpdateSearchImageRequest" /></param>            
        public void UpdateSearchImage(UpdateSearchImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling UpdateSearchImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling UpdateSearchImage");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>            
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/imaging/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (FilesUploadResult)SerializationHelper.Deserialize<FilesUploadResult>(StreamHelper.ToString(response));
        }
        
        #endregion
    }
}
