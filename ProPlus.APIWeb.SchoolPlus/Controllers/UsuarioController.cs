using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using ProPlus.APIWeb.SchoolPlus.DbContext;
using ProPlus.Comum.Repositorios.Interfaces;

namespace ProPlus.APIWeb.SchoolPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //private IRepositorioComum<Usuario, int> _repositorioUsuario 
        //= new ProPlus.APIWeb.SchoolPlus.Repositorios.Entity.RepositorioUsuario();
    }
}