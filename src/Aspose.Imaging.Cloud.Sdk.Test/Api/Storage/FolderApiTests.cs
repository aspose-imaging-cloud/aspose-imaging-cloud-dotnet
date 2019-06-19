// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderApiTests.cs">
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
    using NUnit.Framework;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    /// Specific folder API tests for Storage.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Test.Api.Storage.StorageApiTester" />
    [Category("Folder")]
    public class FolderApiTests : StorageApiTester
    {
        [Test]
        public void CreateFolderTest()
        {
            var folder = $"{this.TempFolder}/DummyFolder";
            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CreateFolder(new CreateFolderRequest(folder, this.TestStorage));
                Assert.IsTrue(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);
            }
            finally
            {
                if (this.ImagingApi.ObjectExists(new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);
            }
        }

        [Test]
        public void CopyFolderTest()
        {
            var folder = $"{this.TempFolder}/Storage";
            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFolder(
                    new CopyFolderRequest(this.OriginalDataFolder, folder, this.TestStorage, this.TestStorage));
                Assert.IsTrue(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);
                var originalFiles = this.ImagingApi.GetFilesList(
                    new GetFilesListRequest(this.OriginalDataFolder, this.TestStorage)).Value;
                var copiedFiles = this.ImagingApi.GetFilesList(
                    new GetFilesListRequest(folder, this.TestStorage)).Value;
                Assert.Greater(originalFiles.Count, 0);
                Assert.Greater(copiedFiles.Count, 0);
                Assert.AreEqual(originalFiles.Count, copiedFiles.Count);
                int count = originalFiles.Count;
                for (int x = 0; x < count; x++)
                {
                    Assert.AreEqual(originalFiles[x].IsFolder, copiedFiles[x].IsFolder);
                    Assert.AreEqual(originalFiles[x].Name, copiedFiles[x].Name);
                    Assert.AreEqual(originalFiles[x].Size, copiedFiles[x].Size);
                }
            }
            finally
            {
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
        public void MoveFolderTest()
        {
            var tmpFolder = $"{this.TempFolder}/Temp";
            var folder = $"{this.TempFolder}/Storage";
            try
            {
                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(folder, this.TestStorage, true));
                }

                if (this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(tmpFolder, this.TestStorage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFolder(new DeleteFolderRequest(tmpFolder, this.TestStorage, true));
                }

                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(tmpFolder, this.TestStorage)).Exists.Value);
                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                this.ImagingApi.CopyFolder(
                    new CopyFolderRequest(this.OriginalDataFolder, tmpFolder, this.TestStorage, this.TestStorage));
                Assert.IsTrue(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(tmpFolder, this.TestStorage)).Exists.Value);

                this.ImagingApi.MoveFolder(
                    new MoveFolderRequest(tmpFolder, folder, this.TestStorage, this.TestStorage));
                Assert.IsFalse(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(tmpFolder, this.TestStorage)).Exists.Value);
                Assert.IsTrue(this.ImagingApi.ObjectExists(
                    new ObjectExistsRequest(folder, this.TestStorage)).Exists.Value);

                var originalFiles = this.ImagingApi.GetFilesList(
                    new GetFilesListRequest(this.OriginalDataFolder, this.TestStorage)).Value;
                var copiedFiles = this.ImagingApi.GetFilesList(
                    new GetFilesListRequest(folder, this.TestStorage)).Value;
                Assert.Greater(originalFiles.Count, 0);
                Assert.Greater(copiedFiles.Count, 0);
                Assert.AreEqual(originalFiles.Count, copiedFiles.Count);
                int count = originalFiles.Count;
                for (int x = 0; x < count; x++)
                {
                    Assert.AreEqual(originalFiles[x].IsFolder, copiedFiles[x].IsFolder);
                    Assert.AreEqual(originalFiles[x].Name, copiedFiles[x].Name);
                    Assert.AreEqual(originalFiles[x].Size, copiedFiles[x].Size);
                }
            }
            finally
            {
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
        public void FilesListTest()
        {
            var files = this.ImagingApi.GetFilesList(new GetFilesListRequest(this.OriginalDataFolder,
                this.TestStorage)).Value;
            Assert.AreEqual(3, files.Count);
            var folder1 = files.Find(f => f.Name == "Folder1");
            Assert.NotNull(folder1);
            Assert.IsTrue(folder1.IsFolder.Value);
            Assert.IsTrue(folder1.Path.Trim('/').EndsWith(folder1.Name));
            var folder2 = files.Find(f => f.Name == "Folder2");
            Assert.NotNull(folder2);
            Assert.IsTrue(folder2.IsFolder.Value);
            Assert.IsTrue(folder2.Path.Trim('/').EndsWith(folder2.Name));
            var storageFile = files.Find(f => f.Name == "Storage.txt");
            Assert.NotNull(storageFile);
            Assert.IsFalse(storageFile.IsFolder.Value);
            Assert.IsTrue(storageFile.Path.Trim('/').EndsWith(storageFile.Name));
            Assert.AreEqual(storageFile.Size, storageFile.Path.Trim('/').Length);

            files = this.ImagingApi.GetFilesList(new GetFilesListRequest($"{this.OriginalDataFolder}/{folder1.Name}",
                this.TestStorage)).Value;
            Assert.AreEqual(1, files.Count);
            var folder1File = files.Find(f => f.Name == "Folder1.txt");
            Assert.NotNull(folder1File);
            Assert.IsFalse(folder1File.IsFolder.Value);
            Assert.IsTrue(folder1File.Path.Trim('/').EndsWith(folder1File.Name));
            Assert.AreEqual(folder1File.Size, folder1File.Path.Trim('/').Length);

            files = this.ImagingApi.GetFilesList(new GetFilesListRequest($"{this.OriginalDataFolder}/{folder2.Name}",
                this.TestStorage)).Value;
            Assert.AreEqual(2, files.Count);
            var folder2File = files.Find(f => f.Name == "Folder2.txt");
            Assert.NotNull(folder2File);
            Assert.IsFalse(folder2File.IsFolder.Value);
            Assert.IsTrue(folder2File.Path.Trim('/').EndsWith(folder2File.Name));
            Assert.AreEqual(folder2File.Size, folder1File.Path.Trim('/').Length);
            var folder3 = files.Find(f => f.Name == "Folder3");
            Assert.NotNull(folder3);
            Assert.IsTrue(folder3.IsFolder.Value);
            Assert.IsTrue(folder3.Path.Trim('/').EndsWith(folder3.Name));

            files = this.ImagingApi.GetFilesList(new GetFilesListRequest(
                $"{this.OriginalDataFolder}/{folder2.Name}/{folder3.Name}",
                this.TestStorage)).Value;
            Assert.AreEqual(1, files.Count);
            var folder3File = files.Find(f => f.Name == "Folder3.txt");
            Assert.NotNull(folder3File);
            Assert.IsFalse(folder3File.IsFolder.Value);
            Assert.IsTrue(folder3File.Path.Trim('/').EndsWith(folder3File.Name));
            Assert.AreEqual(folder3File.Size, folder3File.Path.Trim('/').Length);
        }
    }
}
