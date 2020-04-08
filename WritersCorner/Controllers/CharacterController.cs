using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Mappers.CharacterM;
using WritersCorner.Models.CharacterVM;
using WritersCorner.Service.Contracts;

namespace WritersCorner.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterServices _characterServices;

        public CharacterController(ICharacterServices characterServices)
        {
            this._characterServices = characterServices;
        }

        public async Task<IActionResult> Index(int? currentPage, string search = null)
        {
            try
            {
                string userId = FindUserById();

                int currPage = currentPage ?? 1;
                int totalPages = await _characterServices.GetPageCount(10);

                IEnumerable<Character> characterAllResults = null;

                if (!string.IsNullOrEmpty(search))
                {
                    //For character search
                    characterAllResults = await _characterServices.SearchCharacter(search, currPage, userId);
                }
                else
                {
                    characterAllResults = await _characterServices.GetAllCharactersAsync(currPage);
                }

                IEnumerable<CharacterViewModel> characterListing = characterAllResults
                    .Select(m => CharacterMapper.MapCharacter(m));
                CharacterIndexViewModel emailModel = CharacterMapper.MapFromCharacterIndex(characterListing,
                    currPage, totalPages);

                //For pagination buttons and distribution
                emailModel.CurrentPage = currPage;
                emailModel.TotalPages = totalPages;

                if (totalPages > currPage)
                {
                    emailModel.NextPage = currPage + 1;
                }

                if (currPage > 1)
                {
                    emailModel.PreviousPage = currPage - 1;
                }

                return View(emailModel);
            }
            catch (Exception e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }

        public async Task<IActionResult> Detail(int characterId)
        {
            try
            {
                Character character = await _characterServices.GetCharacterAsync(characterId);
                CharacterViewModel userModel = CharacterMapper.MapCharacter(character);

                return View("Detail", userModel);
            }
            catch (Exception e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }


        public async Task<IActionResult> EditCharacter(int characterId)
        {
            try
            {
                Character character = await _characterServices.GetCharacterAsync(characterId);

                return View("Detail", character);
            }
            catch (Exception e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }

        public async Task<IActionResult> UserCharacters(int? currentPage, string search = null)
        {
            try
            {
                string userId = FindUserById();

                int currPage = currentPage ?? 1;
                int totalPages = await _characterServices.GetPageCount(10);

                IEnumerable<Character> characterAllResults = null;

                if (!string.IsNullOrEmpty(search))
                {
                    //For character search
                    characterAllResults = await _characterServices.SearchCharacter(search, currPage, userId);
                }
                else
                {
                    characterAllResults = await _characterServices.GetAllUserCharactersAsync(currPage, userId);
                }

                IEnumerable<CharacterViewModel> characterListing = characterAllResults
                    .Select(m => CharacterMapper.MapCharacter(m));
                CharacterIndexViewModel emailModel = CharacterMapper.MapFromCharacterIndex(characterListing,
                    currPage, totalPages);

                //For pagination buttons and distribution
                emailModel.CurrentPage = currPage;
                emailModel.TotalPages = totalPages;

                if (totalPages > currPage)
                {
                    emailModel.NextPage = currPage + 1;
                }

                if (currPage > 1)
                {
                    emailModel.PreviousPage = currPage - 1;
                }

                return View(emailModel);
            }
            catch (Exception e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }

        public string FindUserById()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return userId;
        }
    }
}