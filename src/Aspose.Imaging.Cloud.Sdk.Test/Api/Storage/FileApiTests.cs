// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileApiTests.cs">
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

namespace Aspose.Imaging.Cloud.Sdk.Test.Api.Storage
{
    using System.IO;
    using NUnit.Framework;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    /// Specific file API tests for Storage.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Test.Api.Storage.StorageApiTester" />
    [Category("File")]
    public class FileApiTests : StorageApiTester
    {
        [Test]
        public void CopyDownloadFileTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file = "Storage.txt";
            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file}", $"{folder}/{file}", this.TestStorage, this.TestStorage));
                var existResponse = this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}", this.TestStorage));
                Assert.NotNull(existResponse);
                Assert.IsFalse(existResponse.IsFolder.Value);
                Assert.IsTrue(existResponse.Exists.Value);

                var originalFileInfo =
                    this.ImagingApi.GetFilesList(new GetFilesListRequest(this.OriginalDataFolder, this.TestStorage)).
                        Value.Find(f => f.Name == file);
                var copiedFileInfo =
                    this.ImagingApi.GetFilesList(new GetFilesListRequest(folder, this.TestStorage)).
                        Value.Find(f => f.Name == file);
                Assert.AreEqual(originalFileInfo.Size, copiedFileInfo.Size);

                using (var originalFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{this.OriginalDataFolder}/{file}", this.TestStorage)))
                using (var copiedFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{folder}/{file}", this.TestStorage)))
                {
                    Assert.AreEqual(originalFile.Length, copiedFile.Length);
                    Assert.AreEqual(originalFile.Length, originalFileInfo.Size);
                    using (StreamReader originalReader = new StreamReader(originalFile))
                    using (StreamReader copiedReader = new StreamReader(copiedFile))
                    {
                        string originalString = originalReader.ReadToEnd();
                        string copiedString = copiedReader.ReadToEnd();
                        Assert.AreEqual(originalString, copiedString);
                        Assert.AreEqual(originalString, originalFileInfo.Path.Trim('/'));
                        Assert.AreEqual(originalString.Replace(this.OriginalDataFolder, folder), 
                            copiedFileInfo.Path.Trim('/'));
                    }
                }
            }
            finally
            {
                this.ImagingApi.DeleteFile(new DeleteFileRequest($"{folder}/{file}", this.TestStorage));
                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}", this.TestStorage)).Exists.Value);

                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);
            }
        }

        [Test]
        public void MoveFileTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file = "Storage.txt";
            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file}", $"{folder}/{file}.copied", this.TestStorage, this.TestStorage));
                var existResponse = this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}.copied", this.TestStorage));
                Assert.NotNull(existResponse);
                Assert.IsFalse(existResponse.IsFolder.Value);
                Assert.IsTrue(existResponse.Exists.Value);

                this.ImagingApi.MoveFile(
                    new MoveFileRequest($"{folder}/{file}.copied", $"{folder}/{file}", this.TestStorage, this.TestStorage));
                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}.copied", this.TestStorage)).Exists.Value);
                existResponse = this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}", this.TestStorage));
                Assert.NotNull(existResponse);
                Assert.IsFalse(existResponse.IsFolder.Value);
                Assert.IsTrue(existResponse.Exists.Value);

                var originalFileInfo =
                    this.ImagingApi.GetFilesList(new GetFilesListRequest(this.OriginalDataFolder, this.TestStorage)).
                        Value.Find(f => f.Name == file);
                var movedFileInfo =
                    this.ImagingApi.GetFilesList(new GetFilesListRequest(folder, this.TestStorage)).
                        Value.Find(f => f.Name == file);
                Assert.AreEqual(originalFileInfo.Size, movedFileInfo.Size);

                using (var originalFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{this.OriginalDataFolder}/{file}", this.TestStorage)))
                using (var movedFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{folder}/{file}", this.TestStorage)))
                {
                    Assert.AreEqual(originalFile.Length, movedFile.Length);
                    Assert.AreEqual(originalFile.Length, originalFileInfo.Size);
                    using (StreamReader originalReader = new StreamReader(originalFile))
                    using (StreamReader movedReader = new StreamReader(movedFile))
                    {
                        string originalString = originalReader.ReadToEnd();
                        string movedString = movedReader.ReadToEnd();
                        Assert.AreEqual(originalString, movedString);
                        Assert.AreEqual(originalString, originalFileInfo.Path.Trim('/'));
                        Assert.AreEqual(originalString.Replace(this.OriginalDataFolder, folder),
                            movedFileInfo.Path.Trim('/'));
                    }
                }
            }
            finally
            {
                this.ImagingApi.DeleteFile(new DeleteFileRequest($"{folder}/{file}", this.TestStorage));
                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}", this.TestStorage)).Exists.Value);

                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);
            }
        }

        [Test]
        public void UploadFileTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file = "Storage.txt";
            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                using (var originalFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{this.OriginalDataFolder}/{file}",
                        this.TestStorage)))
                {
                    var result =
                        this.ImagingApi.UploadFile(new UploadFileRequest($"{folder}/{file}", originalFile,
                            this.TestStorage));
                    Assert.NotNull(result);
                    Assert.IsTrue(result.Errors == null || result.Errors.Count == 0);
                    Assert.NotNull(result.Uploaded);
                    Assert.AreEqual(1, result.Uploaded.Count);
                    Assert.AreEqual(file, result.Uploaded[0]);
                }

                var existResponse = this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}", this.TestStorage));
                Assert.NotNull(existResponse);
                Assert.IsFalse(existResponse.IsFolder.Value);
                Assert.IsTrue(existResponse.Exists.Value);

                var originalFileInfo =
                    this.ImagingApi.GetFilesList(new GetFilesListRequest(this.OriginalDataFolder, this.TestStorage)).
                        Value.Find(f => f.Name == file);
                var uploadedFileInfo =
                    this.ImagingApi.GetFilesList(new GetFilesListRequest(folder, this.TestStorage)).
                        Value.Find(f => f.Name == file);
                Assert.AreEqual(originalFileInfo.Size, uploadedFileInfo.Size);

                using (var originalFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{this.OriginalDataFolder}/{file}", this.TestStorage)))
                using (var uploadedFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{folder}/{file}", this.TestStorage)))
                {
                    Assert.AreEqual(originalFile.Length, uploadedFile.Length);
                    Assert.AreEqual(originalFile.Length, originalFileInfo.Size);
                    using (StreamReader originalReader = new StreamReader(originalFile))
                    using (StreamReader uploadedReader = new StreamReader(uploadedFile))
                    {
                        string originalString = originalReader.ReadToEnd();
                        string uploadedString = uploadedReader.ReadToEnd();
                        Assert.AreEqual(originalString, uploadedString);
                        Assert.AreEqual(originalString, originalFileInfo.Path.Trim('/'));
                        Assert.AreEqual(originalString.Replace(this.OriginalDataFolder, folder),
                            uploadedFileInfo.Path.Trim('/'));
                    }
                }
            }
            finally
            {
                this.ImagingApi.DeleteFile(new DeleteFileRequest($"{folder}/{file}", this.TestStorage));
                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest($"{folder}/{file}", this.TestStorage)).Exists.Value);

                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);
            }
        }

        [Test]
        public void FileVersionsCreateTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file1 = "Storage.txt";
            var file2 = "Folder1/Folder1.txt";

            var file1Size = this.ImagingApi.GetFilesList(new GetFilesListRequest($"{this.OriginalDataFolder}", this.TestStorage))
                .Value.Find(f => f.Name == file1).Size;
            var file2Size = this.ImagingApi.GetFilesList(new GetFilesListRequest($"{this.OriginalDataFolder}/Folder1", this.TestStorage))
                .Value.Find(f => f.Name == "Folder1.txt").Size;

            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file1}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file2}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                var versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                Assert.AreEqual(2, versions.Count);
                var recentVersion = versions.Find(v => v.IsLatest.Value);
                var oldVersion = versions.Find(v => !v.IsLatest.Value);
                var recentVersionSize = recentVersion.Size;
                var oldVersionSize = oldVersion.Size;
                Assert.AreNotEqual(recentVersionSize, oldVersionSize);
                Assert.AreEqual(oldVersionSize, file1Size);
                Assert.AreEqual(recentVersionSize, file2Size);
            }
            finally
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }
            }
        }

        [Test]
        public void FileVersionsDownloadTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file1 = "Storage.txt";
            var file2 = "Folder1/Folder1.txt";

            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file1}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file2}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                var versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                var recentVersion = versions.Find(v => v.IsLatest.Value);
                var oldVersion = versions.Find(v => !v.IsLatest.Value);
                var recentVersionSize = recentVersion.Size;
                var oldVersionSize = oldVersion.Size;

                using (var oldFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{folder}/{file1}", this.TestStorage,
                        oldVersion.VersionId)))
                {
                    Assert.AreEqual(oldVersionSize, oldFile.Length);
                }

                using (var recentFile =
                    this.ImagingApi.DownloadFile(new DownloadFileRequest($"{folder}/{file1}", this.TestStorage,
                        recentVersion.VersionId)))
                {
                    Assert.AreEqual(recentVersionSize, recentFile.Length);
                }
            }
            finally
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }
            }
        }

        [Test]
        public void FileVersionsCopyTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file1 = "Storage.txt";
            var file2 = "Folder1/Folder1.txt";

            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file1}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file2}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                var versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                var recentVersion = versions.Find(v => v.IsLatest.Value);
                var oldVersion = versions.Find(v => !v.IsLatest.Value);

                this.ImagingApi.CopyFile(new CopyFileRequest($"{folder}/{file1}", $"{folder}/{file1}.recent",
                    this.TestStorage, this.TestStorage, recentVersion.VersionId));
                var copiedVersions =
                    this.ImagingApi
                        .GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}.recent", this.TestStorage))
                        .Value;
                Assert.AreEqual(1, copiedVersions.Count);
                Assert.IsTrue(copiedVersions[0].IsLatest.Value);
                Assert.AreEqual(recentVersion.Size, copiedVersions[0].Size);

                this.ImagingApi.CopyFile(new CopyFileRequest($"{folder}/{file1}", $"{folder}/{file1}.old",
                    this.TestStorage, this.TestStorage, oldVersion.VersionId));
                copiedVersions =
                    this.ImagingApi
                        .GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}.old", this.TestStorage))
                        .Value;
                Assert.AreEqual(1, copiedVersions.Count);
                Assert.IsTrue(copiedVersions[0].IsLatest.Value);
                Assert.AreEqual(oldVersion.Size, copiedVersions[0].Size);
            }
            finally
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }
            }
        }

        [Test]
        public void FileVersionsMoveTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file1 = "Storage.txt";
            var file2 = "Folder1/Folder1.txt";

            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file1}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file2}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                var versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                var recentVersion = versions.Find(v => v.IsLatest.Value);

                this.ImagingApi.MoveFile(new MoveFileRequest($"{folder}/{file1}", $"{folder}/{file1}.recent",
                    this.TestStorage, this.TestStorage, recentVersion.VersionId));
                var copiedVersions =
                    this.ImagingApi
                        .GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}.recent", this.TestStorage))
                        .Value;
                Assert.AreEqual(1, copiedVersions.Count);
                Assert.IsTrue(copiedVersions[0].IsLatest.Value);
                Assert.AreEqual(recentVersion.Size, copiedVersions[0].Size);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file1}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file2}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                var oldVersion = versions.Find(v => !v.IsLatest.Value);
                this.ImagingApi.MoveFile(new MoveFileRequest($"{folder}/{file1}", $"{folder}/{file1}.old",
                    this.TestStorage, this.TestStorage, oldVersion.VersionId));
                copiedVersions =
                    this.ImagingApi
                        .GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}.old", this.TestStorage))
                        .Value;
                Assert.AreEqual(1, copiedVersions.Count);
                Assert.IsTrue(copiedVersions[0].IsLatest.Value);
                Assert.AreEqual(oldVersion.Size, copiedVersions[0].Size);
            }
            finally
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }
            }
        }

        [Test]
        public void FileVersionsDeleteTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            var file1 = "Storage.txt";
            var file2 = "Folder1/Folder1.txt";

            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file1}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                this.ImagingApi.CopyFile(
                    new CopyFileRequest($"{this.OriginalDataFolder}/{file2}", $"{folder}/{file1}", this.TestStorage,
                        this.TestStorage));
                var versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                var recentVersion = versions.Find(v => v.IsLatest.Value);
                var oldVersion = versions.Find(v => !v.IsLatest.Value);
                Assert.IsTrue(this.ImagingApi
                    .ObjectExists(new ObjectExistsRequest($"{folder}/{file1}", this.TestStorage,
                        recentVersion.VersionId)).Exists.Value);
                Assert.IsTrue(this.ImagingApi
                    .ObjectExists(new ObjectExistsRequest($"{folder}/{file1}", this.TestStorage,
                        oldVersion.VersionId)).Exists.Value);

                this.ImagingApi.DeleteFile(new DeleteFileRequest($"{folder}/{file1}", this.TestStorage,
                    recentVersion.VersionId));
                versions =
                    this.ImagingApi.GetFileVersions(new GetFileVersionsRequest($"{folder}/{file1}", this.TestStorage))
                        .Value;
                Assert.IsFalse(this.ImagingApi
                    .ObjectExists(new ObjectExistsRequest($"{folder}/{file1}", this.TestStorage, 
                        recentVersion.VersionId)).Exists.Value);
                Assert.IsTrue(this.ImagingApi
                    .ObjectExists(new ObjectExistsRequest($"{folder}/{file1}", this.TestStorage,
                        oldVersion.VersionId)).Exists.Value);
                Assert.AreEqual(1, versions.Count);
                Assert.AreEqual(oldVersion.Size, versions[0].Size);

                this.ImagingApi.DeleteFile(new DeleteFileRequest($"{folder}/{file1}", this.TestStorage,
                    oldVersion.VersionId));
                Assert.IsFalse(this.ImagingApi
                    .ObjectExists(new ObjectExistsRequest($"{folder}/{file1}", this.TestStorage)).Exists.Value);
            }
            finally
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }
            }
        }
    }
}
