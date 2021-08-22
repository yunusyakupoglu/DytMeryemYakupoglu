using AutoMapper;
using BL.IServices;
using DAL.UnitOfWork;
using DTOs;
using FluentValidation;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class CommentManager : Service<CommentCreateDto, CommentUpdateDto, CommentListDto, ObjComment>, ICommentManager
    {
        public CommentManager(IMapper mapper, IValidator<CommentCreateDto> createDtoValidator, IValidator<CommentUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
