using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizelineGoBootcampChallenge.Controllers;
using WizelineGoBootcampChallenge.Models;
using WizelineGoBootcampChallenge.Services.Movies;
using WizelineGoBootcampChallengeTests.Mocks;
using Xunit;

namespace WizelineGoBootcampChallengeTests
{
    public class MovieControllerTest
    {
        private readonly MovieController _controller;
        private readonly IMoviesService _service;

        public MovieControllerTest()
        {
            _service = new MoviesServiceFake();
            _controller = new MovieController(_service);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var result = await _controller.Get();

            // Assert
            var items = Assert.IsType<List<Movie>>(result);
            Assert.Equal(2, items.Count);
        }
    }
}
