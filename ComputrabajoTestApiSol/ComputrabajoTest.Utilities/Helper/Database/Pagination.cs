using System;
namespace ComputrabajoTest.Utilities.Helper.Database
{
    public static class Pagination
    {
        /// <summary>
        /// helper with generic pagination iquerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryable"></param>
        /// <param name="amountToShow"></param>
        /// <returns></returns>
        public static int GetTotalPages<T>(List<T> queryable, int amountToShow)
        {
            return queryable.Count / amountToShow;
        }

        public static IQueryable<T> Paginate<T>(this IQueryable<T> iQueryable, int? page, int? toShow)
        {
            if (page.HasValue && page.Value > 0 && toShow.HasValue && toShow.Value > 0)
                return iQueryable.Skip((page.Value - 1) * toShow.Value).Take(toShow.Value);

            return iQueryable;
        }
    }
}

