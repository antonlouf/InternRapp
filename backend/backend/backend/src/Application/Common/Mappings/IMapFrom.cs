﻿using AutoMapper;

namespace backend.Application.Common.Mappings;
public interface IMapFrom<T>
{
    void Mapping(Profile profile);
}
