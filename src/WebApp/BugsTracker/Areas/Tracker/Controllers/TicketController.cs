﻿using BugTracker.Application.Dto.Tickets;
using BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers;
using BugTracker.Application.Features.TicketConfigurations.Queries.GetAll;
using BugTracker.Application.Features.Tickets.Commands.Create;
using BugTracker.Application.Features.Tickets.Commands.Delete;
using BugTracker.Application.Features.Tickets.Commands.Update;
using BugTracker.Application.Features.Tickets.Queries.GetProjectTickets;
using BugTracker.Application.Features.Tickets.Queries.GetTicket;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]

    public class TicketController : BaseController
    {
        private const string ModalBasePath = "~/Areas/Tracker/Views/Shared/Partial/Ticket/";
        private const string ModalType = "TicketModalPartial.cshtml";
        private const string CreateModalPath = ModalBasePath + "_create" + ModalType;
        private const string UpdateModalPath = ModalBasePath + "_update" + ModalType;
        private const string DeleteModalPath = ModalBasePath + "_delete" + ModalType;

        public IActionResult GetAll()
        {
            return View();
        }

        public async Task<IActionResult> ByProject(Guid projectId, bool isSuccess = false, bool isFailed = false, string type = null, string action = null)
        {
            ViewBag.Type = type;
            ViewBag.Action = action;

            var response = await Mediator.Send(new GetProjectTicketsQuery(projectId));
            return View("ProjectTickets", response.Data);
        }
        public async Task<IActionResult> Create(CreateTicketCommand command)
        {
            var response = await Mediator.Send(command);
            if (response.Succeeded)
            {
                return RedirectToAction("ByProject", new {projectId = command.ProjectId, isSuccess = true, type = "ticket", action = "created" });
            }
            return RedirectToAction("ByProject", new { projectId = command.ProjectId, isFailed = true });
        }
        public async Task<IActionResult> Delete(DeleteTicketCommand command, Guid projectId)
        {
            var response = await Mediator.Send(command);
            if (response.Succeeded)
            {
                return RedirectToAction("ByProject", new { projectId = projectId, isSuccess = true, type = "ticket", action = "created" });
            }
            return RedirectToAction("ByProject", new {  isFailed = true });
        }

        public async Task<IActionResult> LoadCreateModal(Guid projectId)
        {
            var dto = new CreateTicketDto(projectId);

            var teamResponse = await Mediator.Send(new GetAllAccessibleMembersQuery());
            var ticketConfigurationResponse = await Mediator.Send(new GetAllTicketConfigurationsQuery());
            dto.Team = teamResponse.DataList;
            dto.TicketConfigurations = ticketConfigurationResponse.Data;

            return PartialView(CreateModalPath, dto);
        }
        public async Task<IActionResult> LoadUpdateModal(Guid id, Guid projectId)
        {
            var dto = new UpdateTicketDto(id);

            var ticket = (await Mediator.Send(new GetTicketQuery(id))).Data;

            var teamResponse = await Mediator.Send(new GetAllAccessibleMembersQuery());
            var ticketConfigurationResponse = await Mediator.Send(new GetAllTicketConfigurationsQuery());

            dto.Team = teamResponse.DataList;
            dto.TicketConfigurations = ticketConfigurationResponse.Data;

            dto.Command = new UpdateTicketCommand(id);
            dto.Command.Name = ticket.Name;
            dto.Command.Description = ticket.Description;
            dto.Command.PriorityId = ticket.Priority.Id;
            dto.Command.TypeId = ticket.Type.Id;
            dto.Command.StatusId = ticket.Status.Id;
            dto.Command.Team = ticket.TicketsTeamMembers.Select(ttm => ttm.Id).ToList();
            dto.Command.EstimatedAmountOfHours = ticket.EstimatedAmountOfHours;

            return PartialView(UpdateModalPath, dto);
        }
        public IActionResult LoadDeleteModal(Guid id, Guid projectId, string name)
        {
            var dto = new DeleteTicketDto(id, projectId, name);
            return PartialView(DeleteModalPath, dto);
        }
    }
}
