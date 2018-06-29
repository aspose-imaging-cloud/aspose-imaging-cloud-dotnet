// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagingApi.cs">
//   Copyright (c) 2018 Aspose Pty Ltd.
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

namespace Aspose.Imaging.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.Imaging.Cloud.Sdk.Client;
    using Aspose.Imaging.Cloud.Sdk.Client.Internal;
    using Aspose.Imaging.Cloud.Sdk.Client.Internal.RequestHandlers;
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// Aspose.Imaging for Cloud API.
    /// </summary>
    public class ImagingApi
    {                 
        #region Fields

        /// <summary>
        /// The API invoker
        /// </summary>
        private readonly ApiInvoker apiInvoker;

        /// <summary>
        /// The configuration
        /// </summary>
        private readonly Configuration configuration;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
        /// </summary>
        /// <param name="appKey">
        /// The app key.
        /// </param>
        /// <param name="appSid">
        /// The app SID.
        /// </param>
        public ImagingApi(string appKey, string appSid)
            : this(new Configuration { AppKey = appKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
        /// </summary>
        /// <param name="appKey">
        /// The app key.
        /// </param>
        /// <param name="appSid">
        /// The app SID.
        /// </param>
        /// <param name="baseUrl">
        /// The base URL.
        /// </param>
        public ImagingApi(string appKey, string appSid, string baseUrl)
            : this(new Configuration { AppKey = appKey, AppSid = appSid, ApiBaseUrl = baseUrl })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
        /// </summary>
        /// <param name="appKey">
        /// The app key.
        /// </param>
        /// <param name="appSid">
        /// The app SID.
        /// </param>
        /// <param name="baseUrl">
        /// The base URL.
        /// </param>
        /// <param name="apiVersion">
        /// API version.
        /// </param>
        public ImagingApi(string appKey, string appSid, string baseUrl, string apiVersion)
            : this(new Configuration { AppKey = appKey, AppSid = appSid, ApiBaseUrl = baseUrl, ApiVersion = apiVersion })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
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
        /// API version.
        /// </param>
        /// <param name="debug">
        /// If debug mode is enabled.
        /// </param>
        public ImagingApi(string appKey, string appSid, string baseUrl, string apiVersion, bool debug)
            : this(new Configuration { AppKey = appKey, AppSid = appSid, ApiBaseUrl = baseUrl, ApiVersion = apiVersion, DebugMode = debug })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
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
        /// API version.
        /// </param>
        /// <param name="authType">
        /// Authentication type.
        /// </param>
        /// <param name="debug">
        /// If debug mode is enabled.
        /// </param>
        public ImagingApi(string appKey, string appSid, string baseUrl, string apiVersion, AuthType authType, bool debug)
            : this(new Configuration { AppKey = appKey, AppSid = appSid, ApiBaseUrl = baseUrl, ApiVersion = apiVersion, AuthType = authType, DebugMode = debug })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        private ImagingApi(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        #endregion
	
		#region Methods
		
        /// <summary>
        /// Deletes the search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSearchContextRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteSearchContext(DeleteSearchContextRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling DeleteSearchContext");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
				var response = this.apiInvoker.InvokeApi(
                        resourcePath, 
                        "DELETE", 
                        null, 
                        null, 
                        formParams);
				
				if (response == null)
				{
					return null;
				}
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Delete image and images features from search context 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSearchContextImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteSearchContextImage(DeleteSearchContextImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling DeleteSearchContextImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling DeleteSearchContextImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
				var response = this.apiInvoker.InvokeApi(
                        resourcePath, 
                        "DELETE", 
                        null, 
                        null, 
                        formParams);
				
				if (response == null)
				{
					return null;
				}
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Deletes image features from search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSearchContextImageFeaturesRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteSearchContextImageFeatures(DeleteSearchContextImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling DeleteSearchContextImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling DeleteSearchContextImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
				var response = this.apiInvoker.InvokeApi(
                        resourcePath, 
                        "DELETE", 
                        null, 
                        null, 
                        formParams);
				
				if (response == null)
				{
					return null;
				}
				
				object finalResponse;
				if (typeof(SaaSposeResponse) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SaaSposeResponse>(StreamHelper.ToString(response));
				}
				
				return (SaaSposeResponse)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing BMP image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageBmpRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageBmp(GetImageBmpRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageBmp");
            }

            // verify the required parameter 'bitsPerPixel' is set
            if (request.bitsPerPixel == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitsPerPixel' when calling GetImageBmp");
            }

            // verify the required parameter 'horizontalResolution' is set
            if (request.horizontalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'horizontalResolution' when calling GetImageBmp");
            }

            // verify the required parameter 'verticalResolution' is set
            if (request.verticalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'verticalResolution' when calling GetImageBmp");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/bmp";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Crop an existing image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageCropRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageCrop(GetImageCropRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageCrop");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageCrop");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling GetImageCrop");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling GetImageCrop");
            }

            // verify the required parameter 'width' is set
            if (request.width == null) 
            {
                throw new ApiException(400, "Missing required parameter 'width' when calling GetImageCrop");
            }

            // verify the required parameter 'height' is set
            if (request.height == null) 
            {
                throw new ApiException(400, "Missing required parameter 'height' when calling GetImageCrop");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/crop";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize existing DICOM image to PNG using given parameters. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageDicomRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageDicom(GetImageDicomRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageDicom");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/dicom";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize existing DNG image to PNG using given parameters. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageDngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageDng(GetImageDngRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageDng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/dng";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize existing EMF image to PNG using given parameters. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageEmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageEmf(GetImageEmfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageEmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling GetImageEmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling GetImageEmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling GetImageEmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling GetImageEmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling GetImageEmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/emf";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Get separate frame from existing TIFF image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageFrameRequest" /></param> 
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/frames/{frameId}";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Get separate frame properties of existing TIFF image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageFramePropertiesRequest" /></param> 
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/frames/{frameId}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "frameId", request.frameId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(ImagingResponse) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<ImagingResponse>(StreamHelper.ToString(response));
				}
				
				return (ImagingResponse)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing GIF image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageGifRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageGif(GetImageGifRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageGif");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/gif";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing JPEG2000 image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageJpeg2000Request" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageJpeg2000(GetImageJpeg2000Request request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageJpeg2000");
            }

            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling GetImageJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/jpg2000";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "comment", request.comment);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "codec", request.codec);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing JPEG image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageJpgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageJpg(GetImageJpgRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageJpg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/jpg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionType", request.compressionType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize existing ODG image to PNG using given parameters. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageOdgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageOdg(GetImageOdgRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageOdg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/odg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing PNG image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImagePngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImagePng(GetImagePngRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImagePng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/png";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Get properties of an image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImagePropertiesRequest" /></param> 
        /// <returns><see cref="ImagingResponse"/></returns>            
        public ImagingResponse GetImageProperties(GetImagePropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(ImagingResponse) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<ImagingResponse>(StreamHelper.ToString(response));
				}
				
				return (ImagingResponse)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing PSD image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImagePsdRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImagePsd(GetImagePsdRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImagePsd");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/psd";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "channelsCount", request.channelsCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionMethod", request.compressionMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Resize an existing image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageResize(GetImageResizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageResize");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling GetImageResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling GetImageResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rotate and/or flip an existing image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageRotateFlip(GetImageRotateFlipRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling GetImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Export existing image to another format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageSaveAs(GetImageSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing TIFF image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageTiff(GetImageTiffRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageTiff");
            }

            // verify the required parameter 'compression' is set
            if (request.compression == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compression' when calling GetImageTiff");
            }

            // verify the required parameter 'resolutionUnit' is set
            if (request.resolutionUnit == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resolutionUnit' when calling GetImageTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling GetImageTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Perform scaling, cropping and flipping of an existing image in a single request. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageUpdateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageUpdate(GetImageUpdateRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageUpdate");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageUpdate");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling GetImageUpdate");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling GetImageUpdate");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling GetImageUpdate");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling GetImageUpdate");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling GetImageUpdate");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling GetImageUpdate");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling GetImageUpdate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/updateImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing WEBP image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageWebPRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageWebP(GetImageWebPRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling GetImageWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling GetImageWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling GetImageWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling GetImageWebP");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/webp";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize existing WMF image to PNG using given parameters. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageWmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageWmf(GetImageWmfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageWmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling GetImageWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling GetImageWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling GetImageWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling GetImageWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling GetImageWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/{name}/wmf";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Extract features from image without adding to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSearchContextExtractImageFeaturesRequest" /></param> 
        /// <returns><see cref="ImageFeatures"/></returns>            
        public ImageFeatures GetSearchContextExtractImageFeatures(GetSearchContextExtractImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextExtractImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling GetSearchContextExtractImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image2features";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(ImageFeatures) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<ImageFeatures>(StreamHelper.ToString(response));
				}
				
				return (ImageFeatures)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Find images duplicates. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSearchContextFindDuplicatesRequest" /></param> 
        /// <returns><see cref="ImageDuplicatesSet"/></returns>            
        public ImageDuplicatesSet GetSearchContextFindDuplicates(GetSearchContextFindDuplicatesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextFindDuplicates");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling GetSearchContextFindDuplicates");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findDuplicates";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(ImageDuplicatesSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<ImageDuplicatesSet>(StreamHelper.ToString(response));
				}
				
				return (ImageDuplicatesSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Find similar images. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSearchContextFindSimilarRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet GetSearchContextFindSimilar(GetSearchContextFindSimilarRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextFindSimilar");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling GetSearchContextFindSimilar");
            }

            // verify the required parameter 'maxCount' is set
            if (request.maxCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'maxCount' when calling GetSearchContextFindSimilar");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findSimilar";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchResultsSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
				}
				
				return (SearchResultsSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Get image from search context 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSearchContextImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetSearchContextImage(GetSearchContextImageRequest request)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
<<<<<<< HEAD
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling GetSearchContextImage");
            }

=======
>>>>>>> SDK regenerated by CI server
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
>>>>>>> SDK regenerated by CI server
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
=======
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
>>>>>>> SDK regenerated by CI server
=======
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
>>>>>>> SDK regenerated by CI server
=======
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling GetSearchContextImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Gets image features from search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSearchContextImageFeaturesRequest" /></param> 
        /// <returns><see cref="ImageFeatures"/></returns>            
        public ImageFeatures GetSearchContextImageFeatures(GetSearchContextImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling GetSearchContextImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(ImageFeatures) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<ImageFeatures>(StreamHelper.ToString(response));
				}
				
				return (ImageFeatures)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Gets the search context status. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSearchContextStatusRequest" /></param> 
        /// <returns><see cref="SearchContextStatus"/></returns>            
        public SearchContextStatus GetSearchContextStatus(GetSearchContextStatusRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling GetSearchContextStatus");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/status";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchContextStatus) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchContextStatus>(StreamHelper.ToString(response));
				}
				
				return (SearchContextStatus)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of existing TIFF image accordingly to fax parameters. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTiffToFaxRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetTiffToFax(GetTiffToFaxRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTiffToFax");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/tiff/{name}/toFax";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Create new search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCreateSearchContextRequest" /></param> 
        /// <returns><see cref="SearchContextStatus"/></returns>            
        public SearchContextStatus PostCreateSearchContext(PostCreateSearchContextRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/create";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "detector", request.detector);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "matchingAlgorithm", request.matchingAlgorithm);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchContextStatus) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchContextStatus>(StreamHelper.ToString(response));
				}
				
				return (SearchContextStatus)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of BMP image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageBmpRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageBmp(PostImageBmpRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageBmp");
            }

            // verify the required parameter 'bitsPerPixel' is set
            if (request.bitsPerPixel == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitsPerPixel' when calling PostImageBmp");
            }

            // verify the required parameter 'horizontalResolution' is set
            if (request.horizontalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'horizontalResolution' when calling PostImageBmp");
            }

            // verify the required parameter 'verticalResolution' is set
            if (request.verticalResolution == null) 
            {
                throw new ApiException(400, "Missing required parameter 'verticalResolution' when calling PostImageBmp");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/bmp";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Crop an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageCropRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageCrop(PostImageCropRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageCrop");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageCrop");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling PostImageCrop");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling PostImageCrop");
            }

            // verify the required parameter 'width' is set
            if (request.width == null) 
            {
                throw new ApiException(400, "Missing required parameter 'width' when calling PostImageCrop");
            }

            // verify the required parameter 'height' is set
            if (request.height == null) 
            {
                throw new ApiException(400, "Missing required parameter 'height' when calling PostImageCrop");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/crop";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize DICOM image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageDicomRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageDicom(PostImageDicomRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageDicom");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/dicom";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize DNG image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageDngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageDng(PostImageDngRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageDng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/dng";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize EMF image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageEmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageEmf(PostImageEmfRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageEmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling PostImageEmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling PostImageEmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling PostImageEmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling PostImageEmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling PostImageEmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/emf";
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
<<<<<<< HEAD
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
<<<<<<< HEAD
        /// Update parameters of JPEG image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageJpgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageJpg(PostImageJpgRequest request)
=======
        /// Update parameters of GIF image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageGifRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageGif(PostImageGifRequest request)
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageJpg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/jpg";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageGif");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/gif";
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionType", request.compressionType);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColorIndex", request.backgroundColorIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "colorResolution", request.colorResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "hasTrailer", request.hasTrailer);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "interlaced", request.interlaced);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isPaletteSorted", request.isPaletteSorted);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pixelAspectRatio", request.pixelAspectRatio);
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Rasterize ODG image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageOdgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageOdg(PostImageOdgRequest request)
=======
        /// Update parameters of JPEG2000 image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageJpeg2000Request" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageJpeg2000(PostImageJpeg2000Request request)
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageOdg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/odg";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageJpeg2000");
            }

            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PostImageJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/jpg2000";
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "comment", request.comment);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "codec", request.codec);
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
=======
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
<<<<<<< HEAD
        /// Update parameters of PNG image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagePngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImagePng(PostImagePngRequest request)
