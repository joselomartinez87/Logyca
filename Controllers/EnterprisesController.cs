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

    [Route("api/enterprises")]
    [ApiController]
    public class EnterprisesController : ControllerBase
    {
        private readonly IEnterpriseRepo _repository;
        private readonly IMapper _mapper;

        public EnterprisesController(IEnterpriseRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        //GET api/enterprises/
        [HttpGet]
        public ActionResult <IEnumerable<EnterpriseReadDto>> GetAllEnterprises()
        {
            var commanItems = _repository.GetAllEnterprises();
            return Ok(_mapper.Map<IEnumerable<EnterpriseReadDto>>(commanItems));
        }

        //GET api/enterprises/{id}
        [HttpGet("{id}", Name="GetEnterpriseById")]
        public ActionResult <EnterpriseReadDto> GetEnterpriseById(int id)
        {
            var commanItem = _repository.GetEnterpriseById(id);
            if (commanItem != null)
            {
                return Ok(_mapper.Map<EnterpriseReadDto>(commanItem));
            }
            return NotFound();
        }

        //GET api/enterprises/{nit}
        [HttpGet("{id}", Name="GetEnterpriseById")]
        public ActionResult <EnterpriseReadDto> GetEnterpriseByNit(Int64 nit)
        {
            var commanItem = _repository.GetEnterpriseByNit(nit);
            if (commanItem != null)
            {
                return Ok(_mapper.Map<EnterpriseReadDto>(commanItem));
            }
            return NotFound();
        }

        //POST api/enterprises
        [HttpPost]
        public ActionResult <EnterpriseReadDto> CreateEnterprise(EnterpriseCreateDto  enterpriseCreateDto)
        {
            var enterpriseModel = _mapper.Map<Enterprise>(enterpriseCreateDto);
            _repository.CreateEnterprise(enterpriseModel);
            _repository.SaveChanges();

            var enterpriseReadDto = _mapper.Map<EnterpriseReadDto>(enterpriseModel);
            
            return CreatedAtRoute(nameof(GetEnterpriseById), new {Id=enterpriseReadDto.Id}, enterpriseReadDto);

        }


        //PATCH api/enterprises/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialEnterpriseUpdate(int id, JsonPatchDocument<EnterpriseUpdateDto> patchDoc)
        {
            var enterpriseModelFromRepo = _repository.GetEnterpriseById(id);
            if (enterpriseModelFromRepo== null)
            {
                return NotFound();
            }

            var enterpriseToPatch = _mapper.Map<EnterpriseUpdateDto>(enterpriseModelFromRepo);
            patchDoc.ApplyTo(enterpriseToPatch, ModelState);

            if (!TryValidateModel(enterpriseToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(enterpriseToPatch, enterpriseModelFromRepo);

            _repository.UpdateEnterprise(enterpriseModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

    }

}