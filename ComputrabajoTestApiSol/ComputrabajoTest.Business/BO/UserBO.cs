using System;
using System.Data.Entity;
using System.Linq.Expressions;
using ComputrabajoTest.Business.Interfaces;
using ComputrabajoTest.Data.Context;
using ComputrabajoTest.DataAccess.DA;
using ComputrabajoTest.Entities.BE;
using ComputrabajoTest.Entities.MP.Base;
using ComputrabajoTest.Entities.VM;
using ComputrabajoTest.Utilities.Helper.Database;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ComputrabajoTest.Business.BO
{
    public class UserBO : IUserBO
    {
        private readonly IServiceScopeFactory _scopeFactory;

        #region ctors
        public UserBO(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        #endregion

        /// <summary>
        /// get all user by filters, in this case user dont have filters in front
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public BaseGetAllOut<UserBE> GetAll(BaseListFilterIn input)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ComputrabajoTestContext>();
                UserDA userDA = new UserDA(db);

                #region data base operations
                Expression<Func<UserBE, bool>>? iquerable = SetEntityFilters(input.ListItemFilters);
                #endregion

                IQueryable<UserBE> iQuerable = userDA.Get(iquerable);
                int totalRows = iQuerable.Count();
                iQuerable = Pagination.Paginate(iQuerable, input.Page, input.ToShow);

                return new BaseGetAllOut<UserBE>()
                {
                    TotalRows = totalRows,
                    ListResult = iQuerable.ToList()
                };
            }
        }

        /// <summary>
        /// get user detail
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public BaseGetDetailOut<UserBE> GetDetail(BaseGetDetailIn input)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ComputrabajoTestContext>();
                UserDA userDA = new UserDA(db);
                UserBE? userBE = userDA.GetFirstOrDefault(x => x.Id.Equals(input.Id));

                return new BaseGetDetailOut<UserBE>()
                {
                    ResultEntity = userBE
                };
            }
        }

        /// <summary>
        /// build expression for filter users  
        /// </summary>
        /// <param name="listItem"></param>
        /// <returns></returns>
        private Expression<Func<UserBE, bool>>? SetEntityFilters(List<ItemFilterVM> listItem)
        {
            Expression<Func<UserBE, bool>>? predicate = null;

            if (listItem != null && listItem.Any(x => !string.IsNullOrEmpty(x.Name)))
            {
                if (listItem.Any(x => x.Name.Equals("Name")))
                {
                    int valueFilter = int.Parse(listItem.First(x => x.Name == "Name").Value);
                    predicate = (x => x.Name.Equals(valueFilter));
                }

                if (listItem.Any(x => x.Name.Equals("Username")))
                {
                    string valueFilter = listItem.First(x => x.Name == "Username").Value.ToLower();
                    Expression<Func<UserBE, bool>> expressionFilter = (x => x.Name.ToLower().Contains(valueFilter));
                    predicate = predicate == null ? expressionFilter : predicate.And(expressionFilter);
                }
            }

            return predicate;
        }
    }
}