=======
        /// Update parameters of JPEG image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageJpgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageJpg(PostImageJpgRequest request)
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/png";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of PSD image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagePsdRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImagePsd(PostImagePsdRequest request)
<<<<<<< HEAD
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePsd");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/psd";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageJpg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/jpg";
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "channelsCount", request.channelsCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionMethod", request.compressionMethod);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionType", request.compressionType);
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Resize an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageResize(PostImageResizeRequest request)
=======
        /// Rasterize ODG image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageOdgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageOdg(PostImageOdgRequest request)
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageResize");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rotate and/or flip an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageRotateFlip(PostImageRotateFlipRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling PostImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/rotateflip";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageOdg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/odg";
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Export existing image to another format. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageSaveAs(PostImageSaveAsRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/saveAs";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of TIFF image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageTiff(PostImageTiffRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageTiff");
            }

            // verify the required parameter 'compression' is set
            if (request.compression == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compression' when calling PostImageTiff");
            }

            // verify the required parameter 'resolutionUnit' is set
            if (request.resolutionUnit == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resolutionUnit' when calling PostImageTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling PostImageTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Perform scaling, cropping and flipping of an image in a single request. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageUpdateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageUpdate(PostImageUpdateRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageUpdate");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageUpdate");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling PostImageUpdate");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling PostImageUpdate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/updateImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of WEBP image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWebPRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWebP(PostImageWebPRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling PostImageWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling PostImageWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling PostImageWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling PostImageWebP");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/webp";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize WMF image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWmf(PostImageWmfRequest request)
=======
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePsd");
            }

