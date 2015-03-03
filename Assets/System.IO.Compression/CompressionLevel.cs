///------------------------------------------------------------------------------
/// <copyright file="CompressionLevel.cs" company="Microsoft">
///     Copyright (c) Microsoft Corporation.  All rights reserved.
/// </copyright>                               
///
/// <owner>gpaperin</owner>
///------------------------------------------------------------------------------

#if !NETFX_CORE
namespace System.IO.Compression {

    /// <summary>
    /// Defines a tradeoff between fast vs. strong compression. The specific meaning depends of the Deflater implementation.
    /// </summary>
    
    // This is an abstract concept and NOT the ZLib compression level.
    // There may or may not be any correspondance with the a possible implementation-specific level-parameter of the deflater.
    public enum CompressionLevel {

        Optimal = 0,
        Fastest = 1,
        NoCompression = 2

    }  // internal enum CompressionLevel

}  // namespace System.IO.Compression

// CompressionLevel.cs
#endif