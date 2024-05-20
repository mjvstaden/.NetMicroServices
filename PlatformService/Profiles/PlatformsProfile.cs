﻿using AutoMapper;
using PlatformService.Dtos;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
      public PlatformsProfile()
      {
        // Source -> Target
        CreateMap<Models.Platform, PlatformReadDto>();
        CreateMap<PlatformCreateDto, Models.Platform>();
      }
    }
}
