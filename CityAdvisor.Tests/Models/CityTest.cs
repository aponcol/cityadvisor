using System;
using System.Collections.Generic;
using CityAdvisor.Models;
using NUnit.Framework;
namespace CityAdvisor.Tests.Models
{
    [TestFixture]
    public class CityDataImporterTest
    {
        int TotalNumberOfCities = 6747;

        [Test]
        public void GetDataFromFileTotalNumberOfCities()
        {
            CityDataImporter importer = new CityDataImporter();
            List<City> cities = importer.GetCitiesFromFile("cities_canada-usa.tsv");

            Assert.AreEqual(cities.Count, TotalNumberOfCities);
        }
    }
}
