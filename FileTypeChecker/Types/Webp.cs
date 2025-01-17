﻿using FileTypeChecker.Abstracts;

namespace FileTypeChecker.Types
{
    public class Webp : FileType, IFileType
    {
        public const string TypeName = "WebP image";
        public const string TypeExtension = "webp";
        private static readonly byte[] magicBytes = new byte[] { 0x52, 0x49, 0x46, 0x46, 0x00, 0x00, 0x00, 0x00, 0x57, 0x45, 0x42, 0x50, 0x56, 0x50, 0x38 };


        public Webp() : base(TypeName, TypeExtension, new MagicSequence(magicBytes, 4, 4)) { }
    }
}
