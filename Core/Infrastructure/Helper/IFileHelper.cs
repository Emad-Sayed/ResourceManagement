using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Helper
{
    public interface IFileHelper
    {
        string SaveImage(string ImgStr, string ImgName, string folderName,string rootPath);
        bool DeleteImage(string fullPath);
    }
}
