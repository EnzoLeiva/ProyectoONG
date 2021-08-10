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

        public async Task<String> saveImage(IFormFile image)
        {
            AwsManagerResponse response = await _s3AwsHelper.AwsUploadFile(image.FileName, image);
            if (response.Code != 200)
            {
                return null;
            }
            return response.Url;
        }

        /*
         *  CategoryModel category = await GetById(Id);
                AwsManagerResponse responseAws = await _s3AwsHelper.AwsFileDelete(category.Image);
                if (responseAws.Code != 200)
                    return false;*/
    }
}
