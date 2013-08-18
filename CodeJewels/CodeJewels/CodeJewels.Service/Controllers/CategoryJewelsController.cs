using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeJewels.Data;
using CodeJewels.Models;

namespace CodeJewels.Service.Controllers
{
    public class CategoryJewelsController : ApiController
    {
        CodeJewelsContext dbContext;

        public CategoryJewelsController(CodeJewelsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET api/categoryjewels
        public IEnumerable<CodeJewelCategory> Get()
        {
            return this.dbContext.CodeJewelCategory.AsEnumerable();
        }

        // GET api/categoryjewels/5
        public CodeJewelCategory Get(int id)
        {
            return this.dbContext.CodeJewelCategory.Find(id);
        }

        // POST api/categoryjewels
        public CodeJewelCategory Post(CodeJewelCategory value)
        {
            var added = this.dbContext.CodeJewelCategory.Add(value);
            this.dbContext.SaveChanges();

            return added;
        }

        // PUT api/categoryjewels/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/categoryjewels/5
        public void Delete(int id)
        {
        }
    }
}