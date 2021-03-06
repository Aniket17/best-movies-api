﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using best_movies_api.Models.ViewModels;
using best_movies_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace best_movies_api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMovieService movieService;
        private readonly IMapper mapper;

        public MoviesController(ILogger<MoviesController> logger,IMovieService movieService,IMapper mapper)
        {
            _logger = logger;
            this.movieService = movieService;
            this.mapper = mapper;
        }
        [HttpPost("find")]
        public async Task<IActionResult> GetMoviesPage([FromBody] PageRequestViewModel<MovieFilter> request) {

            try
            {
                var moviePage = await this.movieService.GetMoviesAsync(request);
                var moviesViewModel = mapper.Map<List<MovieViewModel>>(moviePage.Items);
                var page = new PageResponseViewModel<MovieViewModel>(moviesViewModel, moviePage.TotalCount);
                return Ok(page);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(new { Message = ex.ToString() });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {

            try
            {
                var movie = this.movieService.GetMovie(id);
                var moviesViewModel = mapper.Map<MovieViewModel>(movie);
                return Ok(moviesViewModel);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(new { Message = ex.ToString() });
            }
        }
    }
}
