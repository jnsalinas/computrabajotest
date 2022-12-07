using System;
using ComputrabajoTest.Business.Interfaces;
using ComputrabajoTest.Entities.BE;
using ComputrabajoTest.Entities.MP.Base;
using Microsoft.AspNetCore.Mvc;

namespace ComputrabajoTest.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IUserBO _userBO;
        public UserController(IUserBO userBO)
        {
            _userBO = userBO;
        }

        /// <summary>
        /// Get all users by page and number of rows
        /// </summary>
        /// <param name="page"></param>
        /// <param name="toShow"></param>
        /// <returns></returns>
        [HttpGet("redarbor")]
        public IActionResult GetAll(int? page, int? toShow)
        {
            return Ok(_userBO.GetAll(new BaseListFilterIn()
            {
                Page = page,
                ToShow = toShow
            }));
        }

        /// <summary>
        /// get all object user by detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("redarbordetail")]
        public IActionResult GetById(int id)
        {
            BaseGetDetailOut<UserBE> userBEDetail = _userBO.GetDetail(new BaseGetDetailIn()
            {
                Id = id
            });
            return Ok(userBEDetail);
        }
    }
}

