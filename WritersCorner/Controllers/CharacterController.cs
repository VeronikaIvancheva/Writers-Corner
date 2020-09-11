﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Mappers.CharacterM;
using WritersCorner.Models.CharacterVM;
using WritersCorner.Service.Contracts;
using WritersCorner.Service.CustomException;
using WritersCorner.Service.Providers;

namespace WritersCorner.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterServices _characterServices;
        private readonly IFileService _fileService;

        public CharacterController(ICharacterServices characterServices, IFileService fileService)
        {
            this._characterServices = characterServices;
            this._fileService = fileService;
        }

        public async Task<IActionResult> Index(int? currentPage, string search = null)
        {
            try
            {
                string userId = FindCurrentUserId();

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
                CharacterIndexViewModel characterIVM = CharacterMapper.MapFromCharacterIndex(characterListing,
                    currPage, totalPages);

                #region For pagination buttons and distribution
                characterIVM.CurrentPage = currPage;
                characterIVM.TotalPages = totalPages;

                if (totalPages > currPage)
                {
                    characterIVM.NextPage = currPage + 1;
                }

                if (currPage > 1)
                {
                    characterIVM.PreviousPage = currPage - 1;
                }
                #endregion

                return View(characterIVM);
            }
            catch (GlobalException e)
            {
                //TODO
                return BadRequest(e.Message);
                //ModelState.AddModelError(string.Empty, ExceptionMessage.GlobalErrorMessage);
                //return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Detail(int Id)
        {
            try
            {
                Character character = await _characterServices.GetCharacterAsync(Id);
                CharacterViewModel userModel = CharacterMapper.MapCharacter(character);

                return View("Detail", userModel);
            }
            catch (GlobalException e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CharacterViewModel viewModel)
        {
            try
            {
                SaveFile(viewModel);

                string userId = FindCurrentUserId();

                Character mapCharacter = CharacterMapper.MapCharacter(viewModel);
                Character character = await _characterServices.CreateCharacterAsync(mapCharacter, userId);

                return RedirectToAction("Index", new { id = character.Id });
            }
            catch (GlobalException e)
            {
                //return BadRequest(e.Message);
                return NotFound();
            }
        }

        //За пълнене на формата със стойности
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id)
        {
            Character character = await _characterServices.GetCharacterAsync(Id);
            CharacterViewModel mapCharacter = CharacterMapper.MapCharacter(character);

            return View("Edit", mapCharacter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCharacter(CharacterViewModel viewModel)
        {
            try
            {
                Character mapCharacterToCharacter = CharacterMapper.MapCharacter(viewModel);
                Character character = await _characterServices.EditCharacterAsync(mapCharacterToCharacter);
                CharacterViewModel mapCharacter = CharacterMapper.MapCharacter(character);

                return View("Detail", mapCharacter);
            }
            catch (GlobalException e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCharacter(int Id)
        {
            try
            {
                //TODO: Да направя confirm прозорец при триене
                string userId = FindCurrentUserId();
                await _characterServices.DeleteCharacterAsync(Id, userId);

                return RedirectToAction("Index");
            }
            catch (GlobalException e)
            {
                //return NotFound();
                return BadRequest(e.Message);
            }
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserCharacters(int? currentPage, string search = null)
        {
            try
            {
                string userId = FindCurrentUserId();

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
                CharacterIndexViewModel characterIVM = CharacterMapper.MapFromCharacterIndex(characterListing,
                    currPage, totalPages);

                #region For pagination buttons and distribution
                characterIVM.CurrentPage = currPage;
                characterIVM.TotalPages = totalPages;

                if (totalPages > currPage)
                {
                    characterIVM.NextPage = currPage + 1;
                }

                if (currPage > 1)
                {
                    characterIVM.PreviousPage = currPage - 1;
                }
                #endregion

                return View(characterIVM);
            }
            catch (GlobalException e)
            {
                //TODO
                return BadRequest(e.Message);
            }
        }

        public string FindCurrentUserId()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return userId;
        }

        public void SaveFile(CharacterViewModel viewModel)
        {
            if (viewModel.ImagePath != null)
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Pictures\\Images\\CharacterImages");
                _fileService.CreateFolder(uploadsFolder);

                string imageName = Path.GetFileName(viewModel.File.FileName);
                string fullFilePath = Path.Combine(uploadsFolder, imageName);

                viewModel.ImagePath = imageName;

                using (FileStream stream = new FileStream(fullFilePath, FileMode.Create))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        viewModel.File.CopyToAsync(memoryStream);
                        byte[] x = memoryStream.ToArray();
                        stream.Write(x, 0, x.Length);
                    }
                }
            }
            else
            {
                viewModel.ImagePath = "default.png";
            }
        }
    }
}