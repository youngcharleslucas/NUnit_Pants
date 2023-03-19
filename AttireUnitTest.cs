using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WearPants;

namespace WearPants
{
    [TestFixture]
    public class AttireUnitTest
    {
        private string sunday;
        private string monday;
        private string tuesday;
        private string wednesday;
        private string thursday;
        private string friday;
        private string saturday;
        private Attire attire; 

        [SetUp]
        protected void Setup()
        {
            sunday = "It's Sunday! It's party time! I have to wear party pants for this occasion.";
            monday = "It's Monday! It's business time. I have to wear dress pants for this occasion.";
            tuesday = "It's Tuesday! It's business time. I have to wear dress pants for this occasion.";
            wednesday = "It's Wednesday! It's business time. I have to wear dress pants for this occasion.";
            thursday = "It's Thursday! It's business time. I have to wear dress pants for this occasion.";
            friday = "It's Friday! It's business time. I have to wear dress pants for this occasion.";
            saturday = "It's Saturday! It's party time! I have to wear party pants for this occasion.";

            attire = new Attire();
        }

        //Arrange, Act, Assert
        [TestCase(Days.SUNDAY, Pants.PARTY)]
        [Test]
        public void WhatToWear_RightPantsForSunday(string day, string pant)
        {
            Assert.AreEqual(sunday, attire.WhatToWear(day, pant));
        }
        [TestCase(Days.MONDAY, Pants.DRESS)]
        [Test]
        public void WhatToWear_RightPantsForMonday(string day, string pant)
        {
            Assert.AreEqual(monday, attire.WhatToWear(day, pant));
        }

        [TestCase(Days.TUESDAY, Pants.DRESS)]
        [Test]
        public void WhatToWear_RightPantsForTuesday(string day, string pant)
        {
            Assert.AreEqual(tuesday, attire.WhatToWear(day, pant));
        }

        //It's only Wednesday!! It is too early in the week for party pants!
        [TestCase(Days.WEDNESDAY, Pants.PARTY)]
        [Test]
        public void WhatToWear_RightPantsForWednesday(string day, string pant)
        {
            Assert.AreEqual(wednesday, attire.WhatToWear(day, pant));
        }

        [TestCase(Days.THURSDAY, Pants.DRESS)]
        [Test]
        public void WhatToWear_RightPantsForThursday(string day, string pant)
        {
            Assert.AreEqual(thursday, attire.WhatToWear(day, pant));
        }
        [TestCase(Days.FRIDAY, Pants.DRESS)]
        [Test]
        public void WhatToWear_RightPantsForFriday(string day, string pant)
        {
            Assert.AreEqual(friday, attire.WhatToWear(day, pant));
        }

        [TestCase(Days.SATURDAY, Pants.PARTY)]
        [Test]
        public void WhatToWear_RightPantsForSaturday(string day, string pant)
        {
            Assert.AreEqual(saturday, attire.WhatToWear(day, pant));
        }
    }
}
