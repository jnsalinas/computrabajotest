using System;
using System.Linq.Expressions;
using ComputrabajoTest.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ComputrabajoTest.DataAccess.DA.Base
{
    public class BaseDA<T> : IBaseDA<T> where T : class
    {
        public static ComputrabajoTestContext Context;

        public BaseDA(ComputrabajoTestContext _context)
        {
            Context = _context;
        }

        #region public methods
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> resultData = IncludeByDefault(Context.Set<T>().AsNoTracking());

            if (predicate != null)
                resultData = resultData.Where(predicate);

            return resultData;
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> resultData = IncludeByDefault(Context.Set<T>().AsNoTracking());

            if (predicate != null)
                resultData = resultData.Where(predicate);

            return resultData.Any();
        }

        public T? GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> resultData = IncludeDetailByDefault(Context.Set<T>().AsNoTracking());

            if (predicate != null)
                resultData = resultData.Where(predicate);

            return resultData.FirstOrDefault();
        }

        public T? Get(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes = null)
        {
            IQueryable<T> resultData = Context.Set<T>().AsNoTracking();

            if (includes != null && includes.Any())
            {
                foreach (var item in includes)
                {
                    resultData = resultData.Include(item);
                }
            }

            resultData = resultData.Where(predicate);

            return resultData.FirstOrDefault();
        }

        public T InsertOrUpdate(T input)
        {
            var itemId = Convert.ToUInt32(GetValuePrimaryKey(input));
            if (itemId > 0)
                Context.Entry(input).State = EntityState.Modified;
            else
                Context.Entry(input).State = EntityState.Added;

            Context.SaveChanges();
            Context.Entry(input).State = EntityState.Detached; // hack error entity framework

            return input;
        }

        public void Delete(T input)
        {
            Convert.ToUInt32(GetValuePrimaryKey(input));
            Context.Entry(input).State = EntityState.Deleted;
            Context.SaveChanges();
            Context.Entry(input).State = EntityState.Detached; // hack error entity framework
        }

        /// <summary>
        /// Include by details
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual IQueryable<T> IncludeDetailByDefault(IQueryable<T> value)
        {
            return value;
        }

        /// <summary>
        /// Includes by list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual IQueryable<T> IncludeByDefault(IQueryable<T> value)
        {
            return value;
        }
        #endregion

        #region protected methods
        private object? GetValuePrimaryKey(T entity)
        {
            string keyName = GetPrimaryKeyName();
            object value = typeof(T).GetProperty(keyName).GetValue(entity);
            return value;
        }

        private string GetPrimaryKeyName()
        {
            var keyNames = Context.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties.Select(x => x.Name);
            string keyName = keyNames.FirstOrDefault();

            if (keyNames.Count() > 1)
            {
                throw new Exception();
            }

            if (keyName == null)
            {
                throw new Exception();
            }

            return keyName;
        }


        #endregion

    }
}

