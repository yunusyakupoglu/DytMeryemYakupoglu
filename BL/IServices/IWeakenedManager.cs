using DTOs;
using Microsoft.AspNetCore.Http;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.IServices
{
    public interface IWeakenedManager : IService<WeakenedCreateDto, WeakenedUpdateDto, WeakenedListDto, ObjWeakened>
    {
        string UploadImage(IFormFile formFile);
        string DeleteImage(string filename);
    }
}
