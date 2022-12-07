using System;
using ComputrabajoTest.Entities.BE;
using ComputrabajoTest.Entities.MP.Base;

namespace ComputrabajoTest.Business.Interfaces
{
	public interface IUserBO
	{
        BaseGetAllOut<UserBE> GetAll(BaseListFilterIn input);
        BaseGetDetailOut<UserBE> GetDetail(BaseGetDetailIn input);
    }
}

