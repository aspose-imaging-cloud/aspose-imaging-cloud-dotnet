//-----------------------------------------------------------------------------------------------------------
// <copyright file="FilesList.cs" company="Aspose Pty Ltd." author="Maksym Shnurenok" date="16.03.2018 17:16:56">
//    Copyright (c) 2001-2017 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Cloud.Sdk.Test.Base
{
    using System.Collections.Generic;

    /// <summary>
    /// Files list class for storage API response.
    /// </summary>
    public class FilesList
    {
        /// <summary>
        /// The files
        /// </summary>
        public List<StorageFileInfo> Files = new List<StorageFileInfo>();

        /// <summary>
        /// The storage file info
        /// </summary>
        public class StorageFileInfo
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether this instance is folder.
            /// </summary>
            /// <value>
            ///   <c>true</c> if this instance is folder; otherwise, <c>false</c>.
            /// </value>
            public bool IsFolder { get; set; }

            /// <summary>
            /// Gets or sets the modified date.
            /// </summary>
            /// <value>
            /// The modified date.
            /// </value>
            public string ModifiedDate { get; set; }

            /// <summary>
            /// Gets or sets the size.
            /// </summary>
            /// <value>
            /// The size.
            /// </value>
            public long Size { get; set; }

            /// <summary>
            /// Gets or sets the path.
            /// </summary>
            /// <value>
            /// The path.
            /// </value>
            public string Path { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether this instance is directory.
            /// </summary>
            /// <value>
            ///   <c>true</c> if this instance is directory; otherwise, <c>false</c>.
            /// </value>
            public bool IsDirectory { get; set; }
        }
    }
}
