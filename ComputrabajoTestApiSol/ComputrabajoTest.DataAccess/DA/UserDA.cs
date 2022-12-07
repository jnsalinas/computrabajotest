using System;
using ComputrabajoTest.Data.Context;
using ComputrabajoTest.DataAccess.DA.Base;
using ComputrabajoTest.Entities.BE;
using Microsoft.EntityFrameworkCore;

namespace ComputrabajoTest.DataAccess.DA
{
	public class UserDA : BaseDA<UserBE>
    {
        public UserDA(ComputrabajoTestContext context) : base(context)
        {
        }

        /// <summary>
        /// Includes for detail
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returnsIncludeDetailByDefault
        public override IQueryable<UserBE> IncludeDetailByDefault(IQueryable<UserBE> Value)
        {
            return Value.Include(x => x.Company)
                .Include(x => x.Role)
                .Include(x => x.Status)
                .Include(x => x.Portal);
        }
    }
}

