using System;
using System.Linq.Expressions;
using AutoMapper;
using DevAssessment.EntityFramework.Context;
using DevAssessment.DTO;

namespace DevAssessment.Core.Mapper
{
    internal static class DtoMapping
    {
        public static void Map()
        {
            AutoMapper.Mapper.Initialize(
                config =>
                {
                    config.CreateMap<Department, DepartmentDTO>().ReverseMap();
                 
                });
            

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
