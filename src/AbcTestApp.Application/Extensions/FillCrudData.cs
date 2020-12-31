using AbcTestApp.Domain.Kernel;
using AbcTestApp.Infrastructure.Data.Identity.Extensions;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace AbcTestApp.Application.Extensions
{
    public static class FillCrudData<T> where T : IEntryData, IUpdateData, IDeleteData
    {
        public static void Entry(ref T entity)
        {
            entity.CreatedBy = ClaimsPrincipalExtensions.GetLoggedInUserName(ClaimsPrincipal.Current) ?? "publicUser";
            entity.CreatedOn = DateTime.Now;
        }

        public static void Update(ref T entity)
        {
            entity.UpdatedBy = ClaimsPrincipalExtensions.GetLoggedInUserName(ClaimsPrincipal.Current) ?? "publicUser";
            entity.UpdatedOn = DateTime.Now;
        }

        public static void Delete(ref T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedBy = ClaimsPrincipalExtensions.GetLoggedInUserName(ClaimsPrincipal.Current) ?? "publicUser";
            entity.DeletedOn = DateTime.Now;
        }
    }
}
