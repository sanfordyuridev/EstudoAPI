using AutoMapper;
using EstudoAPI.Domain.Dto;
using EstudoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAPI.Service.AutoMapper
{
    public class AutoMapping : Profile
    {

        public AutoMapping() 
        {
            CreateMap<Pessoa, PessoaDto>()
                .ReverseMap();
        }

    }
}
