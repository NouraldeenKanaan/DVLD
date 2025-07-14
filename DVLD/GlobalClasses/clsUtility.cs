using System;
using System.IO;

namespace DVLD.GlobalClasses
{
    public class clsUtility
    {
        public static bool CopyImageToProjectImagesFolder(ref string SourceFile)
        {
            string DestinationFolder = @"E:\DVLD\PeopleImages\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
                return false;

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);

            try
            {
                File.Copy(SourceFile, DestinationFile);
            }
            catch (IOException e)
            {
                return false;
            }

            SourceFile = DestinationFile;

            return true;
        }
        public static bool CreateFolderIfDoesNotExist(string DestinationFolder)
        {
            if (!Directory.Exists(DestinationFolder))
            {
                Directory.CreateDirectory(DestinationFolder);
            }
            return true;
        }
        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            FileInfo fileInfo = new FileInfo(SourceFile);

            return GenerateGUID() + fileInfo.Extension;
        }
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
