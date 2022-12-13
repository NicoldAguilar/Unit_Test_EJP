using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCUnitTestingProject
{
    public class UserControllerTest
    {
        [Test]
        public void IndexOkCase01()
        {
            var controller = new UserController(new DbEntities());
            Assert.AreEqual(1, controller.Users.Count); 
        }
    }
}
