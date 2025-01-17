﻿namespace FileTypeChecker.App.MyCustomTypes
{
    using FileTypeChecker;
    using FileTypeChecker.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MyCustomFileType : FileType
    {
        private const string name = "My Super Cool Custom Type 1.0";
        private const string extension = "ext";
        private static readonly MagicSequence magicBytes = new(new byte[] { 0xAF });

        public MyCustomFileType() : base(name, extension, magicBytes)
        {
        }
    }
}
