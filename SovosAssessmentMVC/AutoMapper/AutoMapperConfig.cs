using AutoMapper;
using DataAccess.Models;
using SovosAssessmentMVC.Models;
using System;

namespace SovosAssessmentMVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper
        {
            get
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CaseModel, CaseViewModel>()
                    .ForMember(d => d.Id, opts => opts.MapFrom(s => s.Id))
                    .ForMember(d => d.Type, opts => opts.MapFrom(s => s.Type))
                    .ForMember(d => d.Status, opts => opts.MapFrom(s => s.Status))
                    .ForMember(d => d.Title, opts => opts.MapFrom(s => s.Title))
                    .ForMember(d => d.DateCreated, opts => opts.MapFrom(s => s.DateCreated));
                }).CreateMapper();
            }
        }
    }
}