<<<<<<< HEAD
            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling PostImageWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling PostImageWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling PostImageWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling PostImageWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling PostImageWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/wmf";
=======
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/psd";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Resize an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageResize(PostImageResizeRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageResize");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
=======
>>>>>>> SDK regenerated by CI server
        /// Rotate and/or flip an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageRotateFlip(PostImageRotateFlipRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling PostImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Export existing image to another format. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageSaveAs(PostImageSaveAsRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/saveAs";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of TIFF image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageTiff(PostImageTiffRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
<<<<<<< HEAD
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageTiff");
            }

            // verify the required parameter 'compression' is set
            if (request.compression == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compression' when calling PostImageTiff");
            }

            // verify the required parameter 'resolutionUnit' is set
            if (request.resolutionUnit == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resolutionUnit' when calling PostImageTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
=======
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageTiff");
            }

            // verify the required parameter 'compression' is set
            if (request.compression == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compression' when calling PostImageTiff");
            }

            // verify the required parameter 'resolutionUnit' is set
            if (request.resolutionUnit == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resolutionUnit' when calling PostImageTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
>>>>>>> SDK regenerated by CI server
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling PostImageTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/tiff";
<<<<<<< HEAD
>>>>>>> SDK regenerated by CI server
=======
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
<<<<<<< HEAD
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bkColor", request.bkColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageWidth", request.pageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageHeight", request.pageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderX", request.borderX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderY", request.borderY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
=======
=======
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
<<<<<<< HEAD
>>>>>>> SDK regenerated by CI server
=======
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
<<<<<<< HEAD
        /// Add image and images features to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddImage(PostSearchContextAddImageRequest request)
=======
        /// Perform scaling, cropping and flipping of an image in a single request. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageUpdateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageUpdate(PostImageUpdateRequest request)
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageUpdate");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageUpdate");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling PostImageUpdate");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PostSearchContextAddImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
=======
        /// Perform scaling, cropping and flipping of an image in a single request. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageUpdateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageUpdate(PostImageUpdateRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageUpdate");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageUpdate");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling PostImageUpdate");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
