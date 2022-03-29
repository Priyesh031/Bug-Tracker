﻿using BugTracker.Application.Features.Projects.Queries.GetAll;
using BugTracker.Application.Features.Tickets.Queries.GetTicketDiagramDataByUser;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {

        }
        public async Task<IActionResult> DashBoard(bool isSuccess = false, string type = null, string actionReturned = null)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.type = type;
            ViewBag.actionReturned = actionReturned;
            var viewModel = new DashboardViewModel();

            var projectResponse = await Mediator.Send(new GetAllProjectQuery());

            viewModel.Projects = projectResponse.DataList;

            return View(viewModel);
        }

        [Produces("application/json")]
        public async Task<IActionResult> GetDiagramsData()
        {
            var response = await Mediator.Send(new GetTicketDiagramDataByUserQuery());
            return Json(response.Data);
        }
    }
}
