using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VagasAPI.Model;
using VagasAPI.Service;

namespace VagasAPI.Controller
{
    [Route("~/jobs")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        private readonly IValidator<Job> _jobValidator;

        public JobController(IJobService jobService, IValidator<Job> jobValidator)
        {
            _jobService = jobService;
            _jobValidator = jobValidator;
        }
    }
}