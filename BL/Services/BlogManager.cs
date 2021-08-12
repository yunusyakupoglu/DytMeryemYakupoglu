﻿using AutoMapper;
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
    public class BlogManager : Service<BlogCreateDto, BlogUpdateDto, BlogListDto, ObjBlog>, IBlogManager
    {
        public BlogManager(IMapper mapper, IValidator<BlogCreateDto> createDtoValidator, IValidator<BlogUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : 
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}