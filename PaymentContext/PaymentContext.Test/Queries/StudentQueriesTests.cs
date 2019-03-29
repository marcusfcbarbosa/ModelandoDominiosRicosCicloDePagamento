using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects.Enums;
using System.Collections.Generic;
using PaymentContext.Domain.Queries;
using System.Linq;

namespace PaymentContext.Test.Queries
{

    

    [TestClass]
    public class StudentQueriesTests
    {

        private IList<Student> _students;
        public StudentQueriesTests(){
            for(var i=0; i <=10;i++){
                //_students.Add(new Student(new Name()))
            }
        }
        
        [TestMethod]
        public void RetornaUsuarioQueExistam(){
            var exp = StudentQueries.GetStudent("656646564");
            var stud = _students.AsQueryable().Where(exp).FirstOrDefault();
            Assert.AreNotEqual(null,stud);
        }

    }

}