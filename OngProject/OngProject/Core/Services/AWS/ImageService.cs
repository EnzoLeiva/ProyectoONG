using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices.AWS;

namespace OngProject.Core.Services.AWS
{
    public class ImageService : IImagenService
    {
        private S3AwsHelper _s3AwsHelper;

        public ImageService()
        {
            _s3AwsHelper = new S3AwsHelper();
        }

        public async Task<String> Save(string fileName, IFormFile image)
        {
            if (image != null && ValidateFiles.ValidateImage(image))
            {
                AwsManagerResponse responseAws = await _s3AwsHelper.AwsUploadFile(fileName, image);
                if (String.IsNullOrEmpty(responseAws.Errors))
                {
                    return null;
                }

                return responseAws.Url;
            }
            else
                return null;
        }

        public async Task<bool> Delete(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                AwsManagerResponse responseAws = await _s3AwsHelper.AwsFileDelete(name);
                if (!String.IsNullOrEmpty(responseAws.Errors))
                    return false;

                return true;
            }
            

        }
       
    }
}
