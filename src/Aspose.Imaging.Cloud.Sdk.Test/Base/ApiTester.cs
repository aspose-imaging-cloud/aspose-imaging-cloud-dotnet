// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiTester.cs">
//   Copyright (c) 2019 Aspose Pty Ltd. All rights reserved.
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

namespace Aspose.Imaging.Cloud.Sdk.Test.Api
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    using Aspose.Imaging.Cloud.Sdk.Api;
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Base class for API tester
    /// </summary>
    public abstract class ApiTester
    {
        #region Consts

        /// <summary>
        /// The server access file
        /// </summary>
        private const string ServerAccessFile = "serverAccess.json";

        /// <summary>
        /// The API version
        /// </summary>
        private const string ApiVersion = "v3.0";

        /// <summary>
        /// The application key
        /// </summary>
        private const string AppKey = "xxx";

        /// <summary>
        /// The application SID
        /// </summary>
        private const string AppSid = "xxx";

        /// <summary>
        /// The base URL
        /// </summary>
        private const string BaseUrl = "http://api.aspose.cloud/";

        /// <summary>
        /// The default storage
        /// </summary>
        protected const string DefaultStorage = "Imaging-CI";

        #endregion

        #region Fields

        /// <summary>
        /// If any test failed
        /// </summary>
        protected static bool FailedAnyTest = false;

        /// <summary>
        /// The local test folder
        /// </summary>
        protected readonly string LocalTestFolder = Path.Combine(Assembly.GetExecutingAssembly().Location,
            "..\\..\\..\\..\\..\\..\\TestData\\");

        /// <summary>
        /// The temporary folder
        /// </summary>
        protected string TempFolder;

        /// <summary>
        /// The input test files
        /// </summary>
        protected List<StorageFile> InputTestFiles;

        /// <summary>
        /// Aspose.Imaging API
        /// </summary>
        protected ImagingApi ImagingApi;

        /// <summary>
        /// The basic export formats
        /// </summary>
        protected readonly string[] BasicExportFormats = new string[]
        {
            "bmp",
            "gif",
            "jpg",
            "png",
            "psd",
            "tiff",
            "webp",
            "pdf"
        };

        #endregion

        #region Delegates

        /// <summary>
        /// Delegate that tests properties.
        /// </summary>
        /// <param name="originalProperties">The original properties.</param>
        /// <param name="resultProperties">The result properties.</param>
        /// <param name="resultStream">The result stream.</param>
        protected delegate void PropertiesTesterDelegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream);

        /// <summary>
        /// Typical GET request delegate that accepts image file name from Storage.
        /// </summary>
        /// <param name="fileName">File name of the image.</param>
        /// <returns></returns>
        protected delegate Stream GetRequestInvokerDelegate(string fileName, string outPath);

        /// <summary>
        /// Typical POST request delegate that accepts input image stream.
        /// </summary>
        /// <param name="inputStream">The input image stream.</param>
        /// <returns></returns>
        protected delegate Stream PostRequestInvokerDelegate(Stream inputStream, string outPath);

        #endregion

        #region Properties

        /// <summary>
        /// The cloud test folder prefix
        /// </summary>
        protected virtual string CloudTestFolderPrefix => "ImagingCloudTestDotNet";

        /// <summary>
        /// Original test data folder
        /// </summary>
        protected virtual string OriginalDataFolder => "ImagingIntegrationTestData";

        /// <summary>
        /// The default storage
        /// </summary>
        protected string TestStorage { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether resulting images should be removed from cloud storage.
        /// </summary>
        /// <value>
        ///   <c>true</c> if resulting images should be removed from cloud storage; otherwise, <c>false</c>.
        /// </value>
        public bool RemoveResult { get; set; } = true;

        #endregion

        #region Configuration

        [OneTimeSetUp]
        public virtual void InitFixture()
        {
            this.TempFolder = $"{this.CloudTestFolderPrefix}_{this.GetEnvironmentVariable("BUILD_NUMBER") ?? Environment.UserName}";

            this.TestStorage = this.GetEnvironmentVariable("StorageName");

            if (string.IsNullOrEmpty(this.TestStorage))
            {
                WriteLineEverywhere("Storage name is not set by environment variable. Using the default one.");
                this.TestStorage = DefaultStorage;
            }

            this.CreateApiInstances();
            if (!FailedAnyTest && this.RemoveResult && 
                this.ImagingApi.ObjectExists(new ObjectExistsRequest(this.TempFolder, this.TestStorage)).Exists.Value)
            {
                this.ImagingApi.DeleteFolder(new DeleteFolderRequest(this.TempFolder, this.TestStorage, true));
                this.ImagingApi.CreateFolder(new CreateFolderRequest(this.TempFolder, this.TestStorage));
            }
        }

        [OneTimeTearDown]
        public virtual void FinilizeFixture()
        {
            if (!FailedAnyTest && this.RemoveResult && 
                this.ImagingApi.ObjectExists(new ObjectExistsRequest(this.TempFolder, this.TestStorage)).Exists.Value)
            {
                this.ImagingApi.DeleteFolder(new DeleteFolderRequest(this.TempFolder, this.TestStorage, true));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates the API instances using given access parameters.
        /// </summary>
        /// <param name="appKey">The application key.</param>
        /// <param name="appSid">The application sid.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="apiVersion">The API version.</param>
        /// <param name="debug">if set to <c>true</c> [debug].</param>
        /// <exception cref="System.ArgumentException">Please, specify valid access data (AppKey, AppSid, Base URL)</exception>
        protected void CreateApiInstances(string appKey = AppKey, string appSid = AppSid, 
            string baseUrl = BaseUrl, string apiVersion = ApiVersion, bool debug = false)
        {
            if (appKey == AppKey || appSid == AppSid)
            {
                WriteLineEverywhere("Access data isn't set explicitly. Trying to obtain it from environment variables.");

                appKey = this.GetEnvironmentVariable("AppKey");
                appSid = this.GetEnvironmentVariable("AppSid");
                baseUrl = this.GetEnvironmentVariable("ApiEndpoint");
                apiVersion = this.GetEnvironmentVariable("ApiVersion");
            }

            if (string.IsNullOrEmpty(appKey) || string.IsNullOrEmpty(appSid) || string.IsNullOrEmpty(baseUrl) || 
                string.IsNullOrEmpty(apiVersion))
            {
                WriteLineEverywhere("Access data isn't set completely by environment variables. Filling unset data with default values.");
            }

            if (string.IsNullOrEmpty(apiVersion))
            {
                apiVersion = ApiVersion;
                WriteLineEverywhere("Set default API version");
            }

            string serverAccessPath = Path.Combine(LocalTestFolder, ServerAccessFile);
            FileInfo serverFileInfo = new FileInfo(serverAccessPath);

            if (serverFileInfo.Exists && serverFileInfo.Length > 0)
            {
                var accessData = JsonConvert.DeserializeObject<ServerAccessData>(File.ReadAllText(serverAccessPath));
                if (string.IsNullOrEmpty(appKey))
                {
                    appKey = accessData.AppKey;
                    WriteLineEverywhere("Set default App key");
                }

                if (string.IsNullOrEmpty(appSid))
                {
                    appSid = accessData.AppSid;
                    WriteLineEverywhere("Set default App SID");
                }

                if (string.IsNullOrEmpty(baseUrl))
                {
                    baseUrl = accessData.BaseURL;
                    WriteLineEverywhere("Set default base URL");
                }

            }
            else
            {
                throw new ArgumentException("Please, specify valid access data (AppKey, AppSid, Base URL)");
            }

            WriteLineEverywhere($"App key: {appKey}");
            WriteLineEverywhere($"App SID: {appSid}");
            WriteLineEverywhere($"Storage: {this.TestStorage}");
            WriteLineEverywhere($"Base URL: {baseUrl}");
            WriteLineEverywhere($"API version: {apiVersion}");
            this.ImagingApi = new ImagingApi(appKey, appSid, baseUrl, apiVersion, debug);
            InputTestFiles = this.FetchInputTestFilesInfo();
        }

        /// <summary>
        /// Tests the typical GET request.
        /// </summary>
        /// <param name="testMethodName">Name of the test method.</param>
        /// <param name="saveResultToStorage">if set to <c>true</c> [save result to storage].</param>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="requestInvoker">The request invoker.</param>
        /// <param name="propertiesTester">The properties tester.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestGetRequest(string testMethodName, bool saveResultToStorage, string parametersLine, 
            string inputFileName, string resultFileName, GetRequestInvokerDelegate requestInvoker, 
            PropertiesTesterDelegate propertiesTester, string folder, string storage = DefaultStorage)
        {
            this.TestRequest(testMethodName, saveResultToStorage, parametersLine, inputFileName, resultFileName, 
                () => this.ObtainGetResponse(inputFileName, saveResultToStorage ? $"{folder}/{resultFileName}" : null, requestInvoker),
                propertiesTester, folder, storage);
        }

        /// <summary>
        /// Tests the typical POST request.
        /// </summary>
        /// <param name="testMethodName">Name of the test method.</param>
        /// <param name="saveResultToStorage">if set to <c>true</c> [save result to storage].</param>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="requestInvoker">The request invoker.</param>
        /// <param name="propertiesTester">The properties tester.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestPostRequest(string testMethodName, bool saveResultToStorage, string parametersLine, string inputFileName, 
            string resultFileName, PostRequestInvokerDelegate requestInvoker, PropertiesTesterDelegate propertiesTester, 
            string folder, string storage = DefaultStorage)
        {
            this.TestRequest(testMethodName, saveResultToStorage, parametersLine, inputFileName, resultFileName,
                () => this.ObtainPostResponse(folder + "/" + inputFileName, saveResultToStorage ? $"{folder}/{resultFileName}" : null, storage, requestInvoker),
                propertiesTester, folder, storage);
        }

        /// <summary>
        /// Checks if input file exists.
        /// </summary>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <returns></returns>
        protected bool CheckInputFileExists(string inputFileName)
        {
            foreach (StorageFile storageFileInfo in InputTestFiles)
            {
                if (storageFileInfo.Name == inputFileName)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the storage file information.
        /// </summary>
        /// <param name="folder">The folder which contains a file.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="storage">The storage.</param>
        /// <returns></returns>
        protected StorageFile GetStorageFileInfo(string folder, string fileName,
            string storage)
        {
            FilesList fileListResponse = this.ImagingApi.GetFilesList(new GetFilesListRequest(folder, storage));

            foreach (StorageFile storageFileInfo in fileListResponse.Value)
            {
                if (storageFileInfo.Name == fileName)
                {
                    return storageFileInfo;
                }
            }

            return null;
        }

        /// <summary>
        /// Fetches the input test files info.
        /// </summary>
        /// <returns></returns>
        private List<StorageFile> FetchInputTestFilesInfo()
        {
            var filesResponse = this.ImagingApi.GetFilesList(new GetFilesListRequest(OriginalDataFolder, this.TestStorage));
            return filesResponse.Value;
        }

        /// <summary>
        /// Obtains the typical GET request response.
        /// </summary>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="requestInvoker">The request invoker.</param>
        /// <param name="outPath">The output path to save the result.</param>
        private Stream ObtainGetResponse(string inputFileName, string outPath, GetRequestInvokerDelegate requestInvoker)
        {
            var response = requestInvoker.Invoke(inputFileName, outPath);

            if (string.IsNullOrEmpty(outPath))
            {
                Assert.NotNull(response);
                Assert.Greater(response.Length, 0);
                return response;
            }

            return null;
        }

        /// <summary>
        /// Obtains the typical POST request response.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <param name="requestInvoker">The request invoker.</param>
        /// <param name="outPath">The output path to save the result.</param>
        /// <param name="storage">The storage.</param>
        private Stream ObtainPostResponse(string inputPath, string outPath, string storage, PostRequestInvokerDelegate requestInvoker)
        {
            using (Stream iStream = this.ImagingApi.DownloadFile(new DownloadFileRequest(inputPath, storage)))
            {
                var response = requestInvoker.Invoke(iStream, outPath);

                if (string.IsNullOrEmpty(outPath))
                {
                    Assert.NotNull(response);
                    Assert.Greater(response.Length, 0);
                    return response;
                }

                return null;
            }
        }

        /// <summary>
        /// Tests the typical request.
        /// </summary>
        /// <param name="testMethodName">Name of the test method.</param>
        /// <param name="saveResultToStorage">if set to <c>true</c> [save result to storage].</param>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="invokeRequestAction">The invoke request action.</param>
        /// <param name="propertiesTester">The properties tester.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        private void TestRequest(string testMethodName, bool saveResultToStorage, string parametersLine, string inputFileName, 
            string resultFileName,
#if NET20
            Newtonsoft.Json.Serialization.Func<Stream> invokeRequestAction,
#else
            System.Func<Stream> invokeRequestAction,
#endif
            PropertiesTesterDelegate propertiesTester, string folder, string storage = DefaultStorage)
        {
            WriteLineEverywhere(testMethodName);

            if (!CheckInputFileExists(inputFileName))
            {
                throw new ArgumentException(
                    $"Input file {inputFileName} doesn't exist in the specified storage folder: {folder}. Please, upload it first.");
            }

            if (!this.ImagingApi.ObjectExists(new ObjectExistsRequest(folder + "/" + inputFileName, storage)).Exists.Value)
            {
                this.ImagingApi.CopyFile(
                    new CopyFileRequest(OriginalDataFolder + "/" + inputFileName, folder + "/" + inputFileName, storage, storage));
            }

            bool passed = false;
            string outPath = null;

            try
            {
                WriteLineEverywhere(parametersLine);

                if (saveResultToStorage)
                {
                    outPath = folder + "/" + resultFileName;

                    // remove output file from the storage (if exists)
                    if (this.ImagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
                    {
                        this.ImagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
                    }
                }

                ImagingResponse resultProperties = null;

                using (Stream response = invokeRequestAction.Invoke())
                {
                    if (saveResultToStorage)
                    {
                        StorageFile resultInfo = this.GetStorageFileInfo(folder, resultFileName, storage);
                        if (resultInfo == null)
                        {
                            throw new ArgumentException(
                                $"Result file {resultFileName} doesn't exist in the specified storage folder: {folder}. " +
                                $"Result isn't present in the storage by an unknown reason.");
                        }

                        if (!resultFileName.EndsWith(".pdf"))
                        {
                            resultProperties =
                                this.ImagingApi.GetImageProperties(new GetImagePropertiesRequest(resultFileName, folder, storage));
                            Assert.NotNull(resultProperties);
                        }
                    }
                    else if (!this.ImagingApi.Configuration.ApiVersion.Contains("v1.") && !resultFileName.EndsWith(".pdf"))
                    {
                        resultProperties =
                            this.ImagingApi.PostImageProperties(new PostImagePropertiesRequest(response));
                        Assert.NotNull(resultProperties);
                    }

                    ImagingResponse originalProperties =
                        this.ImagingApi.GetImageProperties(new GetImagePropertiesRequest(inputFileName, folder, storage));
                    Assert.NotNull(originalProperties);

                    if (resultProperties != null)
                    {
                        propertiesTester?.Invoke(originalProperties, resultProperties, response);
                    }
                }
                
                passed = true;
            }
            catch (Exception ex)
            {
                FailedAnyTest = true;
                WriteLineEverywhere(ex.Message);
                throw;
            }
            finally
            {
                if (passed && saveResultToStorage && this.RemoveResult && this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(outPath, storage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
                }

                WriteLineEverywhere($"Test passed: {passed}");
            }
        }

        /// <summary>
        /// Writes the line everywhere to support different use-cases.
        /// </summary>
        /// <param name="line">The line.</param>
        protected void WriteLineEverywhere(string line)
        {
            Console.WriteLine(line);
            TestContext.WriteLine(line);
            TestContext.Progress.WriteLine(line);
        }

        /// <summary>
        /// Returns environment variable value
        /// </summary>
        /// <param name="variableName"></param>
        /// <returns>Environment variable value</returns>
        private string GetEnvironmentVariable(string variableName)
        {
            return (Environment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.Process) ??
                    Environment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User))
                   ?? Environment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.Machine);
        }

        #endregion
    }
}
