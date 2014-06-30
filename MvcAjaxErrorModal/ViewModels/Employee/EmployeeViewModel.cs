using System;
using Autofac;
using AutoMapper;
using Core.Domain;

namespace MvcAjaxErrorModal.ViewModels.Employee
{
    public class EmployeeViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
    }

    public class EmployeeViewModelMapper : IStartable
    {
        public void Start()
        {
            Mapper.CreateMap<EmployeeDto, EmployeeViewModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dst => dst.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dst => dst.Age, opt => opt.MapFrom(src => src.Age))
                .ForMember(dst => dst.Mobile, opt => opt.MapFrom(src => src.Mobile));
        }
    }
}