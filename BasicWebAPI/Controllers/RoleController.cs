using BasicWebAPI.BLL.Abstract;
using BasicWebAPI.DTOs.RoleDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roleService.Get());

        }
        [HttpPost]
        public IActionResult Add(RoleToAddDTO roleToAddDTO)
        {
            _roleService.Add(roleToAddDTO);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int roleid)
        {
            _roleService.Delete(roleid);
            return Ok();
        }
    }
}
