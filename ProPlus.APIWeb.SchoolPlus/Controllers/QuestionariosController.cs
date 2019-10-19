using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using ProPlus.APIWeb.SchoolPlus.AutoMapper;
using ProPlus.APIWeb.SchoolPlus.Dto;
using ProPlus.APIWeb.SchoolPlus.Repositorios;
using ProPlus.Comum.Repositorios.Interfaces;

namespace ProPlus.APIWeb.SchoolPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionariosController : ControllerBase
    {
        protected IRepositorioComum<Questionario, int> _repositorio;
        public QuestionariosController()
        {
            _repositorio = new RepositorioQuestionario(new DbContext.SchoolPlusDbContext());
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Questionario> quests = _repositorio.Selecionar();
            List<DtoQuestionario> dtos = AutoMapperManager.Instance.Mapper.Map<List<Questionario>, List<DtoQuestionario>>(quests);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int? id)
        {
            if (!id.HasValue)
                return BadRequest();
            var quest = _repositorio.SelecionarPorID(id.Value);
            if (quest == null)
                return NotFound();
            DtoQuestionario dto = AutoMapperManager.Instance.Mapper.Map<Questionario, DtoQuestionario>(quest);
            return StatusCode(302, dto);
        }

        public IActionResult Post([FromBody]DtoQuestionario dto)
        {
            if (ModelState.IsValid)
                try
                {
                    var quest = AutoMapperManager.Instance.Mapper.Map<DtoQuestionario, Questionario>(dto);
                    var pathURI = Request.Path.ToString();
                    _repositorio.Inserir(quest);
                    return Created($"URL de retorno no header: {pathURI}/{quest.QuestionarioID}", quest);
                }
                catch (Exception ex)
                {
                    return UnprocessableEntity(ex.Message);
                }
            else
                return BadRequest(ModelState.Values);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int? id, [FromBody]DtoQuestionario dto)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                Questionario quest = AutoMapperManager.Instance.Mapper.Map<DtoQuestionario, Questionario>(dto);
                quest.QuestionarioID = id.Value;
                _repositorio.Atualizar(quest);
                return Ok();
            }
            catch (Exception ex)
            {
                return UnprocessableEntity(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                var usuario = _repositorio.SelecionarPorID(id.Value);
                if (usuario == null)
                {
                    return NotFound();
                }
                _repositorio.ExcluirPorID(id.Value);
                return Ok();
            }
            catch (Exception ex)
            {
                return UnprocessableEntity(ex.Message);
            }
        }
    }
}