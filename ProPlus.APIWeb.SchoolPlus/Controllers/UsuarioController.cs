using Microsoft.AspNetCore.Mvc;
using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using ProPlus.APIWeb.SchoolPlus.AutoMapper;
using ProPlus.APIWeb.SchoolPlus.DbContext;
using ProPlus.APIWeb.SchoolPlus.Dto;
using ProPlus.APIWeb.SchoolPlus.Repositorios;
using ProPlus.Comum.Repositorios.Interfaces;
using System.Collections.Generic;

namespace ProPlus.APIWeb.SchoolPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IRepositorioComum<Usuario, int> repositorioUsuario;
        public UsuarioController()
        {
            repositorioUsuario = new RepositorioUsuario(new SchoolPlusDbContext());
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Usuario> users = repositorioUsuario.Selecionar();
            List<DtoUsuario> dtos = AutoMapperManager.Instance.Mapper.Map<List<Usuario>, List<DtoUsuario>>(users);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int? id)
        {
            if (!id.HasValue)
                return BadRequest();
            var usuario = repositorioUsuario.SelecionarPorID(id.Value);
            if (usuario == null)
                return NotFound();
            DtoUsuario dto = AutoMapperManager.Instance.Mapper.Map<Usuario, DtoUsuario>(usuario);
            return StatusCode(302, dto);
        }

        public IActionResult Post([FromBody]DtoUsuario dto)
        {
            if (ModelState.IsValid)
                try
                {
                    Usuario usuario = AutoMapperManager.Instance.Mapper.Map<DtoUsuario, Usuario>(dto);
                    var pathURI = Request.Path.ToString();
                    repositorioUsuario.Inserir(usuario);
                    return Created($"URL de retorno no header: {pathURI}/{usuario.Id}", usuario);
                }
                catch (System.Exception ex)
                {
                    return UnprocessableEntity(ex.Message);
                }
            else
                return BadRequest(ModelState.Values);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int? id, [FromBody]DtoUsuario dto)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                Usuario usuario = AutoMapperManager.Instance.Mapper.Map<DtoUsuario, Usuario>(dto);
                usuario.Id = id.Value;
                repositorioUsuario.Atualizar(usuario);
                return Ok();
            }
            catch (System.Exception ex)
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
                var usuario = repositorioUsuario.SelecionarPorID(id.Value);
                if (usuario == null)
                {
                    return NotFound();
                }
                repositorioUsuario.ExcluirPorID(id.Value);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return UnprocessableEntity(ex.Message);
            }
        }
    }
}