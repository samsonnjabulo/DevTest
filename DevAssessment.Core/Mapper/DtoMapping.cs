using System;
using System.Linq.Expressions;
using AutoMapper;
using DevAssessment.EntityFramework.Context;
using DevAssessment.DTO;

namespace DevAssessment.Core.Mapper
{
    public static class DtoMapping
    {
        public static bool isInitialize { get; set; }
        public static void Map()
        {
            if (!isInitialize)
            {
                AutoMapper.Mapper.Initialize(
                    config =>
                    {
                        config.CreateMap<Department, DepartmentDTO>().ReverseMap();
                    });
                isInitialize = true;
            }
            

        }

        public static IMappingExpression<TSource, TDestination> Ignore<TSource, TDestination>(
            this IMappingExpression<TSource, TDestination> map,
            Expression<Func<TDestination, object>> selector)
        {
            map.ForMember(selector, config => config.Ignore());
            return map;
        }
    }
}
