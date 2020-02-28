using JasonsBlog.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JasonsBlog.Tests
{
    public class IRepositoryTests
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new MedContext();
            var underTest = new IRepository(db);

            var count = underTest.Count();

            Assert.Equal(1, count);
        }
    }
}
