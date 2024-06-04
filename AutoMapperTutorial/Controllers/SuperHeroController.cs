using AutoMapper;
using AutoMapperTutorial.Models;
using AutoMapperTutorial.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHeroModel> heroDataBase = new List<SuperHeroModel>() {
            new SuperHeroModel()
            {
                Id = 1,
                HeroName = "IronMan",
                FirstName = "Tony",
                LastName = "Stark",
                Active_City = "NewYork City",
                isActive = false
            },

            new SuperHeroModel()
            {
                Id = 2,
                HeroName = "Batman",
                FirstName = "Bruce",
                LastName = "Wayne",
                Active_City = "Gotham City",
                isActive = false
            },

            new SuperHeroModel()
            {
                Id = 3,
                HeroName = "Flash",
                FirstName = "Barry",
                LastName = "Allen",
                Active_City = "Star City",
                isActive = true
            },

            new SuperHeroModel()
            {
                Id = 4,
                HeroName = "Captain America",
                FirstName = "Steve",
                LastName = "Rogers",
                Active_City = "NewYork City",
                isActive = false
            }
        };

        private readonly IMapper _mapper;

        public SuperHeroController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("AdminView")]
        public List<SuperHeroModel> GetHeroData()
        {
            return heroDataBase;
        }

        [HttpGet("UserView")]
        public ActionResult GetData()
        {
            var heroData = heroDataBase.Select(_mapper.Map<HeroDTOs>);

            return Ok(heroData);
        }

        [HttpPost]
        public ActionResult PostData(HeroDTOs newHero)
        {
            var newEntry = _mapper.Map<SuperHeroModel>(newHero);
            heroDataBase.Add(newEntry);

            var heroData = heroDataBase.Select(_mapper.Map<HeroDTOs>);
            return Ok(heroData);
        }
    }
}