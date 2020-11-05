using Core.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure.Helper
{
    public class FileHelper : IFileHelper
    {
        public string SaveImage(string ImgStr, string ImgName, string folderName,string rootPath)
        {
            var path = Path.Combine(rootPath, folderName);
            // Check if directory exist or not
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);//Create directory if it doesn't exist
            }

            string imageName = ImgName + ".jpg";

            //set the image path
            string imgPath = Path.Combine(path, imageName);

            byte[] imageBytes = Convert.FromBase64String(ImgStr);

            File.WriteAllBytes(imgPath, imageBytes);

            return "wwwroot/"+folderName+"/"+imageName;
        }
        public bool DeleteImage(string fullPath)
        {
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
                return true; 
            }
            return false;
        }

    }
}
