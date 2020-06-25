using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [Route("api/codes")]
    [ApiController]
    public class CodesController : ControllerBase
    {
        private readonly ICodeRepo _repository;
        private readonly IMapper _mapper;

        public CodesController(ICodeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        //GET api/codes/
        [HttpGet]
        public ActionResult <IEnumerable<CodeReadDto>> GetAllCodes()
        {
            var commanItems = _repository.GetAllCodes();
            return Ok(_mapper.Map<IEnumerable<CodeReadDto>>(commanItems));
        }

        //GET api/codes/{id}
        [HttpGet("{id}", Name="GetCodeById")]
        public ActionResult <CodeReadDto> GetCodeById(int id)
        {
            var commanItem = _repository.GetCodeById(id);
            if (commanItem != null)
            {
                return Ok(_mapper.Map<CodeReadDto>(commanItem));
            }
            return NotFound();
        }

        //GET api/codes/{id}
        [HttpGet("{id}", Name="GetCodeEnterpriseById")]
        public ActionResult <CodeReadDto> GetCodeEnterpriseById(Enterprise id)
        {
            var commanItem = _repository.GetCodeEnterpriseById(id);
            if (commanItem != null)
            {
                return Ok(_mapper.Map<CodeReadDto>(commanItem));
            }
            return NotFound();
        }

        //POST api/codes
        [HttpPost]
        public ActionResult <CodeReadDto> CreateCode(CodeCreateDto  codeCreateDto)
        {
            var codeModel = _mapper.Map<Code>(codeCreateDto);
            _repository.CreateCode(codeModel);
            _repository.SaveChanges();

            var codeReadDto = _mapper.Map<CodeReadDto>(codeModel);
            
            return CreatedAtRoute(nameof(GetCodeById), new {Id=codeReadDto.Id}, codeReadDto);

        }


        //PATCH api/codes/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCodeUpdate(int id, JsonPatchDocument<CodeUpdateDto> patchDoc)
        {
            var codeModelFromRepo = _repository.GetCodeById(id);
            if (codeModelFromRepo== null)
            {
                return NotFound();
            }

            var codeToPatch = _mapper.Map<CodeUpdateDto>(codeModelFromRepo);
            patchDoc.ApplyTo(codeToPatch, ModelState);

            if (!TryValidateModel(codeToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(codeToPatch, codeModelFromRepo);

            _repository.UpdateCode(codeModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }        

    }

}