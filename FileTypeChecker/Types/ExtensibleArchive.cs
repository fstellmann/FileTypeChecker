﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    internal class ExtensibleArchive : FileType, IFileType
    {
        private static readonly string name = "eXtensible ARchive format";
        private static readonly string extension = "xar";
        private static readonly byte[] magicBytes = new byte[] { 0x78, 0x61, 0x72, 0x21 };

        internal ExtensibleArchive() : base(name, extension, magicBytes)
        {
        }
    }
}
