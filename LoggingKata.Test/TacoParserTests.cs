using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        //DONE TODO Add additional inline data. Refer to your CSV file.
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth...",-84.683302)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...",-84.913185)]
        [InlineData("34.2223,-84.503673,Taco Bell Canton...",-84.503673)]
        [InlineData("33.352214,-84.124288,Taco Bell Locust Grov...", -84.124288)]
        //[InlineData(null, 0)]
        
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var longitude = new TacoParser();
            
            //Act
            var actual = longitude.Parse(line);
            
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth...",34.035985)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...",34.376395)]
        [InlineData("34.2223,-84.503673,Taco Bell Canton...",34.2223)]
        [InlineData("33.352214,-84.124288,Taco Bell Locust Grov...", 33.352214)]

        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var latitude = new TacoParser();

            //Act
            var actual = latitude.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
