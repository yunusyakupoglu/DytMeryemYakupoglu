﻿using DTOs;
using Microsoft.AspNetCore.Http;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.IServices
{
    public interface IProvidedServiceManager : IService<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ObjProvidedService>
    {
        string UploadImage(IFormFile formFile);
        string DeleteImage(string filename);
    }
}
