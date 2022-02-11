﻿using AutoMapper;
using BugTracker.Application.Dto;
using BugTracker.Application.Dto.Projects;
using BugTracker.Application.Features.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.Features.Projects.Commands.Update;
using BugTracker.Application.Features.Projects.Queries;
using BugTracker.Application.Features.Tickets.Commands.Create;
using BugTracker.Application.ViewModel;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using System.Linq;

namespace BugTracker.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region project
            CreateMap<CreateProjectCommand, Project>();
            CreateMap<UpdateProjectCommand, Project>();
            CreateMap<ProjectWithTeamDto, ProjectVm>()
                .ForMember(dest => dest.TeamNames, opt => opt.MapFrom(src => src.Team.Select(teamMember => teamMember.UserName)))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Project.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Project.Description))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Project.Id));

            CreateMap<Project, ProjectVm>()
                .ForMember(dest => dest.TeamNames, opt => opt.MapFrom(src => src.Name));
            CreateMap<Project, ProjectWithTicketsAndTeamVm>();
            CreateMap<Project, ProjectWithTeamIdsVm>();
            #endregion

            #region user
            CreateMap<ApplicationUser, UserViewModel>();
            #endregion

            #region ticket
            CreateMap<CreateTicketCommand, Ticket>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));

            #endregion
        }
    }
}
