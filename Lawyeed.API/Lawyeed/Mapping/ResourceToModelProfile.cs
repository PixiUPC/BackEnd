using AutoMapper;
using Lawyeed.API.Lawyeed.Domain.Models;
using Lawyeed.API.Lawyeed.Resources;
using PersonalWorld.API.Personal.Resources;

namespace Lawyeed.API.Lawyeed.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SavePersonResource, Person>();
        CreateMap<SavePersonLawyerResource, PersonLawyer>();

    }
}