=======
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
>>>>>>> SDK regenerated by CI server
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling PostImageUpdate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/updateImage";
<<<<<<< HEAD
>>>>>>> SDK regenerated by CI server
=======
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
<<<<<<< HEAD
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
=======
=======
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
<<<<<<< HEAD
>>>>>>> SDK regenerated by CI server
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Add tag and reference image to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddTagRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddTag(PostSearchContextAddTagRequest request)
=======
        /// Update parameters of WEBP image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWebPRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWebP(PostImageWebPRequest request)
>>>>>>> SDK regenerated by CI server
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'tagName' is set
            if (request.tagName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tagName' when calling PostSearchContextAddTag");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/addTag";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling PostImageWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling PostImageWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling PostImageWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling PostImageWebP");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/webp";
>>>>>>> SDK regenerated by CI server
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "tagName", request.tagName);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "lossLess", request.lossLess);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "animLoopCount", request.animLoopCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "animBackgroundColor", request.animBackgroundColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
>>>>>>> SDK regenerated by CI server
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Compare two images. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextCompareImagesRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextCompareImages(PostSearchContextCompareImagesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
=======
        /// Rasterize WMF image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWmf(PostImageWmfRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling PostImageWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling PostImageWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling PostImageWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling PostImageWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling PostImageWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/wmf";
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
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Add image and images features to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddImage(PostSearchContextAddImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PostSearchContextAddImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Add tag and reference image to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddTagRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddTag(PostSearchContextAddTagRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'tagName' is set
            if (request.tagName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tagName' when calling PostSearchContextAddTag");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/addTag";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "tagName", request.tagName);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Compare two images. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextCompareImagesRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextCompareImages(PostSearchContextCompareImagesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
>>>>>>> SDK regenerated by CI server
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextCompareImages");
            }

            // verify the required parameter 'imageId1' is set
            if (request.imageId1 == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId1' when calling PostSearchContextCompareImages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/compare";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchResultsSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
				}
				
				return (SearchResultsSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Extract images features and add them to search context 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextExtractImageFeaturesRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextExtractImageFeatures(PostSearchContextExtractImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextExtractImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Find images by tag. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextFindByTagsRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextFindByTags(PostSearchContextFindByTagsRequest request)
        {
<<<<<<< HEAD
            // verify the required parameter 'tags' is set
            if (request.tags == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tags' when calling PostSearchContextFindByTags");
            }

=======
>>>>>>> SDK regenerated by CI server
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'maxCount' is set
            if (request.maxCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'maxCount' when calling PostSearchContextFindByTags");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findByTags";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "maxCount", request.maxCount);
            
<<<<<<< HEAD
            if (request.tags != null) 
            {
                formParams.Add("tags", request.tags); // form parameter
            }
=======
>>>>>>> SDK regenerated by CI server
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "maxCount", request.maxCount);
<<<<<<< HEAD
            var postBody = SerializationHelper.Serialize(request.tags); // http body (model) parameter
>>>>>>> SDK regenerated by CI server
=======
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
>>>>>>> SDK regenerated by CI server
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
>>>>>>> SDK regenerated by CI server
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of WEBP image. Image is passed in a request stream. 
=======
        /// Update parameters of PNG image. Image is passed in a request stream. 
>>>>>>> SDK regenerated by CI server
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagePngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImagePng(PostImagePngRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/png";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of PSD image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagePsdRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImagePsd(PostImagePsdRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePsd");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/psd";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Resize an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageResize(PostImageResizeRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageResize");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rotate and/or flip an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageRotateFlip(PostImageRotateFlipRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling PostImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Export existing image to another format. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageSaveAs(PostImageSaveAsRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/saveAs";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of TIFF image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageTiff(PostImageTiffRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageTiff");
            }

            // verify the required parameter 'compression' is set
            if (request.compression == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compression' when calling PostImageTiff");
            }

            // verify the required parameter 'resolutionUnit' is set
            if (request.resolutionUnit == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resolutionUnit' when calling PostImageTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling PostImageTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Perform scaling, cropping and flipping of an image in a single request. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageUpdateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageUpdate(PostImageUpdateRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageUpdate");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageUpdate");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling PostImageUpdate");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling PostImageUpdate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/updateImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of WEBP image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWebPRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWebP(PostImageWebPRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling PostImageWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling PostImageWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling PostImageWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling PostImageWebP");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/webp";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize WMF image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWmf(PostImageWmfRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling PostImageWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling PostImageWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling PostImageWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling PostImageWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling PostImageWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/wmf";
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
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Add image and images features to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddImage(PostSearchContextAddImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PostSearchContextAddImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Add tag and reference image to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddTagRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddTag(PostSearchContextAddTagRequest request)
=======
        /// Update parameters of GIF image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageGifRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageGif(PostImageGifRequest request)
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'tagName' is set
            if (request.tagName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tagName' when calling PostSearchContextAddTag");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/addTag";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageGif");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/gif";
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "tagName", request.tagName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColorIndex", request.backgroundColorIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "colorResolution", request.colorResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "hasTrailer", request.hasTrailer);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "interlaced", request.interlaced);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isPaletteSorted", request.isPaletteSorted);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pixelAspectRatio", request.pixelAspectRatio);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Compare two images. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextCompareImagesRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextCompareImages(PostSearchContextCompareImagesRequest request)
=======
        /// Update parameters of JPEG2000 image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageJpeg2000Request" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageJpeg2000(PostImageJpeg2000Request request)
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextCompareImages");
            }

            // verify the required parameter 'imageId1' is set
            if (request.imageId1 == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId1' when calling PostSearchContextCompareImages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/compare";
=======
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageJpeg2000");
            }

            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PostImageJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/jpg2000";
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId1", request.imageId1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId2", request.imageId2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "comment", request.comment);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "codec", request.codec);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchResultsSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
				}
				
				return (SearchResultsSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Extract images features and add them to search context 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextExtractImageFeaturesRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextExtractImageFeatures(PostSearchContextExtractImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextExtractImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
=======
        /// Update parameters of JPEG image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageJpgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageJpg(PostImageJpgRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageJpg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/jpg";
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imagesFolder", request.imagesFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compressionType", request.compressionType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Find images by tag. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextFindByTagsRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextFindByTags(PostSearchContextFindByTagsRequest request)
        {
            // verify the required parameter 'tags' is set
            if (request.tags == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tags' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'maxCount' is set
            if (request.maxCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'maxCount' when calling PostSearchContextFindByTags");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findByTags";
=======
        /// Rasterize ODG image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageOdgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageOdg(PostImageOdgRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageOdg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/odg";
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarityThreshold", request.similarityThreshold);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "maxCount", request.maxCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.tags != null) 
            {
                formParams.Add("tags", request.tags); // form parameter
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchResultsSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
				}
				
				return (SearchResultsSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTiffAppendRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse PostTiffAppend(PostTiffAppendRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostTiffAppend");
            }

            // verify the required parameter 'appendFile' is set
            if (request.appendFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'appendFile' when calling PostTiffAppend");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/tiff/{name}/appendTiff";
=======
        /// Update parameters of PNG image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagePngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImagePng(PostImagePngRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/png";
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
<<<<<<< HEAD
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "appendFile", request.appendFile);
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SaaSposeResponse) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SaaSposeResponse>(StreamHelper.ToString(response));
				}
				
				return (SaaSposeResponse)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Update image and images features in search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSearchContextImageRequest" /></param> 
=======
        /// Update parameters of PSD image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagePsdRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImagePsd(PostImagePsdRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImagePsd");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/psd";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Resize an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageResize(PostImageResizeRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageResize");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rotate and/or flip an image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageRotateFlip(PostImageRotateFlipRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling PostImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Export existing image to another format. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageSaveAs(PostImageSaveAsRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/saveAs";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of TIFF image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageTiff(PostImageTiffRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageTiff");
            }

            // verify the required parameter 'compression' is set
            if (request.compression == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compression' when calling PostImageTiff");
            }

            // verify the required parameter 'resolutionUnit' is set
            if (request.resolutionUnit == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resolutionUnit' when calling PostImageTiff");
            }

            // verify the required parameter 'bitDepth' is set
            if (request.bitDepth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bitDepth' when calling PostImageTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "compression", request.compression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionUnit", request.resolutionUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bitDepth", request.bitDepth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromScratch", request.fromScratch);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "horizontalResolution", request.horizontalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "verticalResolution", request.verticalResolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Perform scaling, cropping and flipping of an image in a single request. Image is passed in a request stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageUpdateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageUpdate(PostImageUpdateRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageUpdate");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageUpdate");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'x' is set
            if (request.x == null) 
            {
                throw new ApiException(400, "Missing required parameter 'x' when calling PostImageUpdate");
            }

            // verify the required parameter 'y' is set
            if (request.y == null) 
            {
                throw new ApiException(400, "Missing required parameter 'y' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectWidth' is set
            if (request.rectWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectWidth' when calling PostImageUpdate");
            }

            // verify the required parameter 'rectHeight' is set
            if (request.rectHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rectHeight' when calling PostImageUpdate");
            }

            // verify the required parameter 'rotateFlipMethod' is set
            if (request.rotateFlipMethod == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipMethod' when calling PostImageUpdate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/updateImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", request.x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", request.y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipMethod", request.rotateFlipMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update parameters of WEBP image. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWebPRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageWebP(PostImageWebPRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWebP");
            }

            // verify the required parameter 'lossLess' is set
            if (request.lossLess == null) 
            {
                throw new ApiException(400, "Missing required parameter 'lossLess' when calling PostImageWebP");
            }

            // verify the required parameter 'quality' is set
            if (request.quality == null) 
            {
                throw new ApiException(400, "Missing required parameter 'quality' when calling PostImageWebP");
            }

            // verify the required parameter 'animLoopCount' is set
            if (request.animLoopCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animLoopCount' when calling PostImageWebP");
            }

            // verify the required parameter 'animBackgroundColor' is set
            if (request.animBackgroundColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'animBackgroundColor' when calling PostImageWebP");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/webp";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Rasterize WMF image to PNG using given parameters. Image is passed in a request stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWmfRequest" /></param> 
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutSearchContextImage(PutSearchContextImageRequest request)
        {
<<<<<<< HEAD
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PutSearchContextImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PutSearchContextImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
=======
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostImageWmf");
            }

            // verify the required parameter 'bkColor' is set
            if (request.bkColor == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bkColor' when calling PostImageWmf");
            }

            // verify the required parameter 'pageWidth' is set
            if (request.pageWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageWidth' when calling PostImageWmf");
            }

            // verify the required parameter 'pageHeight' is set
            if (request.pageHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageHeight' when calling PostImageWmf");
            }

            // verify the required parameter 'borderX' is set
            if (request.borderX == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderX' when calling PostImageWmf");
            }

            // verify the required parameter 'borderY' is set
            if (request.borderY == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderY' when calling PostImageWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/wmf";
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
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Add image and images features to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddImage(PostSearchContextAddImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PostSearchContextAddImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Add tag and reference image to search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextAddTagRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextAddTag(PostSearchContextAddTagRequest request)
        {
            // verify the required parameter 'imageData' is set
            if (request.imageData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageData' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextAddTag");
            }

            // verify the required parameter 'tagName' is set
            if (request.tagName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tagName' when calling PostSearchContextAddTag");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/addTag";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Compare two images. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextCompareImagesRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextCompareImages(PostSearchContextCompareImagesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextCompareImages");
            }

            // verify the required parameter 'imageId1' is set
            if (request.imageId1 == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId1' when calling PostSearchContextCompareImages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/compare";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchResultsSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
				}
				
				return (SearchResultsSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Extract images features and add them to search context 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextExtractImageFeaturesRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSearchContextExtractImageFeatures(PostSearchContextExtractImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextExtractImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
			var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "searchContextId", request.searchContextId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageId", request.imageId);
<<<<<<< HEAD
=======
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imagesFolder", request.imagesFolder);
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
<<<<<<< HEAD
        /// Update images features in search context. 
=======
        /// Find images by tag. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchContextFindByTagsRequest" /></param> 
        /// <returns><see cref="SearchResultsSet"/></returns>            
        public SearchResultsSet PostSearchContextFindByTags(PostSearchContextFindByTagsRequest request)
        {
            // verify the required parameter 'tags' is set
            if (request.tags == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tags' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'similarityThreshold' is set
            if (request.similarityThreshold == null) 
            {
                throw new ApiException(400, "Missing required parameter 'similarityThreshold' when calling PostSearchContextFindByTags");
            }

            // verify the required parameter 'maxCount' is set
            if (request.maxCount == null) 
            {
                throw new ApiException(400, "Missing required parameter 'maxCount' when calling PostSearchContextFindByTags");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/findByTags";
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
                formParams.Add("tags", request.tags); // form parameter
            }
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(SearchResultsSet) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<SearchResultsSet>(StreamHelper.ToString(response));
				}
				
				return (SearchResultsSet)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images). 
>>>>>>> ff98b60c39a2f6a40918f9c5c6942d9eabb4f764
        /// </summary>
        /// <param name="request">Request. <see cref="PutSearchContextImageFeaturesRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutSearchContextImageFeatures(PutSearchContextImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PutSearchContextImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PutSearchContextImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update image and images features in search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSearchContextImageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutSearchContextImage(PutSearchContextImageRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PutSearchContextImage");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PutSearchContextImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/image";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
        /// <summary>
        /// Update images features in search context. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSearchContextImageFeaturesRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutSearchContextImageFeatures(PutSearchContextImageFeaturesRequest request)
        {
            // verify the required parameter 'searchContextId' is set
            if (request.searchContextId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchContextId' when calling PutSearchContextImageFeatures");
            }

            // verify the required parameter 'imageId' is set
            if (request.imageId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageId' when calling PutSearchContextImageFeatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/imaging/ai/imageSearch/{searchContextId}/features";
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
            try 
            {                               
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
				
				object finalResponse;
				if (typeof(System.IO.Stream) == typeof(System.IO.Stream))
				{
					finalResponse = response;
				}
				else
				{
					finalResponse = SerializationHelper.Deserialize<System.IO.Stream>(StreamHelper.ToString(response));
				}
				
				return (System.IO.Stream)finalResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
		
		#endregion
    }
}
