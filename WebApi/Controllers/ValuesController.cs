using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.DBContext;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        public readonly StudentDBContext studentDBContext;
        //public readonly EmployeeDBContext employeeDBContext;
        public ValuesController()
        {
            this.studentDBContext = new StudentDBContext();
        }

        [ActionName("CreateStudent")]
        [HttpPost]
        public int Create(Student student)
        {
            //Student existingRecord = this.studentDBContext.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            this.studentDBContext.Students.Add(student);

            //this.studentDBContext.Entry(existingRecord).CurrentValues.SetValues(student);

            this.studentDBContext.SaveChanges();

            return student.Id;
        }

        [ActionName("GetStudents")]
        public IEnumerable<Student> Get()
        {
            return this.studentDBContext.Students.ToList();
        }

        [ActionName("GetStudentDetails")]
        public async Task<Student> Get(int id)
        {
            return await this.studentDBContext.Students.Where(x => x.Id == id).FirstAsync();
        }

        [ActionName("UpdateStudent")]
        [HttpPost]
        public int Update(Student student)
        {
            Student existingRecord = this.studentDBContext.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            //this.studentDBContext.Students.Add(student);

            this.studentDBContext.Entry(existingRecord).CurrentValues.SetValues(student);

            this.studentDBContext.SaveChanges();

            return student.Id;
        }

        //[AllowAnonymous]
        //// GET api/values
        //[ActionName("GetValues")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //[ActionName("getvalues1")]
        //[AllowAnonymous]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [AllowAnonymous]
        [HttpPost]
        public string Get(string id)
        {
            return id;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        //delete api/values/5
        [HttpDelete]
        [ActionName("DeleteStudent")]
        public void Delete(int id)
        {
            var remove = this.studentDBContext.Students.Where(x => x.Id == id).FirstOrDefault();
            this.studentDBContext.Students.Remove(remove);
            this.studentDBContext.SaveChanges();
        }

        
    }
